namespace PDFApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点2");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点3");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点4");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("节点5");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("节点0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("节点6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("节点7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("节点8");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("节点9");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("节点10");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("节点1", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            CCWin.CmSysButton cmSysButton1 = new CCWin.CmSysButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.skinToolStrip2 = new CCWin.SkinControl.SkinToolStrip();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.tsbAddBook = new System.Windows.Forms.ToolStripButton();
            this.tsbEditBook = new System.Windows.Forms.ToolStripButton();
            this.tsbDelBook = new System.Windows.Forms.ToolStripButton();
            this.tsbPicsManager = new System.Windows.Forms.ToolStripButton();
            this.tsbExportPDF = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.layoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLeft = new System.Windows.Forms.Panel();
            this.tvMain = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSearch = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.skinToolStrip2.SuspendLayout();
            this.layoutPanelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.pLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "hover_360MobileMgr1.png");
            this.imageList.Images.SetKeyName(1, "ico_AdvTools.png");
            this.imageList.Images.SetKeyName(2, "ico_diannaomenzhen.png");
            this.imageList.Images.SetKeyName(3, "ico_dsmain.png");
            this.imageList.Images.SetKeyName(4, "ico_Examine.png");
            this.imageList.Images.SetKeyName(5, "ico_expert.png");
            this.imageList.Images.SetKeyName(6, "ico_rescue.png");
            this.imageList.Images.SetKeyName(7, "ico_softmgr.png");
            this.imageList.Images.SetKeyName(8, "ico_SpeedupOpt.png");
            this.imageList.Images.SetKeyName(9, "ico_SysRepair.png");
            this.imageList.Images.SetKeyName(10, "ico_TraceCleaner.png");
            this.imageList.Images.SetKeyName(11, "ico_VulRepair.png");
            // 
            // skinToolStrip2
            // 
            this.skinToolStrip2.Arrow = System.Drawing.Color.White;
            this.skinToolStrip2.AutoSize = false;
            this.skinToolStrip2.Back = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BackRadius = 4;
            this.skinToolStrip2.BackRectangle = new System.Drawing.Rectangle(5, 5, 5, 5);
            this.skinToolStrip2.Base = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BaseFore = System.Drawing.SystemColors.ButtonHighlight;
            this.skinToolStrip2.BaseForeAnamorphosis = false;
            this.skinToolStrip2.BaseForeAnamorphosisBorder = 4;
            this.skinToolStrip2.BaseForeAnamorphosisColor = System.Drawing.Color.Black;
            this.skinToolStrip2.BaseForeOffset = new System.Drawing.Point(3, 6);
            this.skinToolStrip2.BaseHoverFore = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.skinToolStrip2.BaseItemAnamorphosis = false;
            this.skinToolStrip2.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.skinToolStrip2.BaseItemBorderShow = false;
            this.skinToolStrip2.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip2.BaseItemDown")));
            this.skinToolStrip2.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinToolStrip2.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip2.BaseItemMouse")));
            this.skinToolStrip2.BaseItemPressed = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BaseItemRadius = 2;
            this.skinToolStrip2.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinToolStrip2.BaseItemSplitter = System.Drawing.Color.Transparent;
            this.skinToolStrip2.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStrip2.Fore = System.Drawing.Color.White;
            this.skinToolStrip2.GripMargin = new System.Windows.Forms.Padding(0);
            this.skinToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.skinToolStrip2.HoverFore = System.Drawing.Color.White;
            this.skinToolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.skinToolStrip2.ItemAnamorphosis = false;
            this.skinToolStrip2.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemBorderShow = false;
            this.skinToolStrip2.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemRadius = 1;
            this.skinToolStrip2.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripButton12,
            this.toolStripButton13,
            this.tsbAddBook,
            this.tsbEditBook,
            this.tsbDelBook,
            this.tsbPicsManager,
            this.tsbExportPDF,
            this.tsbPrint});
            this.skinToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.skinToolStrip2.Location = new System.Drawing.Point(4, 26);
            this.skinToolStrip2.Name = "skinToolStrip2";
            this.skinToolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.skinToolStrip2.RadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinToolStrip2.Size = new System.Drawing.Size(1107, 76);
            this.skinToolStrip2.SkinAllColor = true;
            this.skinToolStrip2.TabIndex = 179;
            this.skinToolStrip2.Text = "今天";
            this.skinToolStrip2.TitleAnamorphosis = false;
            this.skinToolStrip2.TitleColor = System.Drawing.SystemColors.HighlightText;
            this.skinToolStrip2.TitleRadius = 4;
            this.skinToolStrip2.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.AutoSize = false;
            this.toolStripButton10.AutoToolTip = false;
            this.toolStripButton10.ForeColor = System.Drawing.Color.White;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton10.MergeIndex = 0;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(82, 71);
            this.toolStripButton10.Text = "添加一级分类";
            this.toolStripButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.AutoSize = false;
            this.toolStripButton11.AutoToolTip = false;
            this.toolStripButton11.ForeColor = System.Drawing.Color.White;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton11.MergeIndex = 0;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(82, 71);
            this.toolStripButton11.Text = "删除一级分类";
            this.toolStripButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.AutoSize = false;
            this.toolStripButton12.AutoToolTip = false;
            this.toolStripButton12.ForeColor = System.Drawing.Color.White;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton12.MergeIndex = 0;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(82, 71);
            this.toolStripButton12.Text = "添加二级分类";
            this.toolStripButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.AutoSize = false;
            this.toolStripButton13.AutoToolTip = false;
            this.toolStripButton13.ForeColor = System.Drawing.Color.White;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton13.MergeIndex = 0;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(82, 71);
            this.toolStripButton13.Text = "删除二级分类";
            this.toolStripButton13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbAddBook
            // 
            this.tsbAddBook.AutoSize = false;
            this.tsbAddBook.AutoToolTip = false;
            this.tsbAddBook.ForeColor = System.Drawing.Color.White;
            this.tsbAddBook.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddBook.Image")));
            this.tsbAddBook.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbAddBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddBook.Margin = new System.Windows.Forms.Padding(0);
            this.tsbAddBook.MergeIndex = 0;
            this.tsbAddBook.Name = "tsbAddBook";
            this.tsbAddBook.Size = new System.Drawing.Size(82, 71);
            this.tsbAddBook.Text = "添加书籍";
            this.tsbAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAddBook.Click += new System.EventHandler(this.tsbAddBook_Click);
            // 
            // tsbEditBook
            // 
            this.tsbEditBook.AutoSize = false;
            this.tsbEditBook.AutoToolTip = false;
            this.tsbEditBook.ForeColor = System.Drawing.Color.White;
            this.tsbEditBook.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditBook.Image")));
            this.tsbEditBook.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbEditBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditBook.Margin = new System.Windows.Forms.Padding(0);
            this.tsbEditBook.MergeIndex = 0;
            this.tsbEditBook.Name = "tsbEditBook";
            this.tsbEditBook.Size = new System.Drawing.Size(82, 71);
            this.tsbEditBook.Text = "编辑书籍";
            this.tsbEditBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEditBook.Click += new System.EventHandler(this.tsbEditBook_Click);
            // 
            // tsbDelBook
            // 
            this.tsbDelBook.AutoSize = false;
            this.tsbDelBook.AutoToolTip = false;
            this.tsbDelBook.ForeColor = System.Drawing.Color.White;
            this.tsbDelBook.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelBook.Image")));
            this.tsbDelBook.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbDelBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelBook.Margin = new System.Windows.Forms.Padding(0);
            this.tsbDelBook.MergeIndex = 0;
            this.tsbDelBook.Name = "tsbDelBook";
            this.tsbDelBook.Size = new System.Drawing.Size(82, 71);
            this.tsbDelBook.Text = "删除书籍";
            this.tsbDelBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDelBook.Click += new System.EventHandler(this.tsbDelBook_Click);
            // 
            // tsbPicsManager
            // 
            this.tsbPicsManager.AutoSize = false;
            this.tsbPicsManager.AutoToolTip = false;
            this.tsbPicsManager.ForeColor = System.Drawing.Color.White;
            this.tsbPicsManager.Image = ((System.Drawing.Image)(resources.GetObject("tsbPicsManager.Image")));
            this.tsbPicsManager.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbPicsManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPicsManager.Margin = new System.Windows.Forms.Padding(0);
            this.tsbPicsManager.MergeIndex = 0;
            this.tsbPicsManager.Name = "tsbPicsManager";
            this.tsbPicsManager.Size = new System.Drawing.Size(82, 71);
            this.tsbPicsManager.Text = "导入图片";
            this.tsbPicsManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPicsManager.Click += new System.EventHandler(this.tsbPicsManager_Click);
            // 
            // tsbExportPDF
            // 
            this.tsbExportPDF.AutoSize = false;
            this.tsbExportPDF.AutoToolTip = false;
            this.tsbExportPDF.BackColor = System.Drawing.Color.White;
            this.tsbExportPDF.CheckOnClick = true;
            this.tsbExportPDF.ForeColor = System.Drawing.Color.White;
            this.tsbExportPDF.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportPDF.Image")));
            this.tsbExportPDF.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbExportPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportPDF.Margin = new System.Windows.Forms.Padding(0);
            this.tsbExportPDF.MergeIndex = 0;
            this.tsbExportPDF.Name = "tsbExportPDF";
            this.tsbExportPDF.Size = new System.Drawing.Size(82, 71);
            this.tsbExportPDF.Text = "导出PDF";
            this.tsbExportPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExportPDF.Click += new System.EventHandler(this.tsbExportPDF_Click);
            // 
            // tsbPrint
            // 
            this.tsbPrint.AutoSize = false;
            this.tsbPrint.AutoToolTip = false;
            this.tsbPrint.BackColor = System.Drawing.Color.White;
            this.tsbPrint.CheckOnClick = true;
            this.tsbPrint.ForeColor = System.Drawing.Color.White;
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Margin = new System.Windows.Forms.Padding(0);
            this.tsbPrint.MergeIndex = 0;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(82, 71);
            this.tsbPrint.Text = "打印表单";
            this.tsbPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // layoutPanelMain
            // 
            this.layoutPanelMain.ColumnCount = 2;
            this.layoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.layoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanelMain.Controls.Add(this.panel2, 1, 1);
            this.layoutPanelMain.Controls.Add(this.pLeft, 0, 0);
            this.layoutPanelMain.Controls.Add(this.panel1, 1, 0);
            this.layoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanelMain.Location = new System.Drawing.Point(4, 102);
            this.layoutPanelMain.Name = "layoutPanelMain";
            this.layoutPanelMain.RowCount = 3;
            this.layoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.layoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanelMain.Size = new System.Drawing.Size(1107, 712);
            this.layoutPanelMain.TabIndex = 180;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridViewX1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.layoutPanelMain.SetRowSpan(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(907, 682);
            this.panel2.TabIndex = 3;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewX1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowHeadersVisible = false;
            this.dataGridViewX1.RowTemplate.Height = 23;
            this.dataGridViewX1.Size = new System.Drawing.Size(907, 682);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "序号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "编号";
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "名称";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "分类";
            this.Column7.Name = "Column7";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "页数";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "出版单位";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "设计单位";
            this.Column5.Name = "Column5";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "日期";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "期限";
            this.Column9.Name = "Column9";
            // 
            // pLeft
            // 
            this.pLeft.BackColor = System.Drawing.Color.White;
            this.pLeft.Controls.Add(this.tvMain);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLeft.Location = new System.Drawing.Point(0, 0);
            this.pLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pLeft.Name = "pLeft";
            this.layoutPanelMain.SetRowSpan(this.pLeft, 3);
            this.pLeft.Size = new System.Drawing.Size(200, 712);
            this.pLeft.TabIndex = 1;
            // 
            // tvMain
            // 
            this.tvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMain.ImageIndex = 0;
            this.tvMain.ImageList = this.imageList;
            this.tvMain.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tvMain.ItemHeight = 32;
            this.tvMain.Location = new System.Drawing.Point(0, 0);
            this.tvMain.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.tvMain.Name = "tvMain";
            treeNode1.Name = "节点2";
            treeNode1.Text = "节点2";
            treeNode2.Name = "节点3";
            treeNode2.Text = "节点3";
            treeNode3.Name = "节点4";
            treeNode3.Text = "节点4";
            treeNode4.Name = "节点5";
            treeNode4.Text = "节点5";
            treeNode5.Name = "节点0";
            treeNode5.Text = "节点0";
            treeNode6.Name = "节点6";
            treeNode6.Text = "节点6";
            treeNode7.Name = "节点7";
            treeNode7.Text = "节点7";
            treeNode8.Name = "节点8";
            treeNode8.Text = "节点8";
            treeNode9.Name = "节点9";
            treeNode9.Text = "节点9";
            treeNode10.Name = "节点10";
            treeNode10.Text = "节点10";
            treeNode11.Name = "节点1";
            treeNode11.Text = "节点1";
            this.tvMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode11});
            this.tvMain.SelectedImageIndex = 0;
            this.tvMain.Size = new System.Drawing.Size(200, 712);
            this.tvMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btSearch);
            this.panel1.Controls.Add(this.textBoxX1);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.panel1.Size = new System.Drawing.Size(907, 30);
            this.panel1.TabIndex = 2;
            // 
            // btSearch
            // 
            this.btSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSearch.Location = new System.Drawing.Point(182, 4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSearch.TabIndex = 2;
            this.btSearch.Text = "查询";
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(66, 5);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(100, 21);
            this.textBoxX1.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(7, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "关键字：";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackShade = false;
            this.CanResize = false;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaptionHeight = 22;
            this.ClientSize = new System.Drawing.Size(1115, 818);
            this.CloseBoxSize = new System.Drawing.Size(27, 22);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.Controls.Add(this.layoutPanelMain);
            this.Controls.Add(this.skinToolStrip2);
            this.EffectBack = System.Drawing.Color.Black;
            this.EffectCaption = CCWin.TitleType.Title;
            this.EffectWidth = 0;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaxDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxDownBack")));
            this.MaxMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxMouseBack")));
            this.MaxNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxNormlBack")));
            this.MaxSize = new System.Drawing.Size(27, 22);
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniMouseBack")));
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.MiniSize = new System.Drawing.Size(27, 22);
            this.Name = "MainForm";
            this.Radius = 1;
            this.RestoreDownBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreDownBack")));
            this.RestoreMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreMouseBack")));
            this.RestoreNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreNormlBack")));
            this.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.SkinOpacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            cmSysButton1.Bounds = new System.Drawing.Rectangle(1001, 0, 27, 22);
            cmSysButton1.BoxState = CCWin.ControlBoxState.Normal;
            cmSysButton1.Location = new System.Drawing.Point(1001, 0);
            cmSysButton1.Name = "SysTool";
            cmSysButton1.OwnerForm = this;
            cmSysButton1.Size = new System.Drawing.Size(27, 22);
            cmSysButton1.SysButtonDown = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonDown")));
            cmSysButton1.SysButtonMouse = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonMouse")));
            cmSysButton1.SysButtonNorml = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonNorml")));
            cmSysButton1.ToolTip = "主菜单";
            this.SysButtonItems.AddRange(new CCWin.CmSysButton[] {
            cmSysButton1});
            this.Text = "测试程序";
            this.TitleColor = System.Drawing.Color.White;
            this.TitleOffset = new System.Drawing.Point(13, 4);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.skinToolStrip2.ResumeLayout(false);
            this.skinToolStrip2.PerformLayout();
            this.layoutPanelMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.pLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton tsbAddBook;
        private System.Windows.Forms.ToolStripButton tsbEditBook;
        private System.Windows.Forms.ToolStripButton tsbDelBook;
        private System.Windows.Forms.ToolStripButton tsbPicsManager;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.TableLayoutPanel layoutPanelMain;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView tvMain;
        private DevComponents.DotNetBar.ButtonX btSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ToolStripButton tsbExportPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

