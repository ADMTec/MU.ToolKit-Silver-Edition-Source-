using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace MU_ToolKit
{
    public partial class EventBagEditor_XML : Form
    {
        private readonly BindingSource dropAllowBindingSource = new BindingSource();
        private readonly BindingSource dropBindingSource = new BindingSource();
        private readonly BindingSource itemBindingSource = new BindingSource();

        private bool suppressConfigFieldEvents;
        private bool suppressSummonFieldEvents;
        private bool suppressAddCoinFieldEvents;
        private bool suppressDropAllowFieldEvents;
        private bool suppressDropFieldEvents;
        private bool suppressItemFieldEvents;
        private bool suppressDropAllowSelectionChange;
        private bool suppressDropSelectionChange;
        private bool suppressItemSelectionChange;

        private Structures.IGCEventBagXmlFile currentFile = new Structures.IGCEventBagXmlFile();
        private string currentFilePath;

        public EventBagEditor_XML()
        {
            InitializeComponent();
            dropAllowBindingSource.CurrentChanged += DropAllowBindingSource_CurrentChanged;
            dropBindingSource.CurrentChanged += DropBindingSource_CurrentChanged;
            itemBindingSource.CurrentChanged += ItemBindingSource_CurrentChanged;

            listBoxDropAllows.DataSource = dropAllowBindingSource;
            listBoxDrops.DataSource = dropBindingSource;
            listBoxItems.DataSource = itemBindingSource;
        }

        private void EventBagEditor_XML_Load(object sender, EventArgs e)
        {
            BindFile(new Structures.IGCEventBagXmlFile());
            if (Application.OpenForms["Form1"] is Form form)
            {
                form.WindowState = FormWindowState.Minimized;
            }

            WindowState = FormWindowState.Normal;
            TopMost = true;
            TopMost = false;
            BringToFront();
            Focus();
        }

        private void EventBagEditor_XML_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form1"] != null)
            {
                Application.OpenForms["Form1"].WindowState = FormWindowState.Normal;
            }
        }

        private void BindFile(Structures.IGCEventBagXmlFile file)
        {
            currentFile = file ?? new Structures.IGCEventBagXmlFile();
            UpdateConfigFields();
            dropAllowBindingSource.DataSource = currentFile.DropAllows;
            dropAllowBindingSource.ResetBindings(false);
            RefreshDropAllowDetails();
            UpdateDropBinding();
            UpdateFileLabel();
        }

        private void UpdateFileLabel()
        {
            labelCurrentFile.Text = string.IsNullOrWhiteSpace(currentFilePath) ? "New file" : Path.GetFileName(currentFilePath);
        }

        private void UpdateConfigFields()
        {
            suppressConfigFieldEvents = true;
            textBoxBagName.Text = currentFile.BagName;
            textBoxBagItemRate.Text = currentFile.ItemRate;
            textBoxBagSetItemRate.Text = currentFile.SetItemRate;
            textBoxBagMoneyDrop.Text = currentFile.MoneyDrop;
            textBoxBagUseEffect.Text = currentFile.BagUseEffect;
            textBoxBagUseRate.Text = currentFile.BagUseRate;
            suppressConfigFieldEvents = false;

            suppressSummonFieldEvents = true;
            textBoxSummonEnable.Text = currentFile.SummonEnable;
            textBoxSummonDropRate.Text = currentFile.SummonDropRate;
            textBoxSummonItemCat.Text = currentFile.SummonItemCat;
            textBoxSummonItemIndex.Text = currentFile.SummonItemIndex;
            suppressSummonFieldEvents = false;

            suppressAddCoinFieldEvents = true;
            textBoxCoinEnable.Text = currentFile.AddCoinEnable;
            textBoxCoinType.Text = currentFile.AddCoinType;
            textBoxCoinValue.Text = currentFile.AddCoinValue;
            suppressAddCoinFieldEvents = false;
        }

        private void DropAllowBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            RefreshDropAllowDetails();
            UpdateDropBinding();
        }

        private void DropBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            RefreshDropDetails();
            UpdateItemBinding();
        }

        private void ItemBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            RefreshItemDetails();
        }

        private void UpdateDropBinding()
        {
            if (dropAllowBindingSource.Current is Structures.IGCEventBagXmlDropAllow dropAllow)
            {
                dropBindingSource.DataSource = dropAllow.Drops;
            }
            else
            {
                dropBindingSource.DataSource = null;
            }

            dropBindingSource.ResetBindings(false);
            RefreshDropDetails();
            UpdateItemBinding();
        }

        private void UpdateItemBinding()
        {
            if (dropBindingSource.Current is Structures.IGCEventBagXmlDrop drop)
            {
                itemBindingSource.DataSource = drop.Items;
            }
            else
            {
                itemBindingSource.DataSource = null;
            }

            itemBindingSource.ResetBindings(false);
            RefreshItemDetails();
        }

        private void RefreshDropAllowDetails()
        {
            suppressDropAllowFieldEvents = true;
            if (dropAllowBindingSource.Current is Structures.IGCEventBagXmlDropAllow dropAllow)
            {
                textBoxDropAllowWizard.Text = dropAllow.Wizard;
                textBoxDropAllowKnight.Text = dropAllow.Knight;
                textBoxDropAllowFairyElf.Text = dropAllow.FairyElf;
                textBoxDropAllowMagicGladiator.Text = dropAllow.MagicGladiator;
                textBoxDropAllowDarkLord.Text = dropAllow.DarkLord;
                textBoxDropAllowSummoner.Text = dropAllow.Summoner;
                textBoxDropAllowRageFighter.Text = dropAllow.RageFighter;
                textBoxDropAllowPlayerMinLevel.Text = dropAllow.PlayerMinLevel;
                textBoxDropAllowPlayerMaxLevel.Text = dropAllow.PlayerMaxLevel;
                textBoxDropAllowMapNumber.Text = dropAllow.MapNumber;
            }
            else
            {
                textBoxDropAllowWizard.Text = string.Empty;
                textBoxDropAllowKnight.Text = string.Empty;
                textBoxDropAllowFairyElf.Text = string.Empty;
                textBoxDropAllowMagicGladiator.Text = string.Empty;
                textBoxDropAllowDarkLord.Text = string.Empty;
                textBoxDropAllowSummoner.Text = string.Empty;
                textBoxDropAllowRageFighter.Text = string.Empty;
                textBoxDropAllowPlayerMinLevel.Text = string.Empty;
                textBoxDropAllowPlayerMaxLevel.Text = string.Empty;
                textBoxDropAllowMapNumber.Text = string.Empty;
            }

            groupBoxDropAllowDetails.Enabled = dropAllowBindingSource.Current != null;
            groupBoxDropList.Enabled = dropAllowBindingSource.Current != null;
            suppressDropAllowFieldEvents = false;

            suppressDropAllowSelectionChange = true;
            if (dropAllowBindingSource.Position >= 0 && dropAllowBindingSource.Position < dropAllowBindingSource.Count)
            {
                listBoxDropAllows.SelectedIndex = dropAllowBindingSource.Position;
            }
            else
            {
                listBoxDropAllows.SelectedIndex = -1;
            }

            suppressDropAllowSelectionChange = false;
        }

        private void RefreshDropDetails()
        {
            suppressDropFieldEvents = true;
            if (dropBindingSource.Current is Structures.IGCEventBagXmlDrop drop)
            {
                textBoxDropRate.Text = drop.Rate;
                textBoxDropCount.Text = drop.Count;
            }
            else
            {
                textBoxDropRate.Text = string.Empty;
                textBoxDropCount.Text = string.Empty;
            }

            groupBoxDropDetails.Enabled = dropBindingSource.Current != null;
            suppressDropFieldEvents = false;

            suppressDropSelectionChange = true;
            if (dropBindingSource.Position >= 0 && dropBindingSource.Position < dropBindingSource.Count)
            {
                listBoxDrops.SelectedIndex = dropBindingSource.Position;
            }
            else
            {
                listBoxDrops.SelectedIndex = -1;
            }

            suppressDropSelectionChange = false;
        }

        private void RefreshItemDetails()
        {
            suppressItemFieldEvents = true;
            if (itemBindingSource.Current is Structures.IGCEventBagXmlItem item)
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
                textBoxItemKindA.Text = item.KindA;
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
                textBoxItemKindA.Text = string.Empty;
                textBoxItemDropRate.Text = string.Empty;
                textBoxItemDuration.Text = string.Empty;
            }

            groupBoxItemDetails.Enabled = itemBindingSource.Current != null;
            groupBoxItemList.Enabled = dropBindingSource.Current != null;
            suppressItemFieldEvents = false;

            suppressItemSelectionChange = true;
            if (itemBindingSource.Position >= 0 && itemBindingSource.Position < itemBindingSource.Count)
            {
                listBoxItems.SelectedIndex = itemBindingSource.Position;
            }
            else
            {
                listBoxItems.SelectedIndex = -1;
            }

            suppressItemSelectionChange = false;
        }

        private void ConfigField_TextChanged(object sender, EventArgs e)
        {
            if (suppressConfigFieldEvents)
            {
                return;
            }

            if (sender == textBoxBagName)
            {
                currentFile.BagName = textBoxBagName.Text.Trim();
            }
            else if (sender == textBoxBagItemRate)
            {
                currentFile.ItemRate = textBoxBagItemRate.Text.Trim();
            }
            else if (sender == textBoxBagSetItemRate)
            {
                currentFile.SetItemRate = textBoxBagSetItemRate.Text.Trim();
            }
            else if (sender == textBoxBagMoneyDrop)
            {
                currentFile.MoneyDrop = textBoxBagMoneyDrop.Text.Trim();
            }
            else if (sender == textBoxBagUseEffect)
            {
                currentFile.BagUseEffect = textBoxBagUseEffect.Text.Trim();
            }
            else if (sender == textBoxBagUseRate)
            {
                currentFile.BagUseRate = textBoxBagUseRate.Text.Trim();
            }
        }

        private void SummonField_TextChanged(object sender, EventArgs e)
        {
            if (suppressSummonFieldEvents)
            {
                return;
            }

            if (sender == textBoxSummonEnable)
            {
                currentFile.SummonEnable = textBoxSummonEnable.Text.Trim();
            }
            else if (sender == textBoxSummonDropRate)
            {
                currentFile.SummonDropRate = textBoxSummonDropRate.Text.Trim();
            }
            else if (sender == textBoxSummonItemCat)
            {
                currentFile.SummonItemCat = textBoxSummonItemCat.Text.Trim();
            }
            else if (sender == textBoxSummonItemIndex)
            {
                currentFile.SummonItemIndex = textBoxSummonItemIndex.Text.Trim();
            }
        }

        private void AddCoinField_TextChanged(object sender, EventArgs e)
        {
            if (suppressAddCoinFieldEvents)
            {
                return;
            }

            if (sender == textBoxCoinEnable)
            {
                currentFile.AddCoinEnable = textBoxCoinEnable.Text.Trim();
            }
            else if (sender == textBoxCoinType)
            {
                currentFile.AddCoinType = textBoxCoinType.Text.Trim();
            }
            else if (sender == textBoxCoinValue)
            {
                currentFile.AddCoinValue = textBoxCoinValue.Text.Trim();
            }
        }

        private void DropAllowField_TextChanged(object sender, EventArgs e)
        {
            if (suppressDropAllowFieldEvents)
            {
                return;
            }

            if (!(dropAllowBindingSource.Current is Structures.IGCEventBagXmlDropAllow dropAllow))
            {
                return;
            }

            TextBox textBox = sender as TextBox;
            string value = textBox?.Text.Trim() ?? string.Empty;
            if (textBox == textBoxDropAllowWizard)
            {
                dropAllow.Wizard = value;
            }
            else if (textBox == textBoxDropAllowKnight)
            {
                dropAllow.Knight = value;
            }
            else if (textBox == textBoxDropAllowFairyElf)
            {
                dropAllow.FairyElf = value;
            }
            else if (textBox == textBoxDropAllowMagicGladiator)
            {
                dropAllow.MagicGladiator = value;
            }
            else if (textBox == textBoxDropAllowDarkLord)
            {
                dropAllow.DarkLord = value;
            }
            else if (textBox == textBoxDropAllowSummoner)
            {
                dropAllow.Summoner = value;
            }
            else if (textBox == textBoxDropAllowRageFighter)
            {
                dropAllow.RageFighter = value;
            }
            else if (textBox == textBoxDropAllowPlayerMinLevel)
            {
                dropAllow.PlayerMinLevel = value;
            }
            else if (textBox == textBoxDropAllowPlayerMaxLevel)
            {
                dropAllow.PlayerMaxLevel = value;
            }
            else if (textBox == textBoxDropAllowMapNumber)
            {
                dropAllow.MapNumber = value;
            }

            dropAllowBindingSource.ResetCurrentItem();
        }

        private void DropField_TextChanged(object sender, EventArgs e)
        {
            if (suppressDropFieldEvents)
            {
                return;
            }

            if (!(dropBindingSource.Current is Structures.IGCEventBagXmlDrop drop))
            {
                return;
            }

            TextBox textBox = sender as TextBox;
            string value = textBox?.Text.Trim() ?? string.Empty;
            if (textBox == textBoxDropRate)
            {
                drop.Rate = value;
            }
            else if (textBox == textBoxDropCount)
            {
                drop.Count = value;
            }

            dropBindingSource.ResetCurrentItem();
        }

        private void ItemField_TextChanged(object sender, EventArgs e)
        {
            if (suppressItemFieldEvents)
            {
                return;
            }

            if (!(itemBindingSource.Current is Structures.IGCEventBagXmlItem item))
            {
                return;
            }

            TextBox textBox = sender as TextBox;
            string value = textBox?.Text.Trim() ?? string.Empty;
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
            else if (textBox == textBoxItemKindA)
            {
                item.KindA = value;
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
        }

        private void listBoxDropAllows_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suppressDropAllowSelectionChange)
            {
                return;
            }

            if (listBoxDropAllows.SelectedIndex >= 0 && listBoxDropAllows.SelectedIndex < dropAllowBindingSource.Count)
            {
                dropAllowBindingSource.Position = listBoxDropAllows.SelectedIndex;
            }
        }

        private void listBoxDrops_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suppressDropSelectionChange)
            {
                return;
            }

            if (listBoxDrops.SelectedIndex >= 0 && listBoxDrops.SelectedIndex < dropBindingSource.Count)
            {
                dropBindingSource.Position = listBoxDrops.SelectedIndex;
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

        private void buttonAddDropAllow_Click(object sender, EventArgs e)
        {
            Structures.IGCEventBagXmlDropAllow dropAllow = new Structures.IGCEventBagXmlDropAllow();
            currentFile.DropAllows.Add(dropAllow);
            dropAllowBindingSource.Position = dropAllowBindingSource.Count - 1;
        }

        private void buttonRemoveDropAllow_Click(object sender, EventArgs e)
        {
            if (dropAllowBindingSource.Current is Structures.IGCEventBagXmlDropAllow dropAllow)
            {
                currentFile.DropAllows.Remove(dropAllow);
            }
        }

        private void buttonMoveDropAllowUp_Click(object sender, EventArgs e)
        {
            MoveDropAllow(-1);
        }

        private void buttonMoveDropAllowDown_Click(object sender, EventArgs e)
        {
            MoveDropAllow(1);
        }

        private void MoveDropAllow(int offset)
        {
            if (!(dropAllowBindingSource.Current is Structures.IGCEventBagXmlDropAllow dropAllow))
            {
                return;
            }

            int index = dropAllowBindingSource.Position;
            int newIndex = index + offset;
            if (newIndex < 0 || newIndex >= dropAllowBindingSource.Count)
            {
                return;
            }

            currentFile.DropAllows.RemoveAt(index);
            currentFile.DropAllows.Insert(newIndex, dropAllow);
            dropAllowBindingSource.Position = newIndex;
        }

        private void buttonAddDrop_Click(object sender, EventArgs e)
        {
            if (dropAllowBindingSource.Current is Structures.IGCEventBagXmlDropAllow dropAllow)
            {
                Structures.IGCEventBagXmlDrop drop = new Structures.IGCEventBagXmlDrop();
                dropAllow.Drops.Add(drop);
                dropBindingSource.Position = dropBindingSource.Count - 1;
            }
        }

        private void buttonRemoveDrop_Click(object sender, EventArgs e)
        {
            if (dropAllowBindingSource.Current is Structures.IGCEventBagXmlDropAllow dropAllow && dropBindingSource.Current is Structures.IGCEventBagXmlDrop drop)
            {
                dropAllow.Drops.Remove(drop);
                dropAllowBindingSource.ResetCurrentItem();
            }
        }

        private void buttonMoveDropUp_Click(object sender, EventArgs e)
        {
            MoveDrop(-1);
        }

        private void buttonMoveDropDown_Click(object sender, EventArgs e)
        {
            MoveDrop(1);
        }

        private void MoveDrop(int offset)
        {
            if (!(dropAllowBindingSource.Current is Structures.IGCEventBagXmlDropAllow dropAllow) || !(dropBindingSource.Current is Structures.IGCEventBagXmlDrop drop))
            {
                return;
            }

            int index = dropBindingSource.Position;
            int newIndex = index + offset;
            if (newIndex < 0 || newIndex >= dropAllow.Drops.Count)
            {
                return;
            }

            dropAllow.Drops.RemoveAt(index);
            dropAllow.Drops.Insert(newIndex, drop);
            dropBindingSource.Position = newIndex;
            dropAllowBindingSource.ResetCurrentItem();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (dropBindingSource.Current is Structures.IGCEventBagXmlDrop drop)
            {
                Structures.IGCEventBagXmlItem item = new Structures.IGCEventBagXmlItem();
                drop.Items.Add(item);
                itemBindingSource.Position = itemBindingSource.Count - 1;
                dropBindingSource.ResetCurrentItem();
            }
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            if (dropBindingSource.Current is Structures.IGCEventBagXmlDrop drop && itemBindingSource.Current is Structures.IGCEventBagXmlItem item)
            {
                drop.Items.Remove(item);
                dropBindingSource.ResetCurrentItem();
            }
        }

        private void buttonMoveItemUp_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void buttonMoveItemDown_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }

        private void MoveItem(int offset)
        {
            if (!(dropBindingSource.Current is Structures.IGCEventBagXmlDrop drop) || !(itemBindingSource.Current is Structures.IGCEventBagXmlItem item))
            {
                return;
            }

            int index = itemBindingSource.Position;
            int newIndex = index + offset;
            if (newIndex < 0 || newIndex >= drop.Items.Count)
            {
                return;
            }

            drop.Items.RemoveAt(index);
            drop.Items.Insert(newIndex, item);
            itemBindingSource.Position = newIndex;
            dropBindingSource.ResetCurrentItem();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentFilePath = null;
            BindFile(new Structures.IGCEventBagXmlFile());
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select the ItemBag (xml) file to load",
                Filter = "XML files (*.xml)|*.xml"
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Structures.IGCEventBagXmlFile file = Structures.LoadIGCEventBagXml(openFileDialog.FileName);
                        currentFilePath = openFileDialog.FileName;
                        BindFile(file);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading file: " + ex.Message, "EventBag XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Select a location to save the EventBag",
                Filter = "XML files (*.xml)|*.xml"
            })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Structures.SaveIGCEventBagXml(currentFile, saveFileDialog.FileName);
                        currentFilePath = saveFileDialog.FileName;
                        UpdateFileLabel();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving file: " + ex.Message, "EventBag XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
