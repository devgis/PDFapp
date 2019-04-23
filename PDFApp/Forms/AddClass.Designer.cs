namespace PDFApp.Forms
{
    partial class AddClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClass));
            CCWin.CmSysButton cmSysButton1 = new CCWin.CmSysButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.skinToolStrip2 = new CCWin.SkinControl.SkinToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.layoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.skinToolStrip2.SuspendLayout();
            this.layoutPanelMain.SuspendLayout();
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
            this.skinToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            this.tsbSave});
            this.skinToolStrip2.Location = new System.Drawing.Point(4, 274);
            this.skinToolStrip2.Name = "skinToolStrip2";
            this.skinToolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.skinToolStrip2.RadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinToolStrip2.Size = new System.Drawing.Size(492, 76);
            this.skinToolStrip2.SkinAllColor = true;
            this.skinToolStrip2.TabIndex = 179;
            this.skinToolStrip2.Text = "今天";
            this.skinToolStrip2.TitleAnamorphosis = false;
            this.skinToolStrip2.TitleColor = System.Drawing.SystemColors.HighlightText;
            this.skinToolStrip2.TitleRadius = 4;
            this.skinToolStrip2.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            // 
            // tsbSave
            // 
            this.tsbSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSave.AutoSize = false;
            this.tsbSave.AutoToolTip = false;
            this.tsbSave.ForeColor = System.Drawing.Color.White;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Margin = new System.Windows.Forms.Padding(0);
            this.tsbSave.MergeIndex = 0;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(82, 71);
            this.tsbSave.Text = "保存";
            this.tsbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // layoutPanelMain
            // 
            this.layoutPanelMain.ColumnCount = 4;
            this.layoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.layoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.layoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelMain.Controls.Add(this.labelX1, 1, 1);
            this.layoutPanelMain.Controls.Add(this.textBoxX1, 2, 1);
            this.layoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanelMain.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.layoutPanelMain.Location = new System.Drawing.Point(4, 26);
            this.layoutPanelMain.Name = "layoutPanelMain";
            this.layoutPanelMain.RowCount = 3;
            this.layoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelMain.Size = new System.Drawing.Size(492, 248);
            this.layoutPanelMain.TabIndex = 180;
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxX1.Location = new System.Drawing.Point(199, 112);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(194, 23);
            this.textBoxX1.TabIndex = 14;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Location = new System.Drawing.Point(99, 112);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(94, 24);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "分类名称";
            // 
            // AddClass
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
            this.ClientSize = new System.Drawing.Size(500, 354);
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
            this.MaximizeBox = false;
            this.MaxMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxMouseBack")));
            this.MaxNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxNormlBack")));
            this.MaxSize = new System.Drawing.Size(27, 22);
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniMouseBack")));
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.MiniSize = new System.Drawing.Size(27, 22);
            this.Name = "AddClass";
            this.Radius = 1;
            this.RestoreDownBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreDownBack")));
            this.RestoreMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreMouseBack")));
            this.RestoreNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreNormlBack")));
            this.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.SkinOpacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            cmSysButton1.Bounds = new System.Drawing.Rectangle(413, 0, 27, 22);
            cmSysButton1.BoxState = CCWin.ControlBoxState.Normal;
            cmSysButton1.Location = new System.Drawing.Point(413, 0);
            cmSysButton1.Name = "SysTool";
            cmSysButton1.OwnerForm = this;
            cmSysButton1.Size = new System.Drawing.Size(27, 22);
            cmSysButton1.SysButtonDown = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonDown")));
            cmSysButton1.SysButtonMouse = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonMouse")));
            cmSysButton1.SysButtonNorml = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonNorml")));
            cmSysButton1.ToolTip = "主菜单";
            this.SysButtonItems.AddRange(new CCWin.CmSysButton[] {
            cmSysButton1});
            this.Text = "添加分类";
            this.TitleColor = System.Drawing.Color.White;
            this.TitleOffset = new System.Drawing.Point(13, 4);
            this.skinToolStrip2.ResumeLayout(false);
            this.skinToolStrip2.PerformLayout();
            this.layoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip2;
        private System.Windows.Forms.TableLayoutPanel layoutPanelMain;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}

