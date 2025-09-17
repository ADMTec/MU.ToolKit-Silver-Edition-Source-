using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace MU_ToolKit
{
    public partial class Form_DropManager_XML : Form
    {
        private readonly BindingSource monsterBindingSource = new BindingSource();
        private readonly BindingSource itemBindingSource = new BindingSource();
        private Structures.IGCDropManagerXmlFile currentFile = new Structures.IGCDropManagerXmlFile();
        private string currentFilePath;

        public Form_DropManager_XML()
        {
            InitializeComponent();
            dataGridViewMonsters.AutoGenerateColumns = false;
            dataGridViewItems.AutoGenerateColumns = false;
            monsterBindingSource.CurrentChanged += MonsterBindingSource_CurrentChanged;
        }

        private void Form_DropManager_XML_Load(object sender, EventArgs e)
        {
            BindFile(new Structures.IGCDropManagerXmlFile());
            Form form = Application.OpenForms["Form1"];
            if (form != null)
            {
                form.WindowState = FormWindowState.Minimized;
            }
            WindowState = FormWindowState.Normal;
            TopMost = true;
            TopMost = false;
            BringToFront();
            Focus();
        }

        private void Form_DropManager_XML_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form1"] != null)
            {
                Application.OpenForms["Form1"].WindowState = FormWindowState.Normal;
            }
        }

        private void BindFile(Structures.IGCDropManagerXmlFile file)
        {
            currentFile = file ?? new Structures.IGCDropManagerXmlFile();
            monsterBindingSource.DataSource = currentFile.Monsters;
            dataGridViewMonsters.DataSource = monsterBindingSource;
            textBoxDropUseRate.Text = currentFile.DropUseRate;
            UpdateItemBinding();
        }

        private void UpdateItemBinding()
        {
            var monster = monsterBindingSource.Current as Structures.IGCDropManagerXmlMonster;
            if (monster != null)
            {
                itemBindingSource.DataSource = monster.Items;
            }
            else
            {
                itemBindingSource.DataSource = null;
            }

            dataGridViewItems.DataSource = itemBindingSource;
        }

        private void MonsterBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            UpdateItemBinding();
        }

        private void dataGridViewMonsters_SelectionChanged(object sender, EventArgs e)
        {
            if (monsterBindingSource.Position != dataGridViewMonsters.CurrentCell?.RowIndex && dataGridViewMonsters.CurrentCell != null)
            {
                monsterBindingSource.Position = dataGridViewMonsters.CurrentCell.RowIndex;
            }
        }

        private void buttonAddMonster_Click(object sender, EventArgs e)
        {
            var monster = new Structures.IGCDropManagerXmlMonster();
            currentFile.Monsters.Add(monster);
            monsterBindingSource.Position = monsterBindingSource.Count - 1;
        }

        private void buttonRemoveMonster_Click(object sender, EventArgs e)
        {
            if (monsterBindingSource.Current is Structures.IGCDropManagerXmlMonster monster)
            {
                currentFile.Monsters.Remove(monster);
            }
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (monsterBindingSource.Current is Structures.IGCDropManagerXmlMonster monster)
            {
                var item = new Structures.IGCDropManagerXmlItem();
                monster.Items.Add(item);
                itemBindingSource.Position = itemBindingSource.Count - 1;
            }
            else
            {
                MessageBox.Show(this, "Selecione uma seção de monstro antes de adicionar itens.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            if (itemBindingSource.Current is Structures.IGCDropManagerXmlItem item && monsterBindingSource.Current is Structures.IGCDropManagerXmlMonster monster)
            {
                monster.Items.Remove(item);
            }
        }

        private void textBoxDropUseRate_TextChanged(object sender, EventArgs e)
        {
            if (currentFile != null)
            {
                currentFile.DropUseRate = textBoxDropUseRate.Text.Trim();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentFilePath = null;
            BindFile(new Structures.IGCDropManagerXmlFile());
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        var loadedFile = Structures.LoadIGCDropManagerXml(dialog.FileName);
                        currentFilePath = dialog.FileName;
                        BindFile(loadedFile);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, string.Format("Falha ao carregar o arquivo:\n{0}", ex.Message), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                saveAsToolStripMenuItem_Click(sender, e);
                return;
            }

            SaveToPath(currentFilePath);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
                dialog.FileName = string.IsNullOrEmpty(currentFilePath) ? "IGC_DropManager.xml" : Path.GetFileName(currentFilePath);
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    currentFilePath = dialog.FileName;
                    SaveToPath(currentFilePath);
                }
            }
        }

        private void SaveToPath(string path)
        {
            try
            {
                currentFile.DropUseRate = textBoxDropUseRate.Text.Trim();
                Structures.SaveIGCDropManagerXml(currentFile, path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Falha ao salvar o arquivo:\n{0}", ex.Message), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
