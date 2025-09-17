using System.Windows.Forms;

namespace MU_ToolKit
{
    partial class EventBagEditor_XML
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new MenuStrip();
            this.fileToolStripMenuItem = new ToolStripMenuItem();
            this.newToolStripMenuItem = new ToolStripMenuItem();
            this.openToolStripMenuItem = new ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new ToolStripMenuItem();
            this.labelCurrentFile = new Label();
            this.splitContainerMain = new SplitContainer();
            this.tableLayoutPanelTop = new TableLayoutPanel();
            this.groupBoxBagConfig = new GroupBox();
            this.tableLayoutPanelBagConfig = new TableLayoutPanel();
            this.labelBagName = new Label();
            this.textBoxBagName = new TextBox();
            this.labelBagItemRate = new Label();
            this.textBoxBagItemRate = new TextBox();
            this.labelBagSetItemRate = new Label();
            this.textBoxBagSetItemRate = new TextBox();
            this.labelBagMoneyDrop = new Label();
            this.textBoxBagMoneyDrop = new TextBox();
            this.labelBagUseEffect = new Label();
            this.textBoxBagUseEffect = new TextBox();
            this.labelBagUseRate = new Label();
            this.textBoxBagUseRate = new TextBox();
            this.tableLayoutPanelSecondaryConfig = new TableLayoutPanel();
            this.groupBoxSummonBook = new GroupBox();
            this.tableLayoutPanelSummonBook = new TableLayoutPanel();
            this.labelSummonEnable = new Label();
            this.textBoxSummonEnable = new TextBox();
            this.labelSummonDropRate = new Label();
            this.textBoxSummonDropRate = new TextBox();
            this.labelSummonItemCat = new Label();
            this.textBoxSummonItemCat = new TextBox();
            this.labelSummonItemIndex = new Label();
            this.textBoxSummonItemIndex = new TextBox();
            this.groupBoxAddCoin = new GroupBox();
            this.tableLayoutPanelAddCoin = new TableLayoutPanel();
            this.labelCoinEnable = new Label();
            this.textBoxCoinEnable = new TextBox();
            this.labelCoinType = new Label();
            this.textBoxCoinType = new TextBox();
            this.labelCoinValue = new Label();
            this.textBoxCoinValue = new TextBox();
            this.splitContainerBottom = new SplitContainer();
            this.tableLayoutPanelDropAllow = new TableLayoutPanel();
            this.groupBoxDropAllowList = new GroupBox();
            this.tableLayoutPanelDropAllowList = new TableLayoutPanel();
            this.listBoxDropAllows = new ListBox();
            this.flowLayoutPanelDropAllowButtons = new FlowLayoutPanel();
            this.buttonAddDropAllow = new Button();
            this.buttonRemoveDropAllow = new Button();
            this.buttonMoveDropAllowUp = new Button();
            this.buttonMoveDropAllowDown = new Button();
            this.groupBoxDropAllowDetails = new GroupBox();
            this.tableLayoutPanelDropAllowDetails = new TableLayoutPanel();
            this.labelDropAllowWizard = new Label();
            this.textBoxDropAllowWizard = new TextBox();
            this.labelDropAllowKnight = new Label();
            this.textBoxDropAllowKnight = new TextBox();
            this.labelDropAllowFairyElf = new Label();
            this.textBoxDropAllowFairyElf = new TextBox();
            this.labelDropAllowMagicGladiator = new Label();
            this.textBoxDropAllowMagicGladiator = new TextBox();
            this.labelDropAllowDarkLord = new Label();
            this.textBoxDropAllowDarkLord = new TextBox();
            this.labelDropAllowSummoner = new Label();
            this.textBoxDropAllowSummoner = new TextBox();
            this.labelDropAllowRageFighter = new Label();
            this.textBoxDropAllowRageFighter = new TextBox();
            this.labelDropAllowPlayerMinLevel = new Label();
            this.textBoxDropAllowPlayerMinLevel = new TextBox();
            this.labelDropAllowPlayerMaxLevel = new Label();
            this.textBoxDropAllowPlayerMaxLevel = new TextBox();
            this.labelDropAllowMapNumber = new Label();
            this.textBoxDropAllowMapNumber = new TextBox();
            this.splitContainerDropsItems = new SplitContainer();
            this.tableLayoutPanelDrops = new TableLayoutPanel();
            this.groupBoxDropList = new GroupBox();
            this.tableLayoutPanelDropList = new TableLayoutPanel();
            this.listBoxDrops = new ListBox();
            this.flowLayoutPanelDropButtons = new FlowLayoutPanel();
            this.buttonAddDrop = new Button();
            this.buttonRemoveDrop = new Button();
            this.buttonMoveDropUp = new Button();
            this.buttonMoveDropDown = new Button();
            this.groupBoxDropDetails = new GroupBox();
            this.tableLayoutPanelDropDetails = new TableLayoutPanel();
            this.labelDropRate = new Label();
            this.textBoxDropRate = new TextBox();
            this.labelDropCount = new Label();
            this.textBoxDropCount = new TextBox();
            this.tableLayoutPanelItems = new TableLayoutPanel();
            this.groupBoxItemList = new GroupBox();
            this.tableLayoutPanelItemList = new TableLayoutPanel();
            this.listBoxItems = new ListBox();
            this.flowLayoutPanelItemButtons = new FlowLayoutPanel();
            this.buttonAddItem = new Button();
            this.buttonRemoveItem = new Button();
            this.buttonMoveItemUp = new Button();
            this.buttonMoveItemDown = new Button();
            this.groupBoxItemDetails = new GroupBox();
            this.tableLayoutPanelItemDetails = new TableLayoutPanel();
            this.labelItemCat = new Label();
            this.textBoxItemCat = new TextBox();
            this.labelItemIndex = new Label();
            this.textBoxItemIndex = new TextBox();
            this.labelItemMinLevel = new Label();
            this.textBoxItemMinLevel = new TextBox();
            this.labelItemMaxLevel = new Label();
            this.textBoxItemMaxLevel = new TextBox();
            this.labelItemDurability = new Label();
            this.textBoxItemDurability = new TextBox();
            this.labelItemSkill = new Label();
            this.textBoxItemSkill = new TextBox();
            this.labelItemLuck = new Label();
            this.textBoxItemLuck = new TextBox();
            this.labelItemOption = new Label();
            this.textBoxItemOption = new TextBox();
            this.labelItemExc = new Label();
            this.textBoxItemExc = new TextBox();
            this.labelItemSetItem = new Label();
            this.textBoxItemSetItem = new TextBox();
            this.labelItemSocketCount = new Label();
            this.textBoxItemSocketCount = new TextBox();
            this.labelItemElementalItem = new Label();
            this.textBoxItemElementalItem = new TextBox();
            this.labelItemMuunCat = new Label();
            this.textBoxItemMuunCat = new TextBox();
            this.labelItemMuunIndex = new Label();
            this.textBoxItemMuunIndex = new TextBox();
            this.labelItemKindA = new Label();
            this.textBoxItemKindA = new TextBox();
            this.labelItemDropRate = new Label();
            this.textBoxItemDropRate = new TextBox();
            this.labelItemDuration = new Label();
            this.textBoxItemDuration = new TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.groupBoxBagConfig.SuspendLayout();
            this.tableLayoutPanelBagConfig.SuspendLayout();
            this.tableLayoutPanelSecondaryConfig.SuspendLayout();
            this.groupBoxSummonBook.SuspendLayout();
            this.tableLayoutPanelSummonBook.SuspendLayout();
            this.groupBoxAddCoin.SuspendLayout();
            this.tableLayoutPanelAddCoin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).BeginInit();
            this.splitContainerBottom.Panel1.SuspendLayout();
            this.splitContainerBottom.Panel2.SuspendLayout();
            this.splitContainerBottom.SuspendLayout();
            this.tableLayoutPanelDropAllow.SuspendLayout();
            this.groupBoxDropAllowList.SuspendLayout();
            this.tableLayoutPanelDropAllowList.SuspendLayout();
            this.flowLayoutPanelDropAllowButtons.SuspendLayout();
            this.groupBoxDropAllowDetails.SuspendLayout();
            this.tableLayoutPanelDropAllowDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDropsItems)).BeginInit();
            this.splitContainerDropsItems.Panel1.SuspendLayout();
            this.splitContainerDropsItems.Panel2.SuspendLayout();
            this.splitContainerDropsItems.SuspendLayout();
            this.tableLayoutPanelDrops.SuspendLayout();
            this.groupBoxDropList.SuspendLayout();
            this.tableLayoutPanelDropList.SuspendLayout();
            this.flowLayoutPanelDropButtons.SuspendLayout();
            this.groupBoxDropDetails.SuspendLayout();
            this.tableLayoutPanelDropDetails.SuspendLayout();
            this.tableLayoutPanelItems.SuspendLayout();
            this.groupBoxItemList.SuspendLayout();
            this.tableLayoutPanelItemList.SuspendLayout();
            this.flowLayoutPanelItemButtons.SuspendLayout();
            this.groupBoxItemDetails.SuspendLayout();
            this.tableLayoutPanelItemDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // labelCurrentFile
            // 
            this.labelCurrentFile.AutoSize = true;
            this.labelCurrentFile.Dock = DockStyle.Top;
            this.labelCurrentFile.Location = new System.Drawing.Point(0, 24);
            this.labelCurrentFile.Name = "labelCurrentFile";
            this.labelCurrentFile.Padding = new Padding(5);
            this.labelCurrentFile.Size = new System.Drawing.Size(61, 23);
            this.labelCurrentFile.TabIndex = 1;
            this.labelCurrentFile.Text = "New file";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 47);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = Orientation.Horizontal;
            this.splitContainerMain.Panel1.Controls.Add(this.tableLayoutPanelTop);
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerBottom);
            this.splitContainerMain.Size = new System.Drawing.Size(1184, 664);
            this.splitContainerMain.SplitterDistance = 200;
            this.splitContainerMain.TabIndex = 2;
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.ColumnCount = 1;
            this.tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Controls.Add(this.groupBoxBagConfig, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.tableLayoutPanelSecondaryConfig, 0, 1);
            this.tableLayoutPanelTop.Dock = DockStyle.Fill;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 2;
            this.tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            this.tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(1184, 200);
            this.tableLayoutPanelTop.TabIndex = 0;
            // 
            // groupBoxBagConfig
            // 
            this.groupBoxBagConfig.Controls.Add(this.tableLayoutPanelBagConfig);
            this.groupBoxBagConfig.Dock = DockStyle.Fill;
            this.groupBoxBagConfig.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBagConfig.Name = "groupBoxBagConfig";
            this.groupBoxBagConfig.Size = new System.Drawing.Size(1178, 114);
            this.groupBoxBagConfig.TabIndex = 0;
            this.groupBoxBagConfig.TabStop = false;
            this.groupBoxBagConfig.Text = "Bag Config";
            // 
            // tableLayoutPanelBagConfig
            // 
            this.tableLayoutPanelBagConfig.ColumnCount = 6;
            this.tableLayoutPanelBagConfig.ColumnStyles.Add(new ColumnStyle());
            this.tableLayoutPanelBagConfig.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBagConfig.ColumnStyles.Add(new ColumnStyle());
            this.tableLayoutPanelBagConfig.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBagConfig.ColumnStyles.Add(new ColumnStyle());
            this.tableLayoutPanelBagConfig.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBagConfig.Controls.Add(this.labelBagName, 0, 0);
            this.tableLayoutPanelBagConfig.Controls.Add(this.textBoxBagName, 1, 0);
            this.tableLayoutPanelBagConfig.Controls.Add(this.labelBagItemRate, 2, 0);
            this.tableLayoutPanelBagConfig.Controls.Add(this.textBoxBagItemRate, 3, 0);
            this.tableLayoutPanelBagConfig.Controls.Add(this.labelBagSetItemRate, 4, 0);
            this.tableLayoutPanelBagConfig.Controls.Add(this.textBoxBagSetItemRate, 5, 0);
            this.tableLayoutPanelBagConfig.Controls.Add(this.labelBagMoneyDrop, 0, 1);
            this.tableLayoutPanelBagConfig.Controls.Add(this.textBoxBagMoneyDrop, 1, 1);
            this.tableLayoutPanelBagConfig.Controls.Add(this.labelBagUseEffect, 2, 1);
            this.tableLayoutPanelBagConfig.Controls.Add(this.textBoxBagUseEffect, 3, 1);
            this.tableLayoutPanelBagConfig.Controls.Add(this.labelBagUseRate, 4, 1);
            this.tableLayoutPanelBagConfig.Controls.Add(this.textBoxBagUseRate, 5, 1);
            this.tableLayoutPanelBagConfig.Dock = DockStyle.Fill;
            this.tableLayoutPanelBagConfig.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanelBagConfig.Name = "tableLayoutPanelBagConfig";
            this.tableLayoutPanelBagConfig.RowCount = 2;
            this.tableLayoutPanelBagConfig.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelBagConfig.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelBagConfig.Size = new System.Drawing.Size(1172, 94);
            this.tableLayoutPanelBagConfig.TabIndex = 0;
            // 
            // labelBagName
            // 
            this.labelBagName.Anchor = AnchorStyles.Left;
            this.labelBagName.AutoSize = true;
            this.labelBagName.Location = new System.Drawing.Point(3, 15);
            this.labelBagName.Name = "labelBagName";
            this.labelBagName.Size = new System.Drawing.Size(38, 13);
            this.labelBagName.TabIndex = 0;
            this.labelBagName.Text = "Name:";
            // 
            // textBoxBagName
            // 
            this.textBoxBagName.Dock = DockStyle.Fill;
            this.textBoxBagName.Location = new System.Drawing.Point(47, 3);
            this.textBoxBagName.Name = "textBoxBagName";
            this.textBoxBagName.Size = new System.Drawing.Size(358, 20);
            this.textBoxBagName.TabIndex = 1;
            this.textBoxBagName.TextChanged += new System.EventHandler(this.ConfigField_TextChanged);
            // 
            // labelBagItemRate
            // 
            this.labelBagItemRate.Anchor = AnchorStyles.Left;
            this.labelBagItemRate.AutoSize = true;
            this.labelBagItemRate.Location = new System.Drawing.Point(411, 15);
            this.labelBagItemRate.Name = "labelBagItemRate";
            this.labelBagItemRate.Size = new System.Drawing.Size(57, 13);
            this.labelBagItemRate.TabIndex = 2;
            this.labelBagItemRate.Text = "Item Rate:";
            // 
            // textBoxBagItemRate
            // 
            this.textBoxBagItemRate.Dock = DockStyle.Fill;
            this.textBoxBagItemRate.Location = new System.Drawing.Point(474, 3);
            this.textBoxBagItemRate.Name = "textBoxBagItemRate";
            this.textBoxBagItemRate.Size = new System.Drawing.Size(358, 20);
            this.textBoxBagItemRate.TabIndex = 3;
            this.textBoxBagItemRate.TextChanged += new System.EventHandler(this.ConfigField_TextChanged);
            // 
            // labelBagSetItemRate
            // 
            this.labelBagSetItemRate.Anchor = AnchorStyles.Left;
            this.labelBagSetItemRate.AutoSize = true;
            this.labelBagSetItemRate.Location = new System.Drawing.Point(838, 15);
            this.labelBagSetItemRate.Name = "labelBagSetItemRate";
            this.labelBagSetItemRate.Size = new System.Drawing.Size(75, 13);
            this.labelBagSetItemRate.TabIndex = 4;
            this.labelBagSetItemRate.Text = "Set Item Rate:";
            // 
            // textBoxBagSetItemRate
            // 
            this.textBoxBagSetItemRate.Dock = DockStyle.Fill;
            this.textBoxBagSetItemRate.Location = new System.Drawing.Point(919, 3);
            this.textBoxBagSetItemRate.Name = "textBoxBagSetItemRate";
            this.textBoxBagSetItemRate.Size = new System.Drawing.Size(250, 20);
            this.textBoxBagSetItemRate.TabIndex = 5;
            this.textBoxBagSetItemRate.TextChanged += new System.EventHandler(this.ConfigField_TextChanged);
            // 
            // labelBagMoneyDrop
            // 
            this.labelBagMoneyDrop.Anchor = AnchorStyles.Left;
            this.labelBagMoneyDrop.AutoSize = true;
            this.labelBagMoneyDrop.Location = new System.Drawing.Point(3, 63);
            this.labelBagMoneyDrop.Name = "labelBagMoneyDrop";
            this.labelBagMoneyDrop.Size = new System.Drawing.Size(68, 13);
            this.labelBagMoneyDrop.TabIndex = 6;
            this.labelBagMoneyDrop.Text = "Money Drop:";
            // 
            // textBoxBagMoneyDrop
            // 
            this.textBoxBagMoneyDrop.Dock = DockStyle.Fill;
            this.textBoxBagMoneyDrop.Location = new System.Drawing.Point(47, 50);
            this.textBoxBagMoneyDrop.Name = "textBoxBagMoneyDrop";
            this.textBoxBagMoneyDrop.Size = new System.Drawing.Size(358, 20);
            this.textBoxBagMoneyDrop.TabIndex = 7;
            this.textBoxBagMoneyDrop.TextChanged += new System.EventHandler(this.ConfigField_TextChanged);
            // 
            // labelBagUseEffect
            // 
            this.labelBagUseEffect.Anchor = AnchorStyles.Left;
            this.labelBagUseEffect.AutoSize = true;
            this.labelBagUseEffect.Location = new System.Drawing.Point(411, 63);
            this.labelBagUseEffect.Name = "labelBagUseEffect";
            this.labelBagUseEffect.Size = new System.Drawing.Size(66, 13);
            this.labelBagUseEffect.TabIndex = 8;
            this.labelBagUseEffect.Text = "Bag Effect:";
            // 
            // textBoxBagUseEffect
            // 
            this.textBoxBagUseEffect.Dock = DockStyle.Fill;
            this.textBoxBagUseEffect.Location = new System.Drawing.Point(474, 50);
            this.textBoxBagUseEffect.Name = "textBoxBagUseEffect";
            this.textBoxBagUseEffect.Size = new System.Drawing.Size(358, 20);
            this.textBoxBagUseEffect.TabIndex = 9;
            this.textBoxBagUseEffect.TextChanged += new System.EventHandler(this.ConfigField_TextChanged);
            // 
            // labelBagUseRate
            // 
            this.labelBagUseRate.Anchor = AnchorStyles.Left;
            this.labelBagUseRate.AutoSize = true;
            this.labelBagUseRate.Location = new System.Drawing.Point(838, 63);
            this.labelBagUseRate.Name = "labelBagUseRate";
            this.labelBagUseRate.Size = new System.Drawing.Size(61, 13);
            this.labelBagUseRate.TabIndex = 10;
            this.labelBagUseRate.Text = "Bag Use %:";
            // 
            // textBoxBagUseRate
            // 
            this.textBoxBagUseRate.Dock = DockStyle.Fill;
            this.textBoxBagUseRate.Location = new System.Drawing.Point(919, 50);
            this.textBoxBagUseRate.Name = "textBoxBagUseRate";
            this.textBoxBagUseRate.Size = new System.Drawing.Size(250, 20);
            this.textBoxBagUseRate.TabIndex = 11;
            this.textBoxBagUseRate.TextChanged += new System.EventHandler(this.ConfigField_TextChanged);
            // 
            // tableLayoutPanelSecondaryConfig
            // 
            this.tableLayoutPanelSecondaryConfig.ColumnCount = 2;
            this.tableLayoutPanelSecondaryConfig.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelSecondaryConfig.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelSecondaryConfig.Controls.Add(this.groupBoxSummonBook, 0, 0);
            this.tableLayoutPanelSecondaryConfig.Controls.Add(this.groupBoxAddCoin, 1, 0);
            this.tableLayoutPanelSecondaryConfig.Dock = DockStyle.Fill;
            this.tableLayoutPanelSecondaryConfig.Location = new System.Drawing.Point(3, 123);
            this.tableLayoutPanelSecondaryConfig.Name = "tableLayoutPanelSecondaryConfig";
            this.tableLayoutPanelSecondaryConfig.RowCount = 1;
            this.tableLayoutPanelSecondaryConfig.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanelSecondaryConfig.Size = new System.Drawing.Size(1178, 74);
            this.tableLayoutPanelSecondaryConfig.TabIndex = 1;
            // 
            // groupBoxSummonBook
            // 
            this.groupBoxSummonBook.Controls.Add(this.tableLayoutPanelSummonBook);
            this.groupBoxSummonBook.Dock = DockStyle.Fill;
            this.groupBoxSummonBook.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSummonBook.Name = "groupBoxSummonBook";
            this.groupBoxSummonBook.Size = new System.Drawing.Size(583, 68);
            this.groupBoxSummonBook.TabIndex = 0;
            this.groupBoxSummonBook.TabStop = false;
            this.groupBoxSummonBook.Text = "Summon Book";
            // 
            // tableLayoutPanelSummonBook
            // 
            this.tableLayoutPanelSummonBook.ColumnCount = 4;
            this.tableLayoutPanelSummonBook.ColumnStyles.Add(new ColumnStyle());
            this.tableLayoutPanelSummonBook.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelSummonBook.ColumnStyles.Add(new ColumnStyle());
            this.tableLayoutPanelSummonBook.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelSummonBook.Controls.Add(this.labelSummonEnable, 0, 0);
            this.tableLayoutPanelSummonBook.Controls.Add(this.textBoxSummonEnable, 1, 0);
            this.tableLayoutPanelSummonBook.Controls.Add(this.labelSummonDropRate, 2, 0);
            this.tableLayoutPanelSummonBook.Controls.Add(this.textBoxSummonDropRate, 3, 0);
            this.tableLayoutPanelSummonBook.Controls.Add(this.labelSummonItemCat, 0, 1);
            this.tableLayoutPanelSummonBook.Controls.Add(this.textBoxSummonItemCat, 1, 1);
            this.tableLayoutPanelSummonBook.Controls.Add(this.labelSummonItemIndex, 2, 1);
            this.tableLayoutPanelSummonBook.Controls.Add(this.textBoxSummonItemIndex, 3, 1);
            this.tableLayoutPanelSummonBook.Dock = DockStyle.Fill;
            this.tableLayoutPanelSummonBook.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanelSummonBook.Name = "tableLayoutPanelSummonBook";
            this.tableLayoutPanelSummonBook.RowCount = 2;
            this.tableLayoutPanelSummonBook.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelSummonBook.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelSummonBook.Size = new System.Drawing.Size(577, 48);
            this.tableLayoutPanelSummonBook.TabIndex = 0;
            // 
            // labelSummonEnable
            // 
            this.labelSummonEnable.Anchor = AnchorStyles.Left;
            this.labelSummonEnable.AutoSize = true;
            this.labelSummonEnable.Location = new System.Drawing.Point(3, 6);
            this.labelSummonEnable.Name = "labelSummonEnable";
            this.labelSummonEnable.Size = new System.Drawing.Size(46, 13);
            this.labelSummonEnable.TabIndex = 0;
            this.labelSummonEnable.Text = "Enable:";
            // 
            // textBoxSummonEnable
            // 
            this.textBoxSummonEnable.Dock = DockStyle.Fill;
            this.textBoxSummonEnable.Location = new System.Drawing.Point(55, 3);
            this.textBoxSummonEnable.Name = "textBoxSummonEnable";
            this.textBoxSummonEnable.Size = new System.Drawing.Size(227, 20);
            this.textBoxSummonEnable.TabIndex = 1;
            this.textBoxSummonEnable.TextChanged += new System.EventHandler(this.SummonField_TextChanged);
            // 
            // labelSummonDropRate
            // 
            this.labelSummonDropRate.Anchor = AnchorStyles.Left;
            this.labelSummonDropRate.AutoSize = true;
            this.labelSummonDropRate.Location = new System.Drawing.Point(288, 6);
            this.labelSummonDropRate.Name = "labelSummonDropRate";
            this.labelSummonDropRate.Size = new System.Drawing.Size(58, 13);
            this.labelSummonDropRate.TabIndex = 2;
            this.labelSummonDropRate.Text = "Drop Rate:";
            // 
            // textBoxSummonDropRate
            // 
            this.textBoxSummonDropRate.Dock = DockStyle.Fill;
            this.textBoxSummonDropRate.Location = new System.Drawing.Point(352, 3);
            this.textBoxSummonDropRate.Name = "textBoxSummonDropRate";
            this.textBoxSummonDropRate.Size = new System.Drawing.Size(222, 20);
            this.textBoxSummonDropRate.TabIndex = 3;
            this.textBoxSummonDropRate.TextChanged += new System.EventHandler(this.SummonField_TextChanged);
            // 
            // labelSummonItemCat
            // 
            this.labelSummonItemCat.Anchor = AnchorStyles.Left;
            this.labelSummonItemCat.AutoSize = true;
            this.labelSummonItemCat.Location = new System.Drawing.Point(3, 30);
            this.labelSummonItemCat.Name = "labelSummonItemCat";
            this.labelSummonItemCat.Size = new System.Drawing.Size(49, 13);
            this.labelSummonItemCat.TabIndex = 4;
            this.labelSummonItemCat.Text = "Item Cat:";
            // 
            // textBoxSummonItemCat
            // 
            this.textBoxSummonItemCat.Dock = DockStyle.Fill;
            this.textBoxSummonItemCat.Location = new System.Drawing.Point(55, 27);
            this.textBoxSummonItemCat.Name = "textBoxSummonItemCat";
            this.textBoxSummonItemCat.Size = new System.Drawing.Size(227, 20);
            this.textBoxSummonItemCat.TabIndex = 5;
            this.textBoxSummonItemCat.TextChanged += new System.EventHandler(this.SummonField_TextChanged);
            // 
            // labelSummonItemIndex
            // 
            this.labelSummonItemIndex.Anchor = AnchorStyles.Left;
            this.labelSummonItemIndex.AutoSize = true;
            this.labelSummonItemIndex.Location = new System.Drawing.Point(288, 30);
            this.labelSummonItemIndex.Name = "labelSummonItemIndex";
            this.labelSummonItemIndex.Size = new System.Drawing.Size(61, 13);
            this.labelSummonItemIndex.TabIndex = 6;
            this.labelSummonItemIndex.Text = "Item Index:";
            // 
            // textBoxSummonItemIndex
            // 
            this.textBoxSummonItemIndex.Dock = DockStyle.Fill;
            this.textBoxSummonItemIndex.Location = new System.Drawing.Point(352, 27);
            this.textBoxSummonItemIndex.Name = "textBoxSummonItemIndex";
            this.textBoxSummonItemIndex.Size = new System.Drawing.Size(222, 20);
            this.textBoxSummonItemIndex.TabIndex = 7;
            this.textBoxSummonItemIndex.TextChanged += new System.EventHandler(this.SummonField_TextChanged);
            // 
            // groupBoxAddCoin
            // 
            this.groupBoxAddCoin.Controls.Add(this.tableLayoutPanelAddCoin);
            this.groupBoxAddCoin.Dock = DockStyle.Fill;
            this.groupBoxAddCoin.Location = new System.Drawing.Point(592, 3);
            this.groupBoxAddCoin.Name = "groupBoxAddCoin";
            this.groupBoxAddCoin.Size = new System.Drawing.Size(583, 68);
            this.groupBoxAddCoin.TabIndex = 1;
            this.groupBoxAddCoin.TabStop = false;
            this.groupBoxAddCoin.Text = "Add Coin";
            // 
            // tableLayoutPanelAddCoin
            // 
            this.tableLayoutPanelAddCoin.ColumnCount = 6;
            this.tableLayoutPanelAddCoin.ColumnStyles.Add(new ColumnStyle());
            this.tableLayoutPanelAddCoin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            this.tableLayoutPanelAddCoin.ColumnStyles.Add(new ColumnStyle());
            this.tableLayoutPanelAddCoin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            this.tableLayoutPanelAddCoin.ColumnStyles.Add(new ColumnStyle());
            this.tableLayoutPanelAddCoin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            this.tableLayoutPanelAddCoin.Controls.Add(this.labelCoinEnable, 0, 0);
            this.tableLayoutPanelAddCoin.Controls.Add(this.textBoxCoinEnable, 1, 0);
            this.tableLayoutPanelAddCoin.Controls.Add(this.labelCoinType, 2, 0);
            this.tableLayoutPanelAddCoin.Controls.Add(this.textBoxCoinType, 3, 0);
            this.tableLayoutPanelAddCoin.Controls.Add(this.labelCoinValue, 4, 0);
            this.tableLayoutPanelAddCoin.Controls.Add(this.textBoxCoinValue, 5, 0);
            this.tableLayoutPanelAddCoin.Dock = DockStyle.Fill;
            this.tableLayoutPanelAddCoin.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanelAddCoin.Name = "tableLayoutPanelAddCoin";
            this.tableLayoutPanelAddCoin.RowCount = 1;
            this.tableLayoutPanelAddCoin.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanelAddCoin.Size = new System.Drawing.Size(577, 48);
            this.tableLayoutPanelAddCoin.TabIndex = 0;
            // 
            // labelCoinEnable
            // 
            this.labelCoinEnable.Anchor = AnchorStyles.Left;
            this.labelCoinEnable.AutoSize = true;
            this.labelCoinEnable.Location = new System.Drawing.Point(3, 17);
            this.labelCoinEnable.Name = "labelCoinEnable";
            this.labelCoinEnable.Size = new System.Drawing.Size(46, 13);
            this.labelCoinEnable.TabIndex = 0;
            this.labelCoinEnable.Text = "Enable:";
            // 
            // textBoxCoinEnable
            // 
            this.textBoxCoinEnable.Dock = DockStyle.Fill;
            this.textBoxCoinEnable.Location = new System.Drawing.Point(55, 3);
            this.textBoxCoinEnable.Name = "textBoxCoinEnable";
            this.textBoxCoinEnable.Size = new System.Drawing.Size(142, 20);
            this.textBoxCoinEnable.TabIndex = 1;
            this.textBoxCoinEnable.TextChanged += new System.EventHandler(this.AddCoinField_TextChanged);
            // 
            // labelCoinType
            // 
            this.labelCoinType.Anchor = AnchorStyles.Left;
            this.labelCoinType.AutoSize = true;
            this.labelCoinType.Location = new System.Drawing.Point(203, 17);
            this.labelCoinType.Name = "labelCoinType";
            this.labelCoinType.Size = new System.Drawing.Size(34, 13);
            this.labelCoinType.TabIndex = 2;
            this.labelCoinType.Text = "Type:";
            // 
            // textBoxCoinType
            // 
            this.textBoxCoinType.Dock = DockStyle.Fill;
            this.textBoxCoinType.Location = new System.Drawing.Point(243, 3);
            this.textBoxCoinType.Name = "textBoxCoinType";
            this.textBoxCoinType.Size = new System.Drawing.Size(142, 20);
            this.textBoxCoinType.TabIndex = 3;
            this.textBoxCoinType.TextChanged += new System.EventHandler(this.AddCoinField_TextChanged);
            // 
            // labelCoinValue
            // 
            this.labelCoinValue.Anchor = AnchorStyles.Left;
            this.labelCoinValue.AutoSize = true;
            this.labelCoinValue.Location = new System.Drawing.Point(391, 17);
            this.labelCoinValue.Name = "labelCoinValue";
            this.labelCoinValue.Size = new System.Drawing.Size(37, 13);
            this.labelCoinValue.TabIndex = 4;
            this.labelCoinValue.Text = "Value:";
            // 
            // textBoxCoinValue
            // 
            this.textBoxCoinValue.Dock = DockStyle.Fill;
            this.textBoxCoinValue.Location = new System.Drawing.Point(434, 3);
            this.textBoxCoinValue.Name = "textBoxCoinValue";
            this.textBoxCoinValue.Size = new System.Drawing.Size(140, 20);
            this.textBoxCoinValue.TabIndex = 5;
            this.textBoxCoinValue.TextChanged += new System.EventHandler(this.AddCoinField_TextChanged);
            //
            // splitContainerBottom
            //
            this.splitContainerBottom.Dock = DockStyle.Fill;
            this.splitContainerBottom.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBottom.Name = "splitContainerBottom";
            this.splitContainerBottom.Panel1.Controls.Add(this.tableLayoutPanelDropAllow);
            this.splitContainerBottom.Panel2.Controls.Add(this.splitContainerDropsItems);
            this.splitContainerBottom.Size = new System.Drawing.Size(1184, 460);
            this.splitContainerBottom.SplitterDistance = 394;
            this.splitContainerBottom.TabIndex = 0;
            // 
            // tableLayoutPanelDropAllow
            // 
            this.tableLayoutPanelDropAllow.ColumnCount = 1;
            this.tableLayoutPanelDropAllow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanelDropAllow.Controls.Add(this.groupBoxDropAllowList, 0, 0);
            this.tableLayoutPanelDropAllow.Controls.Add(this.groupBoxDropAllowDetails, 0, 1);
            this.tableLayoutPanelDropAllow.Dock = DockStyle.Fill;
            this.tableLayoutPanelDropAllow.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDropAllow.Name = "tableLayoutPanelDropAllow";
            this.tableLayoutPanelDropAllow.RowCount = 2;
            this.tableLayoutPanelDropAllow.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            this.tableLayoutPanelDropAllow.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            this.tableLayoutPanelDropAllow.Size = new System.Drawing.Size(394, 460);
            this.tableLayoutPanelDropAllow.TabIndex = 0;
            // 
            // groupBoxDropAllowList
            // 
            this.groupBoxDropAllowList.Controls.Add(this.tableLayoutPanelDropAllowList);
            this.groupBoxDropAllowList.Dock = DockStyle.Fill;
            this.groupBoxDropAllowList.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDropAllowList.Name = "groupBoxDropAllowList";
            this.groupBoxDropAllowList.Size = new System.Drawing.Size(388, 201);
            this.groupBoxDropAllowList.TabIndex = 0;
            this.groupBoxDropAllowList.TabStop = false;
            this.groupBoxDropAllowList.Text = "DropAllow Sections";
            // 
            // tableLayoutPanelDropAllowList
            // 
            this.tableLayoutPanelDropAllowList.ColumnCount = 1;
            this.tableLayoutPanelDropAllowList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanelDropAllowList.Controls.Add(this.listBoxDropAllows, 0, 0);
            this.tableLayoutPanelDropAllowList.Controls.Add(this.flowLayoutPanelDropAllowButtons, 0, 1);
            this.tableLayoutPanelDropAllowList.Dock = DockStyle.Fill;
            this.tableLayoutPanelDropAllowList.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanelDropAllowList.Name = "tableLayoutPanelDropAllowList";
            this.tableLayoutPanelDropAllowList.RowCount = 2;
            this.tableLayoutPanelDropAllowList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanelDropAllowList.RowStyles.Add(new RowStyle());
            this.tableLayoutPanelDropAllowList.Size = new System.Drawing.Size(382, 181);
            this.tableLayoutPanelDropAllowList.TabIndex = 0;
            // 
            // listBoxDropAllows
            // 
            this.listBoxDropAllows.Dock = DockStyle.Fill;
            this.listBoxDropAllows.FormattingEnabled = true;
            this.listBoxDropAllows.IntegralHeight = false;
            this.listBoxDropAllows.Location = new System.Drawing.Point(3, 3);
            this.listBoxDropAllows.Name = "listBoxDropAllows";
            this.listBoxDropAllows.Size = new System.Drawing.Size(376, 146);
            this.listBoxDropAllows.TabIndex = 0;
            this.listBoxDropAllows.SelectedIndexChanged += new System.EventHandler(this.listBoxDropAllows_SelectedIndexChanged);
            // 
            // flowLayoutPanelDropAllowButtons
            // 
            this.flowLayoutPanelDropAllowButtons.AutoSize = true;
            this.flowLayoutPanelDropAllowButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelDropAllowButtons.Controls.Add(this.buttonAddDropAllow);
            this.flowLayoutPanelDropAllowButtons.Controls.Add(this.buttonRemoveDropAllow);
            this.flowLayoutPanelDropAllowButtons.Controls.Add(this.buttonMoveDropAllowUp);
            this.flowLayoutPanelDropAllowButtons.Controls.Add(this.buttonMoveDropAllowDown);
            this.flowLayoutPanelDropAllowButtons.Dock = DockStyle.Fill;
            this.flowLayoutPanelDropAllowButtons.Location = new System.Drawing.Point(3, 155);
            this.flowLayoutPanelDropAllowButtons.Name = "flowLayoutPanelDropAllowButtons";
            this.flowLayoutPanelDropAllowButtons.Size = new System.Drawing.Size(376, 23);
            this.flowLayoutPanelDropAllowButtons.TabIndex = 1;
            this.flowLayoutPanelDropAllowButtons.WrapContents = false;
            // 
            // buttonAddDropAllow
            // 
            this.buttonAddDropAllow.AutoSize = true;
            this.buttonAddDropAllow.Location = new System.Drawing.Point(3, 3);
            this.buttonAddDropAllow.Name = "buttonAddDropAllow";
            this.buttonAddDropAllow.Size = new System.Drawing.Size(35, 23);
            this.buttonAddDropAllow.TabIndex = 0;
            this.buttonAddDropAllow.Text = "Add";
            this.buttonAddDropAllow.UseVisualStyleBackColor = true;
            this.buttonAddDropAllow.Click += new System.EventHandler(this.buttonAddDropAllow_Click);
            // 
            // buttonRemoveDropAllow
            // 
            this.buttonRemoveDropAllow.AutoSize = true;
            this.buttonRemoveDropAllow.Location = new System.Drawing.Point(44, 3);
            this.buttonRemoveDropAllow.Name = "buttonRemoveDropAllow";
            this.buttonRemoveDropAllow.Size = new System.Drawing.Size(54, 23);
            this.buttonRemoveDropAllow.TabIndex = 1;
            this.buttonRemoveDropAllow.Text = "Remove";
            this.buttonRemoveDropAllow.UseVisualStyleBackColor = true;
            this.buttonRemoveDropAllow.Click += new System.EventHandler(this.buttonRemoveDropAllow_Click);
            // 
            // buttonMoveDropAllowUp
            // 
            this.buttonMoveDropAllowUp.AutoSize = true;
            this.buttonMoveDropAllowUp.Location = new System.Drawing.Point(104, 3);
            this.buttonMoveDropAllowUp.Name = "buttonMoveDropAllowUp";
            this.buttonMoveDropAllowUp.Size = new System.Drawing.Size(26, 23);
            this.buttonMoveDropAllowUp.TabIndex = 2;
            this.buttonMoveDropAllowUp.Text = "↑";
            this.buttonMoveDropAllowUp.UseVisualStyleBackColor = true;
            this.buttonMoveDropAllowUp.Click += new System.EventHandler(this.buttonMoveDropAllowUp_Click);
            // 
            // buttonMoveDropAllowDown
            // 
            this.buttonMoveDropAllowDown.AutoSize = true;
            this.buttonMoveDropAllowDown.Location = new System.Drawing.Point(136, 3);
            this.buttonMoveDropAllowDown.Name = "buttonMoveDropAllowDown";
            this.buttonMoveDropAllowDown.Size = new System.Drawing.Size(26, 23);
            this.buttonMoveDropAllowDown.TabIndex = 3;
            this.buttonMoveDropAllowDown.Text = "↓";
            this.buttonMoveDropAllowDown.UseVisualStyleBackColor = true;
            this.buttonMoveDropAllowDown.Click += new System.EventHandler(this.buttonMoveDropAllowDown_Click);
            // 
            // groupBoxDropAllowDetails
            // 
            this.groupBoxDropAllowDetails.Controls.Add(this.tableLayoutPanelDropAllowDetails);
            this.groupBoxDropAllowDetails.Dock = DockStyle.Fill;
            this.groupBoxDropAllowDetails.Location = new System.Drawing.Point(3, 210);
            this.groupBoxDropAllowDetails.Name = "groupBoxDropAllowDetails";
            this.groupBoxDropAllowDetails.Size = new System.Drawing.Size(388, 247);
            this.groupBoxDropAllowDetails.TabIndex = 1;
            this.groupBoxDropAllowDetails.TabStop = false;
            this.groupBoxDropAllowDetails.Text = "DropAllow Details";
            // 
            // tableLayoutPanelDropAllowDetails
            // 
            this.tableLayoutPanelDropAllowDetails.ColumnCount = 4;
            this.tableLayoutPanelDropAllowDetails.ColumnStyles.Add(new ColumnStyle());
            this.tableLayoutPanelDropAllowDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelDropAllowDetails.ColumnStyles.Add(new ColumnStyle());
            this.tableLayoutPanelDropAllowDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.labelDropAllowWizard, 0, 0);
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.textBoxDropAllowWizard, 1, 0);
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.labelDropAllowKnight, 2, 0);
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.textBoxDropAllowKnight, 3, 0);
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.labelDropAllowFairyElf, 0, 1);
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.textBoxDropAllowFairyElf, 1, 1);
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.labelDropAllowMagicGladiator, 2, 1);
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.textBoxDropAllowMagicGladiator, 3, 1);
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.labelDropAllowDarkLord, 0, 2);
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.textBoxDropAllowDarkLord, 1, 2);
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.labelDropAllowSummoner, 2, 2);
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.textBoxDropAllowSummoner, 3, 2);
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.labelDropAllowRageFighter, 0, 3);
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.textBoxDropAllowRageFighter, 1, 3);
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.labelDropAllowPlayerMinLevel, 2, 3);
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.textBoxDropAllowPlayerMinLevel, 3, 3);
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.labelDropAllowPlayerMaxLevel, 0, 4);
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.textBoxDropAllowPlayerMaxLevel, 1, 4);
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.labelDropAllowMapNumber, 2, 4);
            this.tableLayoutPanelDropAllowDetails.Controls.Add(this.textBoxDropAllowMapNumber, 3, 4);
            this.tableLayoutPanelDropAllowDetails.Dock = DockStyle.Fill;
            this.tableLayoutPanelDropAllowDetails.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanelDropAllowDetails.Name = "tableLayoutPanelDropAllowDetails";
            this.tableLayoutPanelDropAllowDetails.RowCount = 5;
            this.tableLayoutPanelDropAllowDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            this.tableLayoutPanelDropAllowDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            this.tableLayoutPanelDropAllowDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            this.tableLayoutPanelDropAllowDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            this.tableLayoutPanelDropAllowDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            this.tableLayoutPanelDropAllowDetails.Size = new System.Drawing.Size(382, 227);
            this.tableLayoutPanelDropAllowDetails.TabIndex = 0;
            // 
            // labelDropAllowWizard
            // 
            this.labelDropAllowWizard.Anchor = AnchorStyles.Left;
            this.labelDropAllowWizard.AutoSize = true;
            this.labelDropAllowWizard.Location = new System.Drawing.Point(3, 15);
            this.labelDropAllowWizard.Name = "labelDropAllowWizard";
            this.labelDropAllowWizard.Size = new System.Drawing.Size(42, 13);
            this.labelDropAllowWizard.TabIndex = 0;
            this.labelDropAllowWizard.Text = "Wizard:";
            this.textBoxDropAllowWizard.Dock = DockStyle.Fill;
            this.textBoxDropAllowWizard.Location = new System.Drawing.Point(51, 3);
            this.textBoxDropAllowWizard.Name = "textBoxDropAllowWizard";
            this.textBoxDropAllowWizard.Size = new System.Drawing.Size(137, 20);
            this.textBoxDropAllowWizard.TabIndex = 1;
            this.textBoxDropAllowWizard.TextChanged += new System.EventHandler(this.DropAllowField_TextChanged);
            // 
            // labelDropAllowKnight
            // 
            this.labelDropAllowKnight.Anchor = AnchorStyles.Left;
            this.labelDropAllowKnight.AutoSize = true;
            this.labelDropAllowKnight.Location = new System.Drawing.Point(194, 15);
            this.labelDropAllowKnight.Name = "labelDropAllowKnight";
            this.labelDropAllowKnight.Size = new System.Drawing.Size(38, 13);
            this.labelDropAllowKnight.TabIndex = 2;
            this.labelDropAllowKnight.Text = "Knight:";
            // 
            // textBoxDropAllowKnight
            // 
            this.textBoxDropAllowKnight.Dock = DockStyle.Fill;
            this.textBoxDropAllowKnight.Location = new System.Drawing.Point(238, 3);
            this.textBoxDropAllowKnight.Name = "textBoxDropAllowKnight";
            this.textBoxDropAllowKnight.Size = new System.Drawing.Size(141, 20);
            this.textBoxDropAllowKnight.TabIndex = 3;
            this.textBoxDropAllowKnight.TextChanged += new System.EventHandler(this.DropAllowField_TextChanged);
            // 
            // labelDropAllowFairyElf
            // 
            this.labelDropAllowFairyElf.Anchor = AnchorStyles.Left;
            this.labelDropAllowFairyElf.AutoSize = true;
            this.labelDropAllowFairyElf.Location = new System.Drawing.Point(3, 60);
            this.labelDropAllowFairyElf.Name = "labelDropAllowFairyElf";
            this.labelDropAllowFairyElf.Size = new System.Drawing.Size(48, 13);
            this.labelDropAllowFairyElf.TabIndex = 4;
            this.labelDropAllowFairyElf.Text = "FairyElf:";
            // 
            // textBoxDropAllowFairyElf
            // 
            this.textBoxDropAllowFairyElf.Dock = DockStyle.Fill;
            this.textBoxDropAllowFairyElf.Location = new System.Drawing.Point(51, 48);
            this.textBoxDropAllowFairyElf.Name = "textBoxDropAllowFairyElf";
            this.textBoxDropAllowFairyElf.Size = new System.Drawing.Size(137, 20);
            this.textBoxDropAllowFairyElf.TabIndex = 5;
            this.textBoxDropAllowFairyElf.TextChanged += new System.EventHandler(this.DropAllowField_TextChanged);
            // 
            // labelDropAllowMagicGladiator
            // 
            this.labelDropAllowMagicGladiator.Anchor = AnchorStyles.Left;
            this.labelDropAllowMagicGladiator.AutoSize = true;
            this.labelDropAllowMagicGladiator.Location = new System.Drawing.Point(194, 60);
            this.labelDropAllowMagicGladiator.Name = "labelDropAllowMagicGladiator";
            this.labelDropAllowMagicGladiator.Size = new System.Drawing.Size(88, 13);
            this.labelDropAllowMagicGladiator.TabIndex = 6;
            this.labelDropAllowMagicGladiator.Text = "Magic Gladiator:";
            // 
            // textBoxDropAllowMagicGladiator
            // 
            this.textBoxDropAllowMagicGladiator.Dock = DockStyle.Fill;
            this.textBoxDropAllowMagicGladiator.Location = new System.Drawing.Point(288, 48);
            this.textBoxDropAllowMagicGladiator.Name = "textBoxDropAllowMagicGladiator";
            this.textBoxDropAllowMagicGladiator.Size = new System.Drawing.Size(91, 20);
            this.textBoxDropAllowMagicGladiator.TabIndex = 7;
            this.textBoxDropAllowMagicGladiator.TextChanged += new System.EventHandler(this.DropAllowField_TextChanged);
            // 
            // labelDropAllowDarkLord
            // 
            this.labelDropAllowDarkLord.Anchor = AnchorStyles.Left;
            this.labelDropAllowDarkLord.AutoSize = true;
            this.labelDropAllowDarkLord.Location = new System.Drawing.Point(3, 105);
            this.labelDropAllowDarkLord.Name = "labelDropAllowDarkLord";
            this.labelDropAllowDarkLord.Size = new System.Drawing.Size(57, 13);
            this.labelDropAllowDarkLord.TabIndex = 8;
            this.labelDropAllowDarkLord.Text = "Dark Lord:";
            // 
            // textBoxDropAllowDarkLord
            // 
            this.textBoxDropAllowDarkLord.Dock = DockStyle.Fill;
            this.textBoxDropAllowDarkLord.Location = new System.Drawing.Point(51, 93);
            this.textBoxDropAllowDarkLord.Name = "textBoxDropAllowDarkLord";
            this.textBoxDropAllowDarkLord.Size = new System.Drawing.Size(137, 20);
            this.textBoxDropAllowDarkLord.TabIndex = 9;
            this.textBoxDropAllowDarkLord.TextChanged += new System.EventHandler(this.DropAllowField_TextChanged);
            // 
            // labelDropAllowSummoner
            // 
            this.labelDropAllowSummoner.Anchor = AnchorStyles.Left;
            this.labelDropAllowSummoner.AutoSize = true;
            this.labelDropAllowSummoner.Location = new System.Drawing.Point(194, 105);
            this.labelDropAllowSummoner.Name = "labelDropAllowSummoner";
            this.labelDropAllowSummoner.Size = new System.Drawing.Size(59, 13);
            this.labelDropAllowSummoner.TabIndex = 10;
            this.labelDropAllowSummoner.Text = "Summoner:";
            // 
            // textBoxDropAllowSummoner
            // 
            this.textBoxDropAllowSummoner.Dock = DockStyle.Fill;
            this.textBoxDropAllowSummoner.Location = new System.Drawing.Point(259, 93);
            this.textBoxDropAllowSummoner.Name = "textBoxDropAllowSummoner";
            this.textBoxDropAllowSummoner.Size = new System.Drawing.Size(120, 20);
            this.textBoxDropAllowSummoner.TabIndex = 11;
            this.textBoxDropAllowSummoner.TextChanged += new System.EventHandler(this.DropAllowField_TextChanged);
            // 
            // labelDropAllowRageFighter
            // 
            this.labelDropAllowRageFighter.Anchor = AnchorStyles.Left;
            this.labelDropAllowRageFighter.AutoSize = true;
            this.labelDropAllowRageFighter.Location = new System.Drawing.Point(3, 150);
            this.labelDropAllowRageFighter.Name = "labelDropAllowRageFighter";
            this.labelDropAllowRageFighter.Size = new System.Drawing.Size(73, 13);
            this.labelDropAllowRageFighter.TabIndex = 12;
            this.labelDropAllowRageFighter.Text = "Rage Fighter:";
            // 
            // textBoxDropAllowRageFighter
            // 
            this.textBoxDropAllowRageFighter.Dock = DockStyle.Fill;
            this.textBoxDropAllowRageFighter.Location = new System.Drawing.Point(51, 138);
            this.textBoxDropAllowRageFighter.Name = "textBoxDropAllowRageFighter";
            this.textBoxDropAllowRageFighter.Size = new System.Drawing.Size(137, 20);
            this.textBoxDropAllowRageFighter.TabIndex = 13;
            this.textBoxDropAllowRageFighter.TextChanged += new System.EventHandler(this.DropAllowField_TextChanged);
            // 
            // labelDropAllowPlayerMinLevel
            // 
            this.labelDropAllowPlayerMinLevel.Anchor = AnchorStyles.Left;
            this.labelDropAllowPlayerMinLevel.AutoSize = true;
            this.labelDropAllowPlayerMinLevel.Location = new System.Drawing.Point(194, 150);
            this.labelDropAllowPlayerMinLevel.Name = "labelDropAllowPlayerMinLevel";
            this.labelDropAllowPlayerMinLevel.Size = new System.Drawing.Size(66, 13);
            this.labelDropAllowPlayerMinLevel.TabIndex = 14;
            this.labelDropAllowPlayerMinLevel.Text = "Player Min:";
            // 
            // textBoxDropAllowPlayerMinLevel
            // 
            this.textBoxDropAllowPlayerMinLevel.Dock = DockStyle.Fill;
            this.textBoxDropAllowPlayerMinLevel.Location = new System.Drawing.Point(266, 138);
            this.textBoxDropAllowPlayerMinLevel.Name = "textBoxDropAllowPlayerMinLevel";
            this.textBoxDropAllowPlayerMinLevel.Size = new System.Drawing.Size(113, 20);
            this.textBoxDropAllowPlayerMinLevel.TabIndex = 15;
            this.textBoxDropAllowPlayerMinLevel.TextChanged += new System.EventHandler(this.DropAllowField_TextChanged);
            // 
            // labelDropAllowPlayerMaxLevel
            // 
            this.labelDropAllowPlayerMaxLevel.Anchor = AnchorStyles.Left;
            this.labelDropAllowPlayerMaxLevel.AutoSize = true;
            this.labelDropAllowPlayerMaxLevel.Location = new System.Drawing.Point(3, 195);
            this.labelDropAllowPlayerMaxLevel.Name = "labelDropAllowPlayerMaxLevel";
            this.labelDropAllowPlayerMaxLevel.Size = new System.Drawing.Size(69, 13);
            this.labelDropAllowPlayerMaxLevel.TabIndex = 16;
            this.labelDropAllowPlayerMaxLevel.Text = "Player Max:";
            // 
            // textBoxDropAllowPlayerMaxLevel
            // 
            this.textBoxDropAllowPlayerMaxLevel.Dock = DockStyle.Fill;
            this.textBoxDropAllowPlayerMaxLevel.Location = new System.Drawing.Point(51, 183);
            this.textBoxDropAllowPlayerMaxLevel.Name = "textBoxDropAllowPlayerMaxLevel";
            this.textBoxDropAllowPlayerMaxLevel.Size = new System.Drawing.Size(137, 20);
            this.textBoxDropAllowPlayerMaxLevel.TabIndex = 17;
            this.textBoxDropAllowPlayerMaxLevel.TextChanged += new System.EventHandler(this.DropAllowField_TextChanged);
            // 
            // labelDropAllowMapNumber
            // 
            this.labelDropAllowMapNumber.Anchor = AnchorStyles.Left;
            this.labelDropAllowMapNumber.AutoSize = true;
            this.labelDropAllowMapNumber.Location = new System.Drawing.Point(194, 195);
            this.labelDropAllowMapNumber.Name = "labelDropAllowMapNumber";
            this.labelDropAllowMapNumber.Size = new System.Drawing.Size(67, 13);
            this.labelDropAllowMapNumber.TabIndex = 18;
            this.labelDropAllowMapNumber.Text = "Map Number:";
            // 
            // textBoxDropAllowMapNumber
            // 
            this.textBoxDropAllowMapNumber.Dock = DockStyle.Fill;
            this.textBoxDropAllowMapNumber.Location = new System.Drawing.Point(267, 183);
            this.textBoxDropAllowMapNumber.Name = "textBoxDropAllowMapNumber";
            this.textBoxDropAllowMapNumber.Size = new System.Drawing.Size(112, 20);
            this.textBoxDropAllowMapNumber.TabIndex = 19;
            this.textBoxDropAllowMapNumber.TextChanged += new System.EventHandler(this.DropAllowField_TextChanged);
            // 
            // splitContainerDropsItems
            // 
            this.splitContainerDropsItems.Dock = DockStyle.Fill;
            this.splitContainerDropsItems.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDropsItems.Name = "splitContainerDropsItems";
            this.splitContainerDropsItems.Panel1.Controls.Add(this.tableLayoutPanelDrops);
            this.splitContainerDropsItems.Panel2.Controls.Add(this.tableLayoutPanelItems);
            this.splitContainerDropsItems.Size = new System.Drawing.Size(786, 460);
            this.splitContainerDropsItems.SplitterDistance = 262;
            this.splitContainerDropsItems.TabIndex = 0;
            // 
            // tableLayoutPanelDrops
            // 
            this.tableLayoutPanelDrops.ColumnCount = 1;
            this.tableLayoutPanelDrops.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanelDrops.Controls.Add(this.groupBoxDropList, 0, 0);
            this.tableLayoutPanelDrops.Controls.Add(this.groupBoxDropDetails, 0, 1);
            this.tableLayoutPanelDrops.Dock = DockStyle.Fill;
            this.tableLayoutPanelDrops.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDrops.Name = "tableLayoutPanelDrops";
            this.tableLayoutPanelDrops.RowCount = 2;
            this.tableLayoutPanelDrops.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            this.tableLayoutPanelDrops.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            this.tableLayoutPanelDrops.Size = new System.Drawing.Size(262, 460);
            this.tableLayoutPanelDrops.TabIndex = 0;
            // 
            // groupBoxDropList
            // 
            this.groupBoxDropList.Controls.Add(this.tableLayoutPanelDropList);
            this.groupBoxDropList.Dock = DockStyle.Fill;
            this.groupBoxDropList.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDropList.Name = "groupBoxDropList";
            this.groupBoxDropList.Size = new System.Drawing.Size(256, 270);
            this.groupBoxDropList.TabIndex = 0;
            this.groupBoxDropList.TabStop = false;
            this.groupBoxDropList.Text = "Drops";
            // 
            // tableLayoutPanelDropList
            // 
            this.tableLayoutPanelDropList.ColumnCount = 1;
            this.tableLayoutPanelDropList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanelDropList.Controls.Add(this.listBoxDrops, 0, 0);
            this.tableLayoutPanelDropList.Controls.Add(this.flowLayoutPanelDropButtons, 0, 1);
            this.tableLayoutPanelDropList.Dock = DockStyle.Fill;
            this.tableLayoutPanelDropList.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanelDropList.Name = "tableLayoutPanelDropList";
            this.tableLayoutPanelDropList.RowCount = 2;
            this.tableLayoutPanelDropList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanelDropList.RowStyles.Add(new RowStyle());
            this.tableLayoutPanelDropList.Size = new System.Drawing.Size(250, 250);
            this.tableLayoutPanelDropList.TabIndex = 0;
            // 
            // listBoxDrops
            // 
            this.listBoxDrops.Dock = DockStyle.Fill;
            this.listBoxDrops.FormattingEnabled = true;
            this.listBoxDrops.IntegralHeight = false;
            this.listBoxDrops.Location = new System.Drawing.Point(3, 3);
            this.listBoxDrops.Name = "listBoxDrops";
            this.listBoxDrops.Size = new System.Drawing.Size(244, 214);
            this.listBoxDrops.TabIndex = 0;
            this.listBoxDrops.SelectedIndexChanged += new System.EventHandler(this.listBoxDrops_SelectedIndexChanged);
            // 
            // flowLayoutPanelDropButtons
            // 
            this.flowLayoutPanelDropButtons.AutoSize = true;
            this.flowLayoutPanelDropButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelDropButtons.Controls.Add(this.buttonAddDrop);
            this.flowLayoutPanelDropButtons.Controls.Add(this.buttonRemoveDrop);
            this.flowLayoutPanelDropButtons.Controls.Add(this.buttonMoveDropUp);
            this.flowLayoutPanelDropButtons.Controls.Add(this.buttonMoveDropDown);
            this.flowLayoutPanelDropButtons.Dock = DockStyle.Fill;
            this.flowLayoutPanelDropButtons.Location = new System.Drawing.Point(3, 223);
            this.flowLayoutPanelDropButtons.Name = "flowLayoutPanelDropButtons";
            this.flowLayoutPanelDropButtons.Size = new System.Drawing.Size(244, 24);
            this.flowLayoutPanelDropButtons.TabIndex = 1;
            this.flowLayoutPanelDropButtons.WrapContents = false;
            // 
            // buttonAddDrop
            // 
            this.buttonAddDrop.AutoSize = true;
            this.buttonAddDrop.Location = new System.Drawing.Point(3, 3);
            this.buttonAddDrop.Name = "buttonAddDrop";
            this.buttonAddDrop.Size = new System.Drawing.Size(35, 23);
            this.buttonAddDrop.TabIndex = 0;
            this.buttonAddDrop.Text = "Add";
            this.buttonAddDrop.UseVisualStyleBackColor = true;
            this.buttonAddDrop.Click += new System.EventHandler(this.buttonAddDrop_Click);
            // 
            // buttonRemoveDrop
            // 
            this.buttonRemoveDrop.AutoSize = true;
            this.buttonRemoveDrop.Location = new System.Drawing.Point(44, 3);
            this.buttonRemoveDrop.Name = "buttonRemoveDrop";
            this.buttonRemoveDrop.Size = new System.Drawing.Size(54, 23);
            this.buttonRemoveDrop.TabIndex = 1;
            this.buttonRemoveDrop.Text = "Remove";
            this.buttonRemoveDrop.UseVisualStyleBackColor = true;
            this.buttonRemoveDrop.Click += new System.EventHandler(this.buttonRemoveDrop_Click);
            // 
            // buttonMoveDropUp
            // 
            this.buttonMoveDropUp.AutoSize = true;
            this.buttonMoveDropUp.Location = new System.Drawing.Point(104, 3);
            this.buttonMoveDropUp.Name = "buttonMoveDropUp";
            this.buttonMoveDropUp.Size = new System.Drawing.Size(26, 23);
            this.buttonMoveDropUp.TabIndex = 2;
            this.buttonMoveDropUp.Text = "↑";
            this.buttonMoveDropUp.UseVisualStyleBackColor = true;
            this.buttonMoveDropUp.Click += new System.EventHandler(this.buttonMoveDropUp_Click);
            // 
            // buttonMoveDropDown
            // 
            this.buttonMoveDropDown.AutoSize = true;
            this.buttonMoveDropDown.Location = new System.Drawing.Point(136, 3);
            this.buttonMoveDropDown.Name = "buttonMoveDropDown";
            this.buttonMoveDropDown.Size = new System.Drawing.Size(26, 23);
            this.buttonMoveDropDown.TabIndex = 3;
            this.buttonMoveDropDown.Text = "↓";
            this.buttonMoveDropDown.UseVisualStyleBackColor = true;
            this.buttonMoveDropDown.Click += new System.EventHandler(this.buttonMoveDropDown_Click);
            // 
            // groupBoxDropDetails
            // 
            this.groupBoxDropDetails.Controls.Add(this.tableLayoutPanelDropDetails);
            this.groupBoxDropDetails.Dock = DockStyle.Fill;
            this.groupBoxDropDetails.Location = new System.Drawing.Point(3, 279);
            this.groupBoxDropDetails.Name = "groupBoxDropDetails";
            this.groupBoxDropDetails.Size = new System.Drawing.Size(256, 178);
            this.groupBoxDropDetails.TabIndex = 1;
            this.groupBoxDropDetails.TabStop = false;
            this.groupBoxDropDetails.Text = "Drop Details";
            // 
            // tableLayoutPanelDropDetails
            // 
            this.tableLayoutPanelDropDetails.ColumnCount = 2;
            this.tableLayoutPanelDropDetails.ColumnStyles.Add(new ColumnStyle());
            this.tableLayoutPanelDropDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanelDropDetails.Controls.Add(this.labelDropRate, 0, 0);
            this.tableLayoutPanelDropDetails.Controls.Add(this.textBoxDropRate, 1, 0);
            this.tableLayoutPanelDropDetails.Controls.Add(this.labelDropCount, 0, 1);
            this.tableLayoutPanelDropDetails.Controls.Add(this.textBoxDropCount, 1, 1);
            this.tableLayoutPanelDropDetails.Dock = DockStyle.Fill;
            this.tableLayoutPanelDropDetails.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanelDropDetails.Name = "tableLayoutPanelDropDetails";
            this.tableLayoutPanelDropDetails.RowCount = 2;
            this.tableLayoutPanelDropDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelDropDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelDropDetails.Size = new System.Drawing.Size(250, 158);
            this.tableLayoutPanelDropDetails.TabIndex = 0;
            // 
            // labelDropRate
            // 
            this.labelDropRate.Anchor = AnchorStyles.Left;
            this.labelDropRate.AutoSize = true;
            this.labelDropRate.Location = new System.Drawing.Point(3, 30);
            this.labelDropRate.Name = "labelDropRate";
            this.labelDropRate.Size = new System.Drawing.Size(35, 13);
            this.labelDropRate.TabIndex = 0;
            this.labelDropRate.Text = "Rate:";
            // 
            // textBoxDropRate
            // 
            this.textBoxDropRate.Dock = DockStyle.Fill;
            this.textBoxDropRate.Location = new System.Drawing.Point(44, 3);
            this.textBoxDropRate.Name = "textBoxDropRate";
            this.textBoxDropRate.Size = new System.Drawing.Size(203, 20);
            this.textBoxDropRate.TabIndex = 1;
            this.textBoxDropRate.TextChanged += new System.EventHandler(this.DropField_TextChanged);
            // 
            // labelDropCount
            // 
            this.labelDropCount.Anchor = AnchorStyles.Left;
            this.labelDropCount.AutoSize = true;
            this.labelDropCount.Location = new System.Drawing.Point(3, 104);
            this.labelDropCount.Name = "labelDropCount";
            this.labelDropCount.Size = new System.Drawing.Size(38, 13);
            this.labelDropCount.TabIndex = 2;
            this.labelDropCount.Text = "Count:";
            // 
            // textBoxDropCount
            // 
            this.textBoxDropCount.Dock = DockStyle.Fill;
            this.textBoxDropCount.Location = new System.Drawing.Point(44, 82);
            this.textBoxDropCount.Name = "textBoxDropCount";
            this.textBoxDropCount.Size = new System.Drawing.Size(203, 20);
            this.textBoxDropCount.TabIndex = 3;
            this.textBoxDropCount.TextChanged += new System.EventHandler(this.DropField_TextChanged);
            // 
            // tableLayoutPanelItems
            // 
            this.tableLayoutPanelItems.ColumnCount = 1;
            this.tableLayoutPanelItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanelItems.Controls.Add(this.groupBoxItemList, 0, 0);
            this.tableLayoutPanelItems.Controls.Add(this.groupBoxItemDetails, 0, 1);
            this.tableLayoutPanelItems.Dock = DockStyle.Fill;
            this.tableLayoutPanelItems.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelItems.Name = "tableLayoutPanelItems";
            this.tableLayoutPanelItems.RowCount = 2;
            this.tableLayoutPanelItems.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            this.tableLayoutPanelItems.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            this.tableLayoutPanelItems.Size = new System.Drawing.Size(520, 460);
            this.tableLayoutPanelItems.TabIndex = 0;
            // 
            // groupBoxItemList
            // 
            this.groupBoxItemList.Controls.Add(this.tableLayoutPanelItemList);
            this.groupBoxItemList.Dock = DockStyle.Fill;
            this.groupBoxItemList.Location = new System.Drawing.Point(3, 3);
            this.groupBoxItemList.Name = "groupBoxItemList";
            this.groupBoxItemList.Size = new System.Drawing.Size(514, 201);
            this.groupBoxItemList.TabIndex = 0;
            this.groupBoxItemList.TabStop = false;
            this.groupBoxItemList.Text = "Items";
            // 
            // tableLayoutPanelItemList
            // 
            this.tableLayoutPanelItemList.ColumnCount = 1;
            this.tableLayoutPanelItemList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanelItemList.Controls.Add(this.listBoxItems, 0, 0);
            this.tableLayoutPanelItemList.Controls.Add(this.flowLayoutPanelItemButtons, 0, 1);
            this.tableLayoutPanelItemList.Dock = DockStyle.Fill;
            this.tableLayoutPanelItemList.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanelItemList.Name = "tableLayoutPanelItemList";
            this.tableLayoutPanelItemList.RowCount = 2;
            this.tableLayoutPanelItemList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanelItemList.RowStyles.Add(new RowStyle());
            this.tableLayoutPanelItemList.Size = new System.Drawing.Size(508, 181);
            this.tableLayoutPanelItemList.TabIndex = 0;
            // 
            // listBoxItems
            // 
            this.listBoxItems.Dock = DockStyle.Fill;
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.IntegralHeight = false;
            this.listBoxItems.Location = new System.Drawing.Point(3, 3);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(502, 146);
            this.listBoxItems.TabIndex = 0;
            this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listBoxItems_SelectedIndexChanged);
            // 
            // flowLayoutPanelItemButtons
            // 
            this.flowLayoutPanelItemButtons.AutoSize = true;
            this.flowLayoutPanelItemButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelItemButtons.Controls.Add(this.buttonAddItem);
            this.flowLayoutPanelItemButtons.Controls.Add(this.buttonRemoveItem);
            this.flowLayoutPanelItemButtons.Controls.Add(this.buttonMoveItemUp);
            this.flowLayoutPanelItemButtons.Controls.Add(this.buttonMoveItemDown);
            this.flowLayoutPanelItemButtons.Dock = DockStyle.Fill;
            this.flowLayoutPanelItemButtons.Location = new System.Drawing.Point(3, 155);
            this.flowLayoutPanelItemButtons.Name = "flowLayoutPanelItemButtons";
            this.flowLayoutPanelItemButtons.Size = new System.Drawing.Size(502, 23);
            this.flowLayoutPanelItemButtons.TabIndex = 1;
            this.flowLayoutPanelItemButtons.WrapContents = false;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.AutoSize = true;
            this.buttonAddItem.Location = new System.Drawing.Point(3, 3);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(35, 23);
            this.buttonAddItem.TabIndex = 0;
            this.buttonAddItem.Text = "Add";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.AutoSize = true;
            this.buttonRemoveItem.Location = new System.Drawing.Point(44, 3);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(54, 23);
            this.buttonRemoveItem.TabIndex = 1;
            this.buttonRemoveItem.Text = "Remove";
            this.buttonRemoveItem.UseVisualStyleBackColor = true;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // buttonMoveItemUp
            // 
            this.buttonMoveItemUp.AutoSize = true;
            this.buttonMoveItemUp.Location = new System.Drawing.Point(104, 3);
            this.buttonMoveItemUp.Name = "buttonMoveItemUp";
            this.buttonMoveItemUp.Size = new System.Drawing.Size(26, 23);
            this.buttonMoveItemUp.TabIndex = 2;
            this.buttonMoveItemUp.Text = "↑";
            this.buttonMoveItemUp.UseVisualStyleBackColor = true;
            this.buttonMoveItemUp.Click += new System.EventHandler(this.buttonMoveItemUp_Click);
            // 
            // buttonMoveItemDown
            // 
            this.buttonMoveItemDown.AutoSize = true;
            this.buttonMoveItemDown.Location = new System.Drawing.Point(136, 3);
            this.buttonMoveItemDown.Name = "buttonMoveItemDown";
            this.buttonMoveItemDown.Size = new System.Drawing.Size(26, 23);
            this.buttonMoveItemDown.TabIndex = 3;
            this.buttonMoveItemDown.Text = "↓";
            this.buttonMoveItemDown.UseVisualStyleBackColor = true;
            this.buttonMoveItemDown.Click += new System.EventHandler(this.buttonMoveItemDown_Click);
            // 
            // groupBoxItemDetails
            // 
            this.groupBoxItemDetails.Controls.Add(this.tableLayoutPanelItemDetails);
            this.groupBoxItemDetails.Dock = DockStyle.Fill;
            this.groupBoxItemDetails.Location = new System.Drawing.Point(3, 210);
            this.groupBoxItemDetails.Name = "groupBoxItemDetails";
            this.groupBoxItemDetails.Size = new System.Drawing.Size(514, 247);
            this.groupBoxItemDetails.TabIndex = 1;
            this.groupBoxItemDetails.TabStop = false;
            this.groupBoxItemDetails.Text = "Item Details";
            // 
            // tableLayoutPanelItemDetails
            // 
            this.tableLayoutPanelItemDetails.ColumnCount = 4;
            this.tableLayoutPanelItemDetails.ColumnStyles.Add(new ColumnStyle());
            this.tableLayoutPanelItemDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelItemDetails.ColumnStyles.Add(new ColumnStyle());
            this.tableLayoutPanelItemDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelItemDetails.Controls.Add(this.labelItemCat, 0, 0);
            this.tableLayoutPanelItemDetails.Controls.Add(this.textBoxItemCat, 1, 0);
            this.tableLayoutPanelItemDetails.Controls.Add(this.labelItemIndex, 2, 0);
            this.tableLayoutPanelItemDetails.Controls.Add(this.textBoxItemIndex, 3, 0);
            this.tableLayoutPanelItemDetails.Controls.Add(this.labelItemMinLevel, 0, 1);
            this.tableLayoutPanelItemDetails.Controls.Add(this.textBoxItemMinLevel, 1, 1);
            this.tableLayoutPanelItemDetails.Controls.Add(this.labelItemMaxLevel, 2, 1);
            this.tableLayoutPanelItemDetails.Controls.Add(this.textBoxItemMaxLevel, 3, 1);
            this.tableLayoutPanelItemDetails.Controls.Add(this.labelItemDurability, 0, 2);
            this.tableLayoutPanelItemDetails.Controls.Add(this.textBoxItemDurability, 1, 2);
            this.tableLayoutPanelItemDetails.Controls.Add(this.labelItemSkill, 2, 2);
            this.tableLayoutPanelItemDetails.Controls.Add(this.textBoxItemSkill, 3, 2);
            this.tableLayoutPanelItemDetails.Controls.Add(this.labelItemLuck, 0, 3);
            this.tableLayoutPanelItemDetails.Controls.Add(this.textBoxItemLuck, 1, 3);
            this.tableLayoutPanelItemDetails.Controls.Add(this.labelItemOption, 2, 3);
            this.tableLayoutPanelItemDetails.Controls.Add(this.textBoxItemOption, 3, 3);
            this.tableLayoutPanelItemDetails.Controls.Add(this.labelItemExc, 0, 4);
            this.tableLayoutPanelItemDetails.Controls.Add(this.textBoxItemExc, 1, 4);
            this.tableLayoutPanelItemDetails.Controls.Add(this.labelItemSetItem, 2, 4);
            this.tableLayoutPanelItemDetails.Controls.Add(this.textBoxItemSetItem, 3, 4);
            this.tableLayoutPanelItemDetails.Controls.Add(this.labelItemSocketCount, 0, 5);
            this.tableLayoutPanelItemDetails.Controls.Add(this.textBoxItemSocketCount, 1, 5);
            this.tableLayoutPanelItemDetails.Controls.Add(this.labelItemElementalItem, 2, 5);
            this.tableLayoutPanelItemDetails.Controls.Add(this.textBoxItemElementalItem, 3, 5);
            this.tableLayoutPanelItemDetails.Controls.Add(this.labelItemMuunCat, 0, 6);
            this.tableLayoutPanelItemDetails.Controls.Add(this.textBoxItemMuunCat, 1, 6);
            this.tableLayoutPanelItemDetails.Controls.Add(this.labelItemMuunIndex, 2, 6);
            this.tableLayoutPanelItemDetails.Controls.Add(this.textBoxItemMuunIndex, 3, 6);
            this.tableLayoutPanelItemDetails.Controls.Add(this.labelItemKindA, 0, 7);
            this.tableLayoutPanelItemDetails.Controls.Add(this.textBoxItemKindA, 1, 7);
            this.tableLayoutPanelItemDetails.Controls.Add(this.labelItemDropRate, 2, 7);
            this.tableLayoutPanelItemDetails.Controls.Add(this.textBoxItemDropRate, 3, 7);
            this.tableLayoutPanelItemDetails.Controls.Add(this.labelItemDuration, 0, 8);
            this.tableLayoutPanelItemDetails.Controls.Add(this.textBoxItemDuration, 1, 8);
            this.tableLayoutPanelItemDetails.SetColumnSpan(this.textBoxItemDuration, 3);
            this.tableLayoutPanelItemDetails.Dock = DockStyle.Fill;
            this.tableLayoutPanelItemDetails.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanelItemDetails.Name = "tableLayoutPanelItemDetails";
            this.tableLayoutPanelItemDetails.RowCount = 9;
            this.tableLayoutPanelItemDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            this.tableLayoutPanelItemDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            this.tableLayoutPanelItemDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            this.tableLayoutPanelItemDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            this.tableLayoutPanelItemDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            this.tableLayoutPanelItemDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            this.tableLayoutPanelItemDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            this.tableLayoutPanelItemDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            this.tableLayoutPanelItemDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            this.tableLayoutPanelItemDetails.Size = new System.Drawing.Size(508, 227);
            this.tableLayoutPanelItemDetails.TabIndex = 0;
            // 
            // labelItemCat
            // 
            this.labelItemCat.Anchor = AnchorStyles.Left;
            this.labelItemCat.AutoSize = true;
            this.labelItemCat.Location = new System.Drawing.Point(3, 6);
            this.labelItemCat.Name = "labelItemCat";
            this.labelItemCat.Size = new System.Drawing.Size(26, 13);
            this.labelItemCat.TabIndex = 0;
            this.labelItemCat.Text = "Cat:";
            // 
            // textBoxItemCat
            // 
            this.textBoxItemCat.Dock = DockStyle.Fill;
            this.textBoxItemCat.Location = new System.Drawing.Point(35, 3);
            this.textBoxItemCat.Name = "textBoxItemCat";
            this.textBoxItemCat.Size = new System.Drawing.Size(216, 20);
            this.textBoxItemCat.TabIndex = 1;
            this.textBoxItemCat.TextChanged += new System.EventHandler(this.ItemField_TextChanged);
            // 
            // labelItemIndex
            // 
            this.labelItemIndex.Anchor = AnchorStyles.Left;
            this.labelItemIndex.AutoSize = true;
            this.labelItemIndex.Location = new System.Drawing.Point(257, 6);
            this.labelItemIndex.Name = "labelItemIndex";
            this.labelItemIndex.Size = new System.Drawing.Size(36, 13);
            this.labelItemIndex.TabIndex = 2;
            this.labelItemIndex.Text = "Index:";
            // 
            // textBoxItemIndex
            // 
            this.textBoxItemIndex.Dock = DockStyle.Fill;
            this.textBoxItemIndex.Location = new System.Drawing.Point(299, 3);
            this.textBoxItemIndex.Name = "textBoxItemIndex";
            this.textBoxItemIndex.Size = new System.Drawing.Size(206, 20);
            this.textBoxItemIndex.TabIndex = 3;
            this.textBoxItemIndex.TextChanged += new System.EventHandler(this.ItemField_TextChanged);
            // 
            // labelItemMinLevel
            // 
            this.labelItemMinLevel.Anchor = AnchorStyles.Left;
            this.labelItemMinLevel.AutoSize = true;
            this.labelItemMinLevel.Location = new System.Drawing.Point(3, 31);
            this.labelItemMinLevel.Name = "labelItemMinLevel";
            this.labelItemMinLevel.Size = new System.Drawing.Size(53, 13);
            this.labelItemMinLevel.TabIndex = 4;
            this.labelItemMinLevel.Text = "Min Level:";
            // 
            // textBoxItemMinLevel
            // 
            this.textBoxItemMinLevel.Dock = DockStyle.Fill;
            this.textBoxItemMinLevel.Location = new System.Drawing.Point(62, 28);
            this.textBoxItemMinLevel.Name = "textBoxItemMinLevel";
            this.textBoxItemMinLevel.Size = new System.Drawing.Size(189, 20);
            this.textBoxItemMinLevel.TabIndex = 5;
            this.textBoxItemMinLevel.TextChanged += new System.EventHandler(this.ItemField_TextChanged);
            // 
            // labelItemMaxLevel
            // 
            this.labelItemMaxLevel.Anchor = AnchorStyles.Left;
            this.labelItemMaxLevel.AutoSize = true;
            this.labelItemMaxLevel.Location = new System.Drawing.Point(257, 31);
            this.labelItemMaxLevel.Name = "labelItemMaxLevel";
            this.labelItemMaxLevel.Size = new System.Drawing.Size(56, 13);
            this.labelItemMaxLevel.TabIndex = 6;
            this.labelItemMaxLevel.Text = "Max Level:";
            // 
            // textBoxItemMaxLevel
            // 
            this.textBoxItemMaxLevel.Dock = DockStyle.Fill;
            this.textBoxItemMaxLevel.Location = new System.Drawing.Point(319, 28);
            this.textBoxItemMaxLevel.Name = "textBoxItemMaxLevel";
            this.textBoxItemMaxLevel.Size = new System.Drawing.Size(186, 20);
            this.textBoxItemMaxLevel.TabIndex = 7;
            this.textBoxItemMaxLevel.TextChanged += new System.EventHandler(this.ItemField_TextChanged);
            // 
            // labelItemDurability
            // 
            this.labelItemDurability.Anchor = AnchorStyles.Left;
            this.labelItemDurability.AutoSize = true;
            this.labelItemDurability.Location = new System.Drawing.Point(3, 56);
            this.labelItemDurability.Name = "labelItemDurability";
            this.labelItemDurability.Size = new System.Drawing.Size(53, 13);
            this.labelItemDurability.TabIndex = 8;
            this.labelItemDurability.Text = "Durability:";
            // 
            // textBoxItemDurability
            // 
            this.textBoxItemDurability.Dock = DockStyle.Fill;
            this.textBoxItemDurability.Location = new System.Drawing.Point(62, 53);
            this.textBoxItemDurability.Name = "textBoxItemDurability";
            this.textBoxItemDurability.Size = new System.Drawing.Size(189, 20);
            this.textBoxItemDurability.TabIndex = 9;
            this.textBoxItemDurability.TextChanged += new System.EventHandler(this.ItemField_TextChanged);
            // 
            // labelItemSkill
            // 
            this.labelItemSkill.Anchor = AnchorStyles.Left;
            this.labelItemSkill.AutoSize = true;
            this.labelItemSkill.Location = new System.Drawing.Point(257, 56);
            this.labelItemSkill.Name = "labelItemSkill";
            this.labelItemSkill.Size = new System.Drawing.Size(28, 13);
            this.labelItemSkill.TabIndex = 10;
            this.labelItemSkill.Text = "Skill:";
            // 
            // textBoxItemSkill
            // 
            this.textBoxItemSkill.Dock = DockStyle.Fill;
            this.textBoxItemSkill.Location = new System.Drawing.Point(291, 53);
            this.textBoxItemSkill.Name = "textBoxItemSkill";
            this.textBoxItemSkill.Size = new System.Drawing.Size(214, 20);
            this.textBoxItemSkill.TabIndex = 11;
            this.textBoxItemSkill.TextChanged += new System.EventHandler(this.ItemField_TextChanged);
            // 
            // labelItemLuck
            // 
            this.labelItemLuck.Anchor = AnchorStyles.Left;
            this.labelItemLuck.AutoSize = true;
            this.labelItemLuck.Location = new System.Drawing.Point(3, 81);
            this.labelItemLuck.Name = "labelItemLuck";
            this.labelItemLuck.Size = new System.Drawing.Size(31, 13);
            this.labelItemLuck.TabIndex = 12;
            this.labelItemLuck.Text = "Luck:";
            // 
            // textBoxItemLuck
            // 
            this.textBoxItemLuck.Dock = DockStyle.Fill;
            this.textBoxItemLuck.Location = new System.Drawing.Point(40, 78);
            this.textBoxItemLuck.Name = "textBoxItemLuck";
            this.textBoxItemLuck.Size = new System.Drawing.Size(211, 20);
            this.textBoxItemLuck.TabIndex = 13;
            this.textBoxItemLuck.TextChanged += new System.EventHandler(this.ItemField_TextChanged);
            // 
            // labelItemOption
            // 
            this.labelItemOption.Anchor = AnchorStyles.Left;
            this.labelItemOption.AutoSize = true;
            this.labelItemOption.Location = new System.Drawing.Point(257, 81);
            this.labelItemOption.Name = "labelItemOption";
            this.labelItemOption.Size = new System.Drawing.Size(39, 13);
            this.labelItemOption.TabIndex = 14;
            this.labelItemOption.Text = "Option:";
            // 
            // textBoxItemOption
            // 
            this.textBoxItemOption.Dock = DockStyle.Fill;
            this.textBoxItemOption.Location = new System.Drawing.Point(302, 78);
            this.textBoxItemOption.Name = "textBoxItemOption";
            this.textBoxItemOption.Size = new System.Drawing.Size(203, 20);
            this.textBoxItemOption.TabIndex = 15;
            this.textBoxItemOption.TextChanged += new System.EventHandler(this.ItemField_TextChanged);
            // 
            // labelItemExc
            // 
            this.labelItemExc.Anchor = AnchorStyles.Left;
            this.labelItemExc.AutoSize = true;
            this.labelItemExc.Location = new System.Drawing.Point(3, 106);
            this.labelItemExc.Name = "labelItemExc";
            this.labelItemExc.Size = new System.Drawing.Size(27, 13);
            this.labelItemExc.TabIndex = 16;
            this.labelItemExc.Text = "Exc:";
            // 
            // textBoxItemExc
            // 
            this.textBoxItemExc.Dock = DockStyle.Fill;
            this.textBoxItemExc.Location = new System.Drawing.Point(36, 103);
            this.textBoxItemExc.Name = "textBoxItemExc";
            this.textBoxItemExc.Size = new System.Drawing.Size(215, 20);
            this.textBoxItemExc.TabIndex = 17;
            this.textBoxItemExc.TextChanged += new System.EventHandler(this.ItemField_TextChanged);
            // 
            // labelItemSetItem
            // 
            this.labelItemSetItem.Anchor = AnchorStyles.Left;
            this.labelItemSetItem.AutoSize = true;
            this.labelItemSetItem.Location = new System.Drawing.Point(257, 106);
            this.labelItemSetItem.Name = "labelItemSetItem";
            this.labelItemSetItem.Size = new System.Drawing.Size(47, 13);
            this.labelItemSetItem.TabIndex = 18;
            this.labelItemSetItem.Text = "Set Item:";
            // 
            // textBoxItemSetItem
            // 
            this.textBoxItemSetItem.Dock = DockStyle.Fill;
            this.textBoxItemSetItem.Location = new System.Drawing.Point(310, 103);
            this.textBoxItemSetItem.Name = "textBoxItemSetItem";
            this.textBoxItemSetItem.Size = new System.Drawing.Size(195, 20);
            this.textBoxItemSetItem.TabIndex = 19;
            this.textBoxItemSetItem.TextChanged += new System.EventHandler(this.ItemField_TextChanged);
            // 
            // labelItemSocketCount
            // 
            this.labelItemSocketCount.Anchor = AnchorStyles.Left;
            this.labelItemSocketCount.AutoSize = true;
            this.labelItemSocketCount.Location = new System.Drawing.Point(3, 131);
            this.labelItemSocketCount.Name = "labelItemSocketCount";
            this.labelItemSocketCount.Size = new System.Drawing.Size(71, 13);
            this.labelItemSocketCount.TabIndex = 20;
            this.labelItemSocketCount.Text = "Socket Count:";
            // 
            // textBoxItemSocketCount
            // 
            this.textBoxItemSocketCount.Dock = DockStyle.Fill;
            this.textBoxItemSocketCount.Location = new System.Drawing.Point(80, 128);
            this.textBoxItemSocketCount.Name = "textBoxItemSocketCount";
            this.textBoxItemSocketCount.Size = new System.Drawing.Size(171, 20);
            this.textBoxItemSocketCount.TabIndex = 21;
            this.textBoxItemSocketCount.TextChanged += new System.EventHandler(this.ItemField_TextChanged);
            // 
            // labelItemElementalItem
            // 
            this.labelItemElementalItem.Anchor = AnchorStyles.Left;
            this.labelItemElementalItem.AutoSize = true;
            this.labelItemElementalItem.Location = new System.Drawing.Point(257, 131);
            this.labelItemElementalItem.Name = "labelItemElementalItem";
            this.labelItemElementalItem.Size = new System.Drawing.Size(78, 13);
            this.labelItemElementalItem.TabIndex = 22;
            this.labelItemElementalItem.Text = "Elemental Item:";
            // 
            // textBoxItemElementalItem
            // 
            this.textBoxItemElementalItem.Dock = DockStyle.Fill;
            this.textBoxItemElementalItem.Location = new System.Drawing.Point(341, 128);
            this.textBoxItemElementalItem.Name = "textBoxItemElementalItem";
            this.textBoxItemElementalItem.Size = new System.Drawing.Size(162, 20);
            this.textBoxItemElementalItem.TabIndex = 23;
            this.textBoxItemElementalItem.TextChanged += new System.EventHandler(this.ItemField_TextChanged);
            // 
            // labelItemMuunCat
            // 
            this.labelItemMuunCat.Anchor = AnchorStyles.Left;
            this.labelItemMuunCat.AutoSize = true;
            this.labelItemMuunCat.Location = new System.Drawing.Point(3, 156);
            this.labelItemMuunCat.Name = "labelItemMuunCat";
            this.labelItemMuunCat.Size = new System.Drawing.Size(54, 13);
            this.labelItemMuunCat.TabIndex = 24;
            this.labelItemMuunCat.Text = "Muun Cat:";
            // 
            // textBoxItemMuunCat
            // 
            this.textBoxItemMuunCat.Dock = DockStyle.Fill;
            this.textBoxItemMuunCat.Location = new System.Drawing.Point(63, 153);
            this.textBoxItemMuunCat.Name = "textBoxItemMuunCat";
            this.textBoxItemMuunCat.Size = new System.Drawing.Size(188, 20);
            this.textBoxItemMuunCat.TabIndex = 25;
            this.textBoxItemMuunCat.TextChanged += new System.EventHandler(this.ItemField_TextChanged);
            // 
            // labelItemMuunIndex
            // 
            this.labelItemMuunIndex.Anchor = AnchorStyles.Left;
            this.labelItemMuunIndex.AutoSize = true;
            this.labelItemMuunIndex.Location = new System.Drawing.Point(257, 156);
            this.labelItemMuunIndex.Name = "labelItemMuunIndex";
            this.labelItemMuunIndex.Size = new System.Drawing.Size(59, 13);
            this.labelItemMuunIndex.TabIndex = 26;
            this.labelItemMuunIndex.Text = "Muun Index:";
            // 
            // textBoxItemMuunIndex
            // 
            this.textBoxItemMuunIndex.Dock = DockStyle.Fill;
            this.textBoxItemMuunIndex.Location = new System.Drawing.Point(322, 153);
            this.textBoxItemMuunIndex.Name = "textBoxItemMuunIndex";
            this.textBoxItemMuunIndex.Size = new System.Drawing.Size(181, 20);
            this.textBoxItemMuunIndex.TabIndex = 27;
            this.textBoxItemMuunIndex.TextChanged += new System.EventHandler(this.ItemField_TextChanged);
            // 
            // labelItemKindA
            // 
            this.labelItemKindA.Anchor = AnchorStyles.Left;
            this.labelItemKindA.AutoSize = true;
            this.labelItemKindA.Location = new System.Drawing.Point(3, 181);
            this.labelItemKindA.Name = "labelItemKindA";
            this.labelItemKindA.Size = new System.Drawing.Size(41, 13);
            this.labelItemKindA.TabIndex = 28;
            this.labelItemKindA.Text = "Kind A:";
            // 
            // textBoxItemKindA
            // 
            this.textBoxItemKindA.Dock = DockStyle.Fill;
            this.textBoxItemKindA.Location = new System.Drawing.Point(50, 178);
            this.textBoxItemKindA.Name = "textBoxItemKindA";
            this.textBoxItemKindA.Size = new System.Drawing.Size(201, 20);
            this.textBoxItemKindA.TabIndex = 29;
            this.textBoxItemKindA.TextChanged += new System.EventHandler(this.ItemField_TextChanged);
            // 
            // labelItemDropRate
            // 
            this.labelItemDropRate.Anchor = AnchorStyles.Left;
            this.labelItemDropRate.AutoSize = true;
            this.labelItemDropRate.Location = new System.Drawing.Point(257, 181);
            this.labelItemDropRate.Name = "labelItemDropRate";
            this.labelItemDropRate.Size = new System.Drawing.Size(56, 13);
            this.labelItemDropRate.TabIndex = 30;
            this.labelItemDropRate.Text = "Drop Rate:";
            // 
            // textBoxItemDropRate
            // 
            this.textBoxItemDropRate.Dock = DockStyle.Fill;
            this.textBoxItemDropRate.Location = new System.Drawing.Point(319, 178);
            this.textBoxItemDropRate.Name = "textBoxItemDropRate";
            this.textBoxItemDropRate.Size = new System.Drawing.Size(184, 20);
            this.textBoxItemDropRate.TabIndex = 31;
            this.textBoxItemDropRate.TextChanged += new System.EventHandler(this.ItemField_TextChanged);
            // 
            // labelItemDuration
            // 
            this.labelItemDuration.Anchor = AnchorStyles.Left;
            this.labelItemDuration.AutoSize = true;
            this.labelItemDuration.Location = new System.Drawing.Point(3, 208);
            this.labelItemDuration.Name = "labelItemDuration";
            this.labelItemDuration.Size = new System.Drawing.Size(50, 13);
            this.labelItemDuration.TabIndex = 32;
            this.labelItemDuration.Text = "Duration:";
            // 
            // textBoxItemDuration
            // 
            this.textBoxItemDuration.Dock = DockStyle.Fill;
            this.textBoxItemDuration.Location = new System.Drawing.Point(59, 203);
            this.textBoxItemDuration.Name = "textBoxItemDuration";
            this.textBoxItemDuration.Size = new System.Drawing.Size(439, 20);
            this.textBoxItemDuration.TabIndex = 33;
            this.textBoxItemDuration.TextChanged += new System.EventHandler(this.ItemField_TextChanged);
            // 
            // EventBagEditor_XML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.labelCurrentFile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EventBagEditor_XML";
            this.Text = "EventBag Editor (XML)";
            this.FormClosed += new FormClosedEventHandler(this.EventBagEditor_XML_FormClosed);
            this.Load += new System.EventHandler(this.EventBagEditor_XML_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.groupBoxBagConfig.ResumeLayout(false);
            this.tableLayoutPanelBagConfig.ResumeLayout(false);
            this.tableLayoutPanelBagConfig.PerformLayout();
            this.tableLayoutPanelSecondaryConfig.ResumeLayout(false);
            this.groupBoxSummonBook.ResumeLayout(false);
            this.tableLayoutPanelSummonBook.ResumeLayout(false);
            this.tableLayoutPanelSummonBook.PerformLayout();
            this.groupBoxAddCoin.ResumeLayout(false);
            this.tableLayoutPanelAddCoin.ResumeLayout(false);
            this.tableLayoutPanelAddCoin.PerformLayout();
            this.splitContainerBottom.Panel1.ResumeLayout(false);
            this.splitContainerBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).EndInit();
            this.splitContainerBottom.ResumeLayout(false);
            this.tableLayoutPanelDropAllow.ResumeLayout(false);
            this.groupBoxDropAllowList.ResumeLayout(false);
            this.tableLayoutPanelDropAllowList.ResumeLayout(false);
            this.tableLayoutPanelDropAllowList.PerformLayout();
            this.flowLayoutPanelDropAllowButtons.ResumeLayout(false);
            this.flowLayoutPanelDropAllowButtons.PerformLayout();
            this.groupBoxDropAllowDetails.ResumeLayout(false);
            this.tableLayoutPanelDropAllowDetails.ResumeLayout(false);
            this.tableLayoutPanelDropAllowDetails.PerformLayout();
            this.splitContainerDropsItems.Panel1.ResumeLayout(false);
            this.splitContainerDropsItems.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDropsItems)).EndInit();
            this.splitContainerDropsItems.ResumeLayout(false);
            this.tableLayoutPanelDrops.ResumeLayout(false);
            this.groupBoxDropList.ResumeLayout(false);
            this.tableLayoutPanelDropList.ResumeLayout(false);
            this.tableLayoutPanelDropList.PerformLayout();
            this.flowLayoutPanelDropButtons.ResumeLayout(false);
            this.flowLayoutPanelDropButtons.PerformLayout();
            this.groupBoxDropDetails.ResumeLayout(false);
            this.tableLayoutPanelDropDetails.ResumeLayout(false);
            this.tableLayoutPanelDropDetails.PerformLayout();
            this.tableLayoutPanelItems.ResumeLayout(false);
            this.groupBoxItemList.ResumeLayout(false);
            this.tableLayoutPanelItemList.ResumeLayout(false);
            this.tableLayoutPanelItemList.PerformLayout();
            this.flowLayoutPanelItemButtons.ResumeLayout(false);
            this.flowLayoutPanelItemButtons.PerformLayout();
            this.groupBoxItemDetails.ResumeLayout(false);
            this.tableLayoutPanelItemDetails.ResumeLayout(false);
            this.tableLayoutPanelItemDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private Label labelCurrentFile;
        private SplitContainer splitContainerMain;
        private TableLayoutPanel tableLayoutPanelTop;
        private GroupBox groupBoxBagConfig;
        private TableLayoutPanel tableLayoutPanelBagConfig;
        private Label labelBagName;
        private TextBox textBoxBagName;
        private Label labelBagItemRate;
        private TextBox textBoxBagItemRate;
        private Label labelBagSetItemRate;
        private TextBox textBoxBagSetItemRate;
        private Label labelBagMoneyDrop;
        private TextBox textBoxBagMoneyDrop;
        private Label labelBagUseEffect;
        private TextBox textBoxBagUseEffect;
        private Label labelBagUseRate;
        private TextBox textBoxBagUseRate;
        private TableLayoutPanel tableLayoutPanelSecondaryConfig;
        private GroupBox groupBoxSummonBook;
        private TableLayoutPanel tableLayoutPanelSummonBook;
        private Label labelSummonEnable;
        private TextBox textBoxSummonEnable;
        private Label labelSummonDropRate;
        private TextBox textBoxSummonDropRate;
        private Label labelSummonItemCat;
        private TextBox textBoxSummonItemCat;
        private Label labelSummonItemIndex;
        private TextBox textBoxSummonItemIndex;
        private GroupBox groupBoxAddCoin;
        private TableLayoutPanel tableLayoutPanelAddCoin;
        private Label labelCoinEnable;
        private TextBox textBoxCoinEnable;
        private Label labelCoinType;
        private TextBox textBoxCoinType;
        private Label labelCoinValue;
        private TextBox textBoxCoinValue;
        private SplitContainer splitContainerBottom;
        private TableLayoutPanel tableLayoutPanelDropAllow;
        private GroupBox groupBoxDropAllowList;
        private TableLayoutPanel tableLayoutPanelDropAllowList;
        private ListBox listBoxDropAllows;
        private FlowLayoutPanel flowLayoutPanelDropAllowButtons;
        private Button buttonAddDropAllow;
        private Button buttonRemoveDropAllow;
        private Button buttonMoveDropAllowUp;
        private Button buttonMoveDropAllowDown;
        private GroupBox groupBoxDropAllowDetails;
        private TableLayoutPanel tableLayoutPanelDropAllowDetails;
        private Label labelDropAllowWizard;
        private TextBox textBoxDropAllowWizard;
        private Label labelDropAllowKnight;
        private TextBox textBoxDropAllowKnight;
        private Label labelDropAllowFairyElf;
        private TextBox textBoxDropAllowFairyElf;
        private Label labelDropAllowMagicGladiator;
        private TextBox textBoxDropAllowMagicGladiator;
        private Label labelDropAllowDarkLord;
        private TextBox textBoxDropAllowDarkLord;
        private Label labelDropAllowSummoner;
        private TextBox textBoxDropAllowSummoner;
        private Label labelDropAllowRageFighter;
        private TextBox textBoxDropAllowRageFighter;
        private Label labelDropAllowPlayerMinLevel;
        private TextBox textBoxDropAllowPlayerMinLevel;
        private Label labelDropAllowPlayerMaxLevel;
        private TextBox textBoxDropAllowPlayerMaxLevel;
        private Label labelDropAllowMapNumber;
        private TextBox textBoxDropAllowMapNumber;
        private SplitContainer splitContainerDropsItems;
        private TableLayoutPanel tableLayoutPanelDrops;
        private GroupBox groupBoxDropList;
        private TableLayoutPanel tableLayoutPanelDropList;
        private ListBox listBoxDrops;
        private FlowLayoutPanel flowLayoutPanelDropButtons;
        private Button buttonAddDrop;
        private Button buttonRemoveDrop;
        private Button buttonMoveDropUp;
        private Button buttonMoveDropDown;
        private GroupBox groupBoxDropDetails;
        private TableLayoutPanel tableLayoutPanelDropDetails;
        private Label labelDropRate;
        private TextBox textBoxDropRate;
        private Label labelDropCount;
        private TextBox textBoxDropCount;
        private TableLayoutPanel tableLayoutPanelItems;
        private GroupBox groupBoxItemList;
        private TableLayoutPanel tableLayoutPanelItemList;
        private ListBox listBoxItems;
        private FlowLayoutPanel flowLayoutPanelItemButtons;
        private Button buttonAddItem;
        private Button buttonRemoveItem;
        private Button buttonMoveItemUp;
        private Button buttonMoveItemDown;
        private GroupBox groupBoxItemDetails;
        private TableLayoutPanel tableLayoutPanelItemDetails;
        private Label labelItemCat;
        private TextBox textBoxItemCat;
        private Label labelItemIndex;
        private TextBox textBoxItemIndex;
        private Label labelItemMinLevel;
        private TextBox textBoxItemMinLevel;
        private Label labelItemMaxLevel;
        private TextBox textBoxItemMaxLevel;
        private Label labelItemDurability;
        private TextBox textBoxItemDurability;
        private Label labelItemSkill;
        private TextBox textBoxItemSkill;
        private Label labelItemLuck;
        private TextBox textBoxItemLuck;
        private Label labelItemOption;
        private TextBox textBoxItemOption;
        private Label labelItemExc;
        private TextBox textBoxItemExc;
        private Label labelItemSetItem;
        private TextBox textBoxItemSetItem;
        private Label labelItemSocketCount;
        private TextBox textBoxItemSocketCount;
        private Label labelItemElementalItem;
        private TextBox textBoxItemElementalItem;
        private Label labelItemMuunCat;
        private TextBox textBoxItemMuunCat;
        private Label labelItemMuunIndex;
        private TextBox textBoxItemMuunIndex;
        private Label labelItemKindA;
        private TextBox textBoxItemKindA;
        private Label labelItemDropRate;
        private TextBox textBoxItemDropRate;
        private Label labelItemDuration;
        private TextBox textBoxItemDuration;
    }
}
