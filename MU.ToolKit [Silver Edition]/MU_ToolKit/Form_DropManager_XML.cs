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
        private bool suppressMonsterFieldEvents;
        private bool suppressItemFieldEvents;
        private bool suppressMonsterSelectionChange;
        private bool suppressItemSelectionChange;
        private Structures.IGCDropManagerXmlFile currentFile = new Structures.IGCDropManagerXmlFile();
        private string currentFilePath;

        public Form_DropManager_XML()
        {
            InitializeComponent();
            monsterBindingSource.CurrentChanged += MonsterBindingSource_CurrentChanged;
            itemBindingSource.CurrentChanged += ItemBindingSource_CurrentChanged;
            listBoxMonsters.DataSource = monsterBindingSource;
            listBoxItems.DataSource = itemBindingSource;
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
            textBoxDropUseRate.Text = currentFile.DropUseRate;
            monsterBindingSource.ResetBindings(false);
            RefreshMonsterDetails();
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
            groupBoxItemList.Enabled = monster != null;
            RefreshItemDetails();
        }

        private void MonsterBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            RefreshMonsterDetails();
            UpdateItemBinding();
        }

        private void ItemBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            RefreshItemDetails();
        }

        private void RefreshMonsterDetails()
        {
            suppressMonsterFieldEvents = true;
            var monster = monsterBindingSource.Current as Structures.IGCDropManagerXmlMonster;
            if (monster != null)
            {
                textBoxMonsterIndex.Text = monster.Index;
                textBoxMonsterMinLevel.Text = monster.MonsterMinLevel;
                textBoxMonsterMaxLevel.Text = monster.MonsterMaxLevel;
                textBoxMonsterMapNumber.Text = monster.MapNumber;
                textBoxMonsterItemRate.Text = monster.ItemRate;
                textBoxMonsterItemCount.Text = monster.ItemCount;
                textBoxMonsterCoinReward.Text = monster.CoinReward;
                textBoxMonsterCoinType.Text = monster.CoinType;
                textBoxMonsterCoinValue.Text = monster.CoinValue;
                textBoxMonsterPlayerMinLevel.Text = monster.PlayerMinLevel;
                textBoxMonsterPlayerMaxLevel.Text = monster.PlayerMaxLevel;
            }
            else
            {
                textBoxMonsterIndex.Text = string.Empty;
                textBoxMonsterMinLevel.Text = string.Empty;
                textBoxMonsterMaxLevel.Text = string.Empty;
                textBoxMonsterMapNumber.Text = string.Empty;
                textBoxMonsterItemRate.Text = string.Empty;
                textBoxMonsterItemCount.Text = string.Empty;
                textBoxMonsterCoinReward.Text = string.Empty;
                textBoxMonsterCoinType.Text = string.Empty;
                textBoxMonsterCoinValue.Text = string.Empty;
                textBoxMonsterPlayerMinLevel.Text = string.Empty;
                textBoxMonsterPlayerMaxLevel.Text = string.Empty;
            }

            groupBoxMonsterDetails.Enabled = monster != null;
            groupBoxItemList.Enabled = monster != null;
            if (monster == null)
            {
                groupBoxItemDetails.Enabled = false;
            }

            suppressMonsterFieldEvents = false;

            suppressMonsterSelectionChange = true;
            if (monster != null && monsterBindingSource.Position >= 0)
            {
                listBoxMonsters.SelectedIndex = monsterBindingSource.Position;
            }
            else
            {
                listBoxMonsters.SelectedIndex = -1;
            }
            suppressMonsterSelectionChange = false;
        }

        private void RefreshItemDetails()
        {
            suppressItemFieldEvents = true;
            var item = itemBindingSource.Current as Structures.IGCDropManagerXmlItem;
            if (item != null)
            {
                textBoxItemCat.Text = item.Cat;
                textBoxItemIndex.Text = item.Index;
                textBoxItemMinLevel.Text = item.ItemMinLevel;
                textBoxItemMaxLevel.Text = item.ItemMaxLevel;
                textBoxItemDurability.Text = item.Durability;
                textBoxItemSkill.Text = item.Skill;
                textBoxItemLuck.Text = item.Luck;
                textBoxItemOption.Text = item.Option;
                textBoxItemExc.Text = item.Exc;
                textBoxItemSetItem.Text = item.SetItem;
                textBoxItemSocketCount.Text = item.SocketCount;
                textBoxItemElementalItem.Text = item.ElementalItem;
                textBoxItemMuunCat.Text = item.MuunEvolutionItemCat;
                textBoxItemMuunIndex.Text = item.MuunEvolutionItemIndex;
                textBoxItemDropRate.Text = item.DropRate;
                textBoxItemDuration.Text = item.Duration;
            }
            else
            {
                textBoxItemCat.Text = string.Empty;
                textBoxItemIndex.Text = string.Empty;
                textBoxItemMinLevel.Text = string.Empty;
                textBoxItemMaxLevel.Text = string.Empty;
                textBoxItemDurability.Text = string.Empty;
                textBoxItemSkill.Text = string.Empty;
                textBoxItemLuck.Text = string.Empty;
                textBoxItemOption.Text = string.Empty;
                textBoxItemExc.Text = string.Empty;
                textBoxItemSetItem.Text = string.Empty;
                textBoxItemSocketCount.Text = string.Empty;
                textBoxItemElementalItem.Text = string.Empty;
                textBoxItemMuunCat.Text = string.Empty;
                textBoxItemMuunIndex.Text = string.Empty;
                textBoxItemDropRate.Text = string.Empty;
                textBoxItemDuration.Text = string.Empty;
            }

            groupBoxItemDetails.Enabled = item != null;
            suppressItemFieldEvents = false;

            suppressItemSelectionChange = true;
            if (item != null && itemBindingSource.Position >= 0)
            {
                listBoxItems.SelectedIndex = itemBindingSource.Position;
            }
            else
            {
                listBoxItems.SelectedIndex = -1;
            }
            suppressItemSelectionChange = false;
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

        private void listBoxMonsters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suppressMonsterSelectionChange)
            {
                return;
            }

            if (listBoxMonsters.SelectedIndex >= 0 && listBoxMonsters.SelectedIndex < monsterBindingSource.Count)
            {
                monsterBindingSource.Position = listBoxMonsters.SelectedIndex;
            }
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suppressItemSelectionChange)
            {
                return;
            }

            if (listBoxItems.SelectedIndex >= 0 && listBoxItems.SelectedIndex < itemBindingSource.Count)
            {
                itemBindingSource.Position = listBoxItems.SelectedIndex;
            }
        }

        private void MonsterField_TextChanged(object sender, EventArgs e)
        {
            if (suppressMonsterFieldEvents)
            {
                return;
            }

            if (!(monsterBindingSource.Current is Structures.IGCDropManagerXmlMonster monster))
            {
                return;
            }

            if (sender is TextBox textBox)
            {
                string value = textBox.Text.Trim();
                if (textBox == textBoxMonsterIndex)
                {
                    monster.Index = value;
                }
                else if (textBox == textBoxMonsterMinLevel)
                {
                    monster.MonsterMinLevel = value;
                }
                else if (textBox == textBoxMonsterMaxLevel)
                {
                    monster.MonsterMaxLevel = value;
                }
                else if (textBox == textBoxMonsterMapNumber)
                {
                    monster.MapNumber = value;
                }
                else if (textBox == textBoxMonsterItemRate)
                {
                    monster.ItemRate = value;
                }
                else if (textBox == textBoxMonsterItemCount)
                {
                    monster.ItemCount = value;
                }
                else if (textBox == textBoxMonsterCoinReward)
                {
                    monster.CoinReward = value;
                }
                else if (textBox == textBoxMonsterCoinType)
                {
                    monster.CoinType = value;
                }
                else if (textBox == textBoxMonsterCoinValue)
                {
                    monster.CoinValue = value;
                }
                else if (textBox == textBoxMonsterPlayerMinLevel)
                {
                    monster.PlayerMinLevel = value;
                }
                else if (textBox == textBoxMonsterPlayerMaxLevel)
                {
                    monster.PlayerMaxLevel = value;
                }

                monsterBindingSource.ResetCurrentItem();
                listBoxMonsters.Refresh();
            }
        }

        private void ItemField_TextChanged(object sender, EventArgs e)
        {
            if (suppressItemFieldEvents)
            {
                return;
            }

            if (!(itemBindingSource.Current is Structures.IGCDropManagerXmlItem item))
            {
                return;
            }

            if (sender is TextBox textBox)
            {
                string value = textBox.Text.Trim();
                if (textBox == textBoxItemCat)
                {
                    item.Cat = value;
                }
                else if (textBox == textBoxItemIndex)
                {
                    item.Index = value;
                }
                else if (textBox == textBoxItemMinLevel)
                {
                    item.ItemMinLevel = value;
                }
                else if (textBox == textBoxItemMaxLevel)
                {
                    item.ItemMaxLevel = value;
                }
                else if (textBox == textBoxItemDurability)
                {
                    item.Durability = value;
                }
                else if (textBox == textBoxItemSkill)
                {
                    item.Skill = value;
                }
                else if (textBox == textBoxItemLuck)
                {
                    item.Luck = value;
                }
                else if (textBox == textBoxItemOption)
                {
                    item.Option = value;
                }
                else if (textBox == textBoxItemExc)
                {
                    item.Exc = value;
                }
                else if (textBox == textBoxItemSetItem)
                {
                    item.SetItem = value;
                }
                else if (textBox == textBoxItemSocketCount)
                {
                    item.SocketCount = value;
                }
                else if (textBox == textBoxItemElementalItem)
                {
                    item.ElementalItem = value;
                }
                else if (textBox == textBoxItemMuunCat)
                {
                    item.MuunEvolutionItemCat = value;
                }
                else if (textBox == textBoxItemMuunIndex)
                {
                    item.MuunEvolutionItemIndex = value;
                }
                else if (textBox == textBoxItemDropRate)
                {
                    item.DropRate = value;
                }
                else if (textBox == textBoxItemDuration)
                {
                    item.Duration = value;
                }

                itemBindingSource.ResetCurrentItem();
                listBoxItems.Refresh();
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
