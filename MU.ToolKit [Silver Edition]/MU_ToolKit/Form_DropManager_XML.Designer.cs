namespace MU_ToolKit
{
    partial class Form_DropManager_XML
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelMonsters = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelDropUseRate = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDropUseRate = new System.Windows.Forms.Label();
            this.textBoxDropUseRate = new System.Windows.Forms.TextBox();
            this.dataGridViewMonsters = new System.Windows.Forms.DataGridView();
            this.columnMonsterIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMonsterMinLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMonsterMaxLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMonsterMapNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMonsterItemRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMonsterItemCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMonsterCoinReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMonsterCoinType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMonsterCoinValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMonsterPlayerMinLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMonsterPlayerMaxLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanelMonsterButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddMonster = new System.Windows.Forms.Button();
            this.buttonRemoveMonster = new System.Windows.Forms.Button();
            this.tableLayoutPanelItems = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.columnItemCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemMinLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemMaxLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemDurability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemSkill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemLuck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemOption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemExc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemSetItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemSocketCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemElementalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemMuunCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemMuunIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemDropRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanelItemButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tableLayoutPanelMonsters.SuspendLayout();
            this.flowLayoutPanelDropUseRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonsters)).BeginInit();
            this.flowLayoutPanelMonsterButtons.SuspendLayout();
            this.tableLayoutPanelItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.flowLayoutPanelItemButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 24);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.tableLayoutPanelMonsters);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tableLayoutPanelItems);
            this.splitContainerMain.Size = new System.Drawing.Size(984, 637);
            this.splitContainerMain.SplitterDistance = 292;
            this.splitContainerMain.TabIndex = 1;
            // 
            // tableLayoutPanelMonsters
            // 
            this.tableLayoutPanelMonsters.ColumnCount = 1;
            this.tableLayoutPanelMonsters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMonsters.Controls.Add(this.flowLayoutPanelDropUseRate, 0, 0);
            this.tableLayoutPanelMonsters.Controls.Add(this.dataGridViewMonsters, 0, 1);
            this.tableLayoutPanelMonsters.Controls.Add(this.flowLayoutPanelMonsterButtons, 0, 2);
            this.tableLayoutPanelMonsters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMonsters.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMonsters.Name = "tableLayoutPanelMonsters";
            this.tableLayoutPanelMonsters.RowCount = 3;
            this.tableLayoutPanelMonsters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMonsters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMonsters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMonsters.Size = new System.Drawing.Size(984, 292);
            this.tableLayoutPanelMonsters.TabIndex = 0;
            // 
            // flowLayoutPanelDropUseRate
            // 
            this.flowLayoutPanelDropUseRate.AutoSize = true;
            this.flowLayoutPanelDropUseRate.Controls.Add(this.labelDropUseRate);
            this.flowLayoutPanelDropUseRate.Controls.Add(this.textBoxDropUseRate);
            this.flowLayoutPanelDropUseRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDropUseRate.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelDropUseRate.Name = "flowLayoutPanelDropUseRate";
            this.flowLayoutPanelDropUseRate.Size = new System.Drawing.Size(978, 26);
            this.flowLayoutPanelDropUseRate.TabIndex = 0;
            // 
            // labelDropUseRate
            // 
            this.labelDropUseRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDropUseRate.AutoSize = true;
            this.labelDropUseRate.Location = new System.Drawing.Point(3, 6);
            this.labelDropUseRate.Name = "labelDropUseRate";
            this.labelDropUseRate.Size = new System.Drawing.Size(78, 13);
            this.labelDropUseRate.TabIndex = 0;
            this.labelDropUseRate.Text = "DropUseRate:";
            // 
            // textBoxDropUseRate
            // 
            this.textBoxDropUseRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDropUseRate.Location = new System.Drawing.Point(87, 3);
            this.textBoxDropUseRate.Name = "textBoxDropUseRate";
            this.textBoxDropUseRate.Size = new System.Drawing.Size(120, 20);
            this.textBoxDropUseRate.TabIndex = 1;
            this.textBoxDropUseRate.TextChanged += new System.EventHandler(this.textBoxDropUseRate_TextChanged);
            // 
            // dataGridViewMonsters
            // 
            this.dataGridViewMonsters.AllowUserToAddRows = false;
            this.dataGridViewMonsters.AllowUserToDeleteRows = false;
            this.dataGridViewMonsters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMonsters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonsters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnMonsterIndex,
            this.columnMonsterMinLevel,
            this.columnMonsterMaxLevel,
            this.columnMonsterMapNumber,
            this.columnMonsterItemRate,
            this.columnMonsterItemCount,
            this.columnMonsterCoinReward,
            this.columnMonsterCoinType,
            this.columnMonsterCoinValue,
            this.columnMonsterPlayerMinLevel,
            this.columnMonsterPlayerMaxLevel});
            this.dataGridViewMonsters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMonsters.Location = new System.Drawing.Point(3, 35);
            this.dataGridViewMonsters.MultiSelect = false;
            this.dataGridViewMonsters.Name = "dataGridViewMonsters";
            this.dataGridViewMonsters.RowHeadersVisible = false;
            this.dataGridViewMonsters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMonsters.Size = new System.Drawing.Size(978, 221);
            this.dataGridViewMonsters.TabIndex = 1;
            this.dataGridViewMonsters.SelectionChanged += new System.EventHandler(this.dataGridViewMonsters_SelectionChanged);
            // 
            // columnMonsterIndex
            // 
            this.columnMonsterIndex.DataPropertyName = "Index";
            this.columnMonsterIndex.HeaderText = "Index";
            this.columnMonsterIndex.Name = "columnMonsterIndex";
            // 
            // columnMonsterMinLevel
            // 
            this.columnMonsterMinLevel.DataPropertyName = "MonsterMinLevel";
            this.columnMonsterMinLevel.HeaderText = "Monster Min Level";
            this.columnMonsterMinLevel.Name = "columnMonsterMinLevel";
            // 
            // columnMonsterMaxLevel
            // 
            this.columnMonsterMaxLevel.DataPropertyName = "MonsterMaxLevel";
            this.columnMonsterMaxLevel.HeaderText = "Monster Max Level";
            this.columnMonsterMaxLevel.Name = "columnMonsterMaxLevel";
            // 
            // columnMonsterMapNumber
            // 
            this.columnMonsterMapNumber.DataPropertyName = "MapNumber";
            this.columnMonsterMapNumber.HeaderText = "Map";
            this.columnMonsterMapNumber.Name = "columnMonsterMapNumber";
            // 
            // columnMonsterItemRate
            // 
            this.columnMonsterItemRate.DataPropertyName = "ItemRate";
            this.columnMonsterItemRate.HeaderText = "Item Rate";
            this.columnMonsterItemRate.Name = "columnMonsterItemRate";
            // 
            // columnMonsterItemCount
            // 
            this.columnMonsterItemCount.DataPropertyName = "ItemCount";
            this.columnMonsterItemCount.HeaderText = "Item Count";
            this.columnMonsterItemCount.Name = "columnMonsterItemCount";
            // 
            // columnMonsterCoinReward
            // 
            this.columnMonsterCoinReward.DataPropertyName = "CoinReward";
            this.columnMonsterCoinReward.HeaderText = "Coin Reward";
            this.columnMonsterCoinReward.Name = "columnMonsterCoinReward";
            // 
            // columnMonsterCoinType
            // 
            this.columnMonsterCoinType.DataPropertyName = "CoinType";
            this.columnMonsterCoinType.HeaderText = "Coin Type";
            this.columnMonsterCoinType.Name = "columnMonsterCoinType";
            // 
            // columnMonsterCoinValue
            // 
            this.columnMonsterCoinValue.DataPropertyName = "CoinValue";
            this.columnMonsterCoinValue.HeaderText = "Coin Value";
            this.columnMonsterCoinValue.Name = "columnMonsterCoinValue";
            // 
            // columnMonsterPlayerMinLevel
            // 
            this.columnMonsterPlayerMinLevel.DataPropertyName = "PlayerMinLevel";
            this.columnMonsterPlayerMinLevel.HeaderText = "Player Min Level";
            this.columnMonsterPlayerMinLevel.Name = "columnMonsterPlayerMinLevel";
            // 
            // columnMonsterPlayerMaxLevel
            // 
            this.columnMonsterPlayerMaxLevel.DataPropertyName = "PlayerMaxLevel";
            this.columnMonsterPlayerMaxLevel.HeaderText = "Player Max Level";
            this.columnMonsterPlayerMaxLevel.Name = "columnMonsterPlayerMaxLevel";
            // 
            // flowLayoutPanelMonsterButtons
            // 
            this.flowLayoutPanelMonsterButtons.AutoSize = true;
            this.flowLayoutPanelMonsterButtons.Controls.Add(this.buttonAddMonster);
            this.flowLayoutPanelMonsterButtons.Controls.Add(this.buttonRemoveMonster);
            this.flowLayoutPanelMonsterButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMonsterButtons.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flowLayoutPanelMonsterButtons.Location = new System.Drawing.Point(3, 262);
            this.flowLayoutPanelMonsterButtons.Name = "flowLayoutPanelMonsterButtons";
            this.flowLayoutPanelMonsterButtons.Size = new System.Drawing.Size(978, 27);
            this.flowLayoutPanelMonsterButtons.TabIndex = 2;
            this.flowLayoutPanelMonsterButtons.WrapContents = false;
            // 
            // buttonAddMonster
            // 
            this.buttonAddMonster.AutoSize = true;
            this.buttonAddMonster.Location = new System.Drawing.Point(3, 3);
            this.buttonAddMonster.Name = "buttonAddMonster";
            this.buttonAddMonster.Size = new System.Drawing.Size(88, 23);
            this.buttonAddMonster.TabIndex = 0;
            this.buttonAddMonster.Text = "Add Monster";
            this.buttonAddMonster.UseVisualStyleBackColor = true;
            this.buttonAddMonster.Click += new System.EventHandler(this.buttonAddMonster_Click);
            // 
            // buttonRemoveMonster
            // 
            this.buttonRemoveMonster.AutoSize = true;
            this.buttonRemoveMonster.Location = new System.Drawing.Point(97, 3);
            this.buttonRemoveMonster.Name = "buttonRemoveMonster";
            this.buttonRemoveMonster.Size = new System.Drawing.Size(106, 23);
            this.buttonRemoveMonster.TabIndex = 1;
            this.buttonRemoveMonster.Text = "Remove Monster";
            this.buttonRemoveMonster.UseVisualStyleBackColor = true;
            this.buttonRemoveMonster.Click += new System.EventHandler(this.buttonRemoveMonster_Click);
            // 
            // tableLayoutPanelItems
            // 
            this.tableLayoutPanelItems.ColumnCount = 1;
            this.tableLayoutPanelItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelItems.Controls.Add(this.dataGridViewItems, 0, 0);
            this.tableLayoutPanelItems.Controls.Add(this.flowLayoutPanelItemButtons, 0, 1);
            this.tableLayoutPanelItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelItems.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelItems.Name = "tableLayoutPanelItems";
            this.tableLayoutPanelItems.RowCount = 2;
            this.tableLayoutPanelItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelItems.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelItems.Size = new System.Drawing.Size(984, 341);
            this.tableLayoutPanelItems.TabIndex = 0;
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnItemCat,
            this.columnItemIndex,
            this.columnItemMinLevel,
            this.columnItemMaxLevel,
            this.columnItemDurability,
            this.columnItemSkill,
            this.columnItemLuck,
            this.columnItemOption,
            this.columnItemExc,
            this.columnItemSetItem,
            this.columnItemSocketCount,
            this.columnItemElementalItem,
            this.columnItemMuunCat,
            this.columnItemMuunIndex,
            this.columnItemDropRate,
            this.columnItemDuration});
            this.dataGridViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewItems.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewItems.MultiSelect = false;
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowHeadersVisible = false;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(978, 303);
            this.dataGridViewItems.TabIndex = 0;
            // 
            // columnItemCat
            // 
            this.columnItemCat.DataPropertyName = "Cat";
            this.columnItemCat.HeaderText = "Cat";
            this.columnItemCat.Name = "columnItemCat";
            // 
            // columnItemIndex
            // 
            this.columnItemIndex.DataPropertyName = "Index";
            this.columnItemIndex.HeaderText = "Index";
            this.columnItemIndex.Name = "columnItemIndex";
            // 
            // columnItemMinLevel
            // 
            this.columnItemMinLevel.DataPropertyName = "ItemMinLevel";
            this.columnItemMinLevel.HeaderText = "Item Min Level";
            this.columnItemMinLevel.Name = "columnItemMinLevel";
            // 
            // columnItemMaxLevel
            // 
            this.columnItemMaxLevel.DataPropertyName = "ItemMaxLevel";
            this.columnItemMaxLevel.HeaderText = "Item Max Level";
            this.columnItemMaxLevel.Name = "columnItemMaxLevel";
            // 
            // columnItemDurability
            // 
            this.columnItemDurability.DataPropertyName = "Durability";
            this.columnItemDurability.HeaderText = "Durability";
            this.columnItemDurability.Name = "columnItemDurability";
            // 
            // columnItemSkill
            // 
            this.columnItemSkill.DataPropertyName = "Skill";
            this.columnItemSkill.HeaderText = "Skill";
            this.columnItemSkill.Name = "columnItemSkill";
            // 
            // columnItemLuck
            // 
            this.columnItemLuck.DataPropertyName = "Luck";
            this.columnItemLuck.HeaderText = "Luck";
            this.columnItemLuck.Name = "columnItemLuck";
            // 
            // columnItemOption
            // 
            this.columnItemOption.DataPropertyName = "Option";
            this.columnItemOption.HeaderText = "Option";
            this.columnItemOption.Name = "columnItemOption";
            // 
            // columnItemExc
            // 
            this.columnItemExc.DataPropertyName = "Exc";
            this.columnItemExc.HeaderText = "Exc";
            this.columnItemExc.Name = "columnItemExc";
            // 
            // columnItemSetItem
            // 
            this.columnItemSetItem.DataPropertyName = "SetItem";
            this.columnItemSetItem.HeaderText = "Set Item";
            this.columnItemSetItem.Name = "columnItemSetItem";
            // 
            // columnItemSocketCount
            // 
            this.columnItemSocketCount.DataPropertyName = "SocketCount";
            this.columnItemSocketCount.HeaderText = "Socket Count";
            this.columnItemSocketCount.Name = "columnItemSocketCount";
            // 
            // columnItemElementalItem
            // 
            this.columnItemElementalItem.DataPropertyName = "ElementalItem";
            this.columnItemElementalItem.HeaderText = "Elemental";
            this.columnItemElementalItem.Name = "columnItemElementalItem";
            // 
            // columnItemMuunCat
            // 
            this.columnItemMuunCat.DataPropertyName = "MuunEvolutionItemCat";
            this.columnItemMuunCat.HeaderText = "Muun Cat";
            this.columnItemMuunCat.Name = "columnItemMuunCat";
            // 
            // columnItemMuunIndex
            // 
            this.columnItemMuunIndex.DataPropertyName = "MuunEvolutionItemIndex";
            this.columnItemMuunIndex.HeaderText = "Muun Index";
            this.columnItemMuunIndex.Name = "columnItemMuunIndex";
            // 
            // columnItemDropRate
            // 
            this.columnItemDropRate.DataPropertyName = "DropRate";
            this.columnItemDropRate.HeaderText = "Drop Rate";
            this.columnItemDropRate.Name = "columnItemDropRate";
            // 
            // columnItemDuration
            // 
            this.columnItemDuration.DataPropertyName = "Duration";
            this.columnItemDuration.HeaderText = "Duration";
            this.columnItemDuration.Name = "columnItemDuration";
            // 
            // flowLayoutPanelItemButtons
            // 
            this.flowLayoutPanelItemButtons.AutoSize = true;
            this.flowLayoutPanelItemButtons.Controls.Add(this.buttonAddItem);
            this.flowLayoutPanelItemButtons.Controls.Add(this.buttonRemoveItem);
            this.flowLayoutPanelItemButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelItemButtons.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flowLayoutPanelItemButtons.Location = new System.Drawing.Point(3, 312);
            this.flowLayoutPanelItemButtons.Name = "flowLayoutPanelItemButtons";
            this.flowLayoutPanelItemButtons.Size = new System.Drawing.Size(978, 26);
            this.flowLayoutPanelItemButtons.TabIndex = 1;
            this.flowLayoutPanelItemButtons.WrapContents = false;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.AutoSize = true;
            this.buttonAddItem.Location = new System.Drawing.Point(3, 3);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(63, 23);
            this.buttonAddItem.TabIndex = 0;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.AutoSize = true;
            this.buttonRemoveItem.Location = new System.Drawing.Point(72, 3);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(81, 23);
            this.buttonRemoveItem.TabIndex = 1;
            this.buttonRemoveItem.Text = "Remove Item";
            this.buttonRemoveItem.UseVisualStyleBackColor = true;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // Form_DropManager_XML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form_DropManager_XML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MU DropManager Editor (XML)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_DropManager_XML_FormClosed);
            this.Load += new System.EventHandler(this.Form_DropManager_XML_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tableLayoutPanelMonsters.ResumeLayout(false);
            this.tableLayoutPanelMonsters.PerformLayout();
            this.flowLayoutPanelDropUseRate.ResumeLayout(false);
            this.flowLayoutPanelDropUseRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonsters)).EndInit();
            this.flowLayoutPanelMonsterButtons.ResumeLayout(false);
            this.flowLayoutPanelMonsterButtons.PerformLayout();
            this.tableLayoutPanelItems.ResumeLayout(false);
            this.tableLayoutPanelItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.flowLayoutPanelItemButtons.ResumeLayout(false);
            this.flowLayoutPanelItemButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMonsters;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDropUseRate;
        private System.Windows.Forms.Label labelDropUseRate;
        private System.Windows.Forms.TextBox textBoxDropUseRate;
        private System.Windows.Forms.DataGridView dataGridViewMonsters;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMonsterButtons;
        private System.Windows.Forms.Button buttonAddMonster;
        private System.Windows.Forms.Button buttonRemoveMonster;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelItems;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelItemButtons;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMonsterIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMonsterMinLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMonsterMaxLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMonsterMapNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMonsterItemRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMonsterItemCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMonsterCoinReward;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMonsterCoinType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMonsterCoinValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMonsterPlayerMinLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMonsterPlayerMaxLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemMinLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemMaxLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemDurability;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemSkill;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemLuck;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemOption;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemExc;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemSetItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemSocketCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemElementalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemMuunCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemMuunIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemDropRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemDuration;
    }
}
