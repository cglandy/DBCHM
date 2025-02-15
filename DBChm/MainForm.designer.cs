﻿namespace DBCHM
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.tlTip = new System.Windows.Forms.ToolTip(this.components);
            this.TxtSearchWords = new System.Windows.Forms.TextBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.tabLayoutPnl = new System.Windows.Forms.TableLayoutPanel();
            this.mainPnl = new System.Windows.Forms.Panel();
            this.treePnl = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeDB = new DBCHM.TreeViewEnhanced();
            this.lblTongJi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CkAll = new System.Windows.Forms.CheckBox();
            this.CkReverse = new System.Windows.Forms.CheckBox();
            this.lblSelectRes = new System.Windows.Forms.Label();
            this.gpxHandle = new System.Windows.Forms.GroupBox();
            this.codePnl = new System.Windows.Forms.Panel();
            this.txtCode = new ICSharpCode.TextEditor.TextEditorControl();
            this.pizhuPnl = new System.Windows.Forms.Panel();
            this.gpCurrTable = new System.Windows.Forms.GroupBox();
            this.labCurrTabComment = new System.Windows.Forms.Label();
            this.TxtCurrTabComment = new System.Windows.Forms.TextBox();
            this.LabCurrTabName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GpColumns = new System.Windows.Forms.GroupBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.GV_ColComments = new System.Windows.Forms.DataGridView();
            this.ColXuHao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSaveGridData = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.RibbonTabContainer = new System.Windows.Forms.TabControl();
            this.tpfile = new System.Windows.Forms.TabPage();
            this.ribbonPageFile = new System.Windows.Forms.ToolStrip();
            this.tsbConnect = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbBuild = new System.Windows.Forms.ToolStripButton();
            this.tsWordExp = new System.Windows.Forms.ToolStripButton();
            this.tsExcelExp = new System.Windows.Forms.ToolStripButton();
            this.tsPdfExp = new System.Windows.Forms.ToolStripButton();
            this.tsHtmlExp = new System.Windows.Forms.ToolStripButton();
            this.tsXmlExp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.loadConfig = new System.Windows.Forms.ToolStripButton();
            this.tptool = new System.Windows.Forms.TabPage();
            this.tsbPDMUpload = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.apabout = new System.Windows.Forms.TabPage();
            this.ribbonPageAbout = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.tabLayoutPnl.SuspendLayout();
            this.mainPnl.SuspendLayout();
            this.treePnl.SuspendLayout();
            this.gpxHandle.SuspendLayout();
            this.codePnl.SuspendLayout();
            this.pizhuPnl.SuspendLayout();
            this.gpCurrTable.SuspendLayout();
            this.GpColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ColComments)).BeginInit();
            this.RibbonTabContainer.SuspendLayout();
            this.tpfile.SuspendLayout();
            this.ribbonPageFile.SuspendLayout();
            this.tptool.SuspendLayout();
            this.tsbPDMUpload.SuspendLayout();
            this.apabout.SuspendLayout();
            this.ribbonPageAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "folder");
            this.imgList.Images.SetKeyName(1, "table");
            this.imgList.Images.SetKeyName(2, "view");
            this.imgList.Images.SetKeyName(3, "proc");
            this.imgList.Images.SetKeyName(4, "func");
            // 
            // tlTip
            // 
            this.tlTip.AutoPopDelay = 5000;
            this.tlTip.InitialDelay = 100;
            this.tlTip.IsBalloon = true;
            this.tlTip.ReshowDelay = 100;
            this.tlTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tlTip.ToolTipTitle = "提示";
            // 
            // TxtSearchWords
            // 
            this.TxtSearchWords.Location = new System.Drawing.Point(77, 11);
            this.TxtSearchWords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSearchWords.Name = "TxtSearchWords";
            this.TxtSearchWords.Size = new System.Drawing.Size(293, 25);
            this.TxtSearchWords.TabIndex = 13;
            this.tlTip.SetToolTip(this.TxtSearchWords, "多个关键字搜索用英文逗号(,)隔开！");
            this.TxtSearchWords.TextChanged += new System.EventHandler(this.TxtSearchWords_TextChanged);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(77, 42);
            this.filterTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(247, 25);
            this.filterTextBox.TabIndex = 20;
            this.filterTextBox.Text = "copy,bak,$,2021";
            this.tlTip.SetToolTip(this.filterTextBox, "多个关键字搜索用英文逗号(,)隔开！");
            // 
            // tabLayoutPnl
            // 
            this.tabLayoutPnl.AutoSize = true;
            this.tabLayoutPnl.ColumnCount = 1;
            this.tabLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayoutPnl.Controls.Add(this.mainPnl, 0, 1);
            this.tabLayoutPnl.Controls.Add(this.RibbonTabContainer, 0, 0);
            this.tabLayoutPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayoutPnl.Location = new System.Drawing.Point(0, 0);
            this.tabLayoutPnl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabLayoutPnl.Name = "tabLayoutPnl";
            this.tabLayoutPnl.RowCount = 2;
            this.tabLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tabLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tabLayoutPnl.Size = new System.Drawing.Size(1435, 875);
            this.tabLayoutPnl.TabIndex = 5;
            // 
            // mainPnl
            // 
            this.mainPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPnl.Controls.Add(this.treePnl);
            this.mainPnl.Controls.Add(this.gpxHandle);
            this.mainPnl.Location = new System.Drawing.Point(4, 135);
            this.mainPnl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(1427, 736);
            this.mainPnl.TabIndex = 14;
            // 
            // treePnl
            // 
            this.treePnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treePnl.Controls.Add(this.clearBtn);
            this.treePnl.Controls.Add(this.label4);
            this.treePnl.Controls.Add(this.filterTextBox);
            this.treePnl.Controls.Add(this.label2);
            this.treePnl.Controls.Add(this.treeDB);
            this.treePnl.Controls.Add(this.lblTongJi);
            this.treePnl.Controls.Add(this.label1);
            this.treePnl.Controls.Add(this.CkAll);
            this.treePnl.Controls.Add(this.TxtSearchWords);
            this.treePnl.Controls.Add(this.CkReverse);
            this.treePnl.Controls.Add(this.lblSelectRes);
            this.treePnl.Location = new System.Drawing.Point(4, 0);
            this.treePnl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treePnl.Name = "treePnl";
            this.treePnl.Size = new System.Drawing.Size(432, 736);
            this.treePnl.TabIndex = 20;
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearBtn.Location = new System.Drawing.Point(336, 41);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 28);
            this.clearBtn.TabIndex = 22;
            this.clearBtn.Text = "清空";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "过滤";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 714);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 19;
            // 
            // treeDB
            // 
            this.treeDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeDB.CheckBoxes = true;
            this.treeDB.HideSelection = false;
            this.treeDB.ImageIndex = 0;
            this.treeDB.ImageList = this.imgList;
            this.treeDB.Indent = 16;
            this.treeDB.Location = new System.Drawing.Point(0, 98);
            this.treeDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeDB.Name = "treeDB";
            this.treeDB.SelectedImageIndex = 0;
            this.treeDB.Size = new System.Drawing.Size(427, 612);
            this.treeDB.TabIndex = 18;
            this.treeDB.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeDB_AfterCheck);
            this.treeDB.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDB_AfterSelect);
            // 
            // lblTongJi
            // 
            this.lblTongJi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongJi.AutoSize = true;
            this.lblTongJi.Location = new System.Drawing.Point(7, 714);
            this.lblTongJi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongJi.Name = "lblTongJi";
            this.lblTongJi.Size = new System.Drawing.Size(0, 15);
            this.lblTongJi.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "搜索";
            // 
            // CkAll
            // 
            this.CkAll.AutoSize = true;
            this.CkAll.Location = new System.Drawing.Point(21, 69);
            this.CkAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CkAll.Name = "CkAll";
            this.CkAll.Size = new System.Drawing.Size(59, 19);
            this.CkAll.TabIndex = 15;
            this.CkAll.Text = "全选";
            this.CkAll.UseVisualStyleBackColor = true;
            this.CkAll.CheckedChanged += new System.EventHandler(this.CkAll_CheckedChanged);
            // 
            // CkReverse
            // 
            this.CkReverse.AutoSize = true;
            this.CkReverse.Location = new System.Drawing.Point(93, 70);
            this.CkReverse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CkReverse.Name = "CkReverse";
            this.CkReverse.Size = new System.Drawing.Size(59, 19);
            this.CkReverse.TabIndex = 17;
            this.CkReverse.Text = "反选";
            this.CkReverse.UseVisualStyleBackColor = true;
            this.CkReverse.CheckedChanged += new System.EventHandler(this.CkReverse_CheckedChanged);
            // 
            // lblSelectRes
            // 
            this.lblSelectRes.AutoSize = true;
            this.lblSelectRes.Location = new System.Drawing.Point(255, 71);
            this.lblSelectRes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectRes.Name = "lblSelectRes";
            this.lblSelectRes.Size = new System.Drawing.Size(105, 15);
            this.lblSelectRes.TabIndex = 16;
            this.lblSelectRes.Text = "已选择0个项目";
            // 
            // gpxHandle
            // 
            this.gpxHandle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxHandle.Controls.Add(this.codePnl);
            this.gpxHandle.Controls.Add(this.pizhuPnl);
            this.gpxHandle.Location = new System.Drawing.Point(440, 4);
            this.gpxHandle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpxHandle.Name = "gpxHandle";
            this.gpxHandle.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpxHandle.Size = new System.Drawing.Size(983, 729);
            this.gpxHandle.TabIndex = 21;
            this.gpxHandle.TabStop = false;
            this.gpxHandle.Text = "操作";
            // 
            // codePnl
            // 
            this.codePnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codePnl.Controls.Add(this.txtCode);
            this.codePnl.Location = new System.Drawing.Point(10667, 25);
            this.codePnl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codePnl.Name = "codePnl";
            this.codePnl.Size = new System.Drawing.Size(967, 696);
            this.codePnl.TabIndex = 1;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Highlighting = "SQL";
            this.txtCode.Location = new System.Drawing.Point(17, 16);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.ShowSpaces = true;
            this.txtCode.Size = new System.Drawing.Size(933, 662);
            this.txtCode.TabIndex = 0;
            this.txtCode.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            // 
            // pizhuPnl
            // 
            this.pizhuPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pizhuPnl.Controls.Add(this.gpCurrTable);
            this.pizhuPnl.Controls.Add(this.GpColumns);
            this.pizhuPnl.Location = new System.Drawing.Point(8, 25);
            this.pizhuPnl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pizhuPnl.Name = "pizhuPnl";
            this.pizhuPnl.Size = new System.Drawing.Size(967, 696);
            this.pizhuPnl.TabIndex = 0;
            // 
            // gpCurrTable
            // 
            this.gpCurrTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpCurrTable.Controls.Add(this.labCurrTabComment);
            this.gpCurrTable.Controls.Add(this.TxtCurrTabComment);
            this.gpCurrTable.Controls.Add(this.LabCurrTabName);
            this.gpCurrTable.Controls.Add(this.label3);
            this.gpCurrTable.Location = new System.Drawing.Point(11, 16);
            this.gpCurrTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpCurrTable.Name = "gpCurrTable";
            this.gpCurrTable.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpCurrTable.Size = new System.Drawing.Size(940, 91);
            this.gpCurrTable.TabIndex = 11;
            this.gpCurrTable.TabStop = false;
            this.gpCurrTable.Text = "表批注";
            // 
            // labCurrTabComment
            // 
            this.labCurrTabComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labCurrTabComment.AutoSize = true;
            this.labCurrTabComment.Location = new System.Drawing.Point(265, 52);
            this.labCurrTabComment.Name = "labCurrTabComment";
            this.labCurrTabComment.Size = new System.Drawing.Size(67, 15);
            this.labCurrTabComment.TabIndex = 7;
            this.labCurrTabComment.Text = "表批注：";
            // 
            // TxtCurrTabComment
            // 
            this.TxtCurrTabComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtCurrTabComment.Location = new System.Drawing.Point(339, 49);
            this.TxtCurrTabComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCurrTabComment.Name = "TxtCurrTabComment";
            this.TxtCurrTabComment.Size = new System.Drawing.Size(399, 25);
            this.TxtCurrTabComment.TabIndex = 3;
            // 
            // LabCurrTabName
            // 
            this.LabCurrTabName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LabCurrTabName.AutoSize = true;
            this.LabCurrTabName.Location = new System.Drawing.Point(345, 21);
            this.LabCurrTabName.Name = "LabCurrTabName";
            this.LabCurrTabName.Size = new System.Drawing.Size(0, 15);
            this.LabCurrTabName.TabIndex = 5;
            this.LabCurrTabName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "表名：";
            // 
            // GpColumns
            // 
            this.GpColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpColumns.Controls.Add(this.lblTip);
            this.GpColumns.Controls.Add(this.GV_ColComments);
            this.GpColumns.Controls.Add(this.BtnSaveGridData);
            this.GpColumns.Location = new System.Drawing.Point(11, 112);
            this.GpColumns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GpColumns.Name = "GpColumns";
            this.GpColumns.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GpColumns.Size = new System.Drawing.Size(940, 566);
            this.GpColumns.TabIndex = 10;
            this.GpColumns.TabStop = false;
            this.GpColumns.Text = "列批注";
            // 
            // lblTip
            // 
            this.lblTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTip.Location = new System.Drawing.Point(29, 514);
            this.lblTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(0, 27);
            this.lblTip.TabIndex = 9;
            // 
            // GV_ColComments
            // 
            this.GV_ColComments.AllowUserToAddRows = false;
            this.GV_ColComments.AllowUserToDeleteRows = false;
            this.GV_ColComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GV_ColComments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GV_ColComments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_ColComments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GV_ColComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_ColComments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColXuHao,
            this.ColName,
            this.ColDataType,
            this.ColLength,
            this.ColComment});
            this.GV_ColComments.Location = new System.Drawing.Point(5, 22);
            this.GV_ColComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GV_ColComments.MultiSelect = false;
            this.GV_ColComments.Name = "GV_ColComments";
            this.GV_ColComments.RowHeadersWidth = 51;
            this.GV_ColComments.RowTemplate.Height = 27;
            this.GV_ColComments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GV_ColComments.Size = new System.Drawing.Size(929, 454);
            this.GV_ColComments.TabIndex = 0;
            this.GV_ColComments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_ColComments_CellClick);
            this.GV_ColComments.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GV_ColComments_PreviewKeyDown);
            // 
            // ColXuHao
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColXuHao.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColXuHao.FillWeight = 10F;
            this.ColXuHao.HeaderText = "序号";
            this.ColXuHao.MinimumWidth = 30;
            this.ColXuHao.Name = "ColXuHao";
            this.ColXuHao.ReadOnly = true;
            this.ColXuHao.Width = 66;
            // 
            // ColName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColName.FillWeight = 20F;
            this.ColName.HeaderText = "列名";
            this.ColName.MinimumWidth = 150;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Width = 150;
            // 
            // ColDataType
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColDataType.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColDataType.FillWeight = 23F;
            this.ColDataType.HeaderText = "数据类型";
            this.ColDataType.MinimumWidth = 110;
            this.ColDataType.Name = "ColDataType";
            this.ColDataType.ReadOnly = true;
            this.ColDataType.Width = 110;
            // 
            // ColLength
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColLength.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColLength.FillWeight = 12F;
            this.ColLength.HeaderText = "长度";
            this.ColLength.MinimumWidth = 30;
            this.ColLength.Name = "ColLength";
            this.ColLength.ReadOnly = true;
            this.ColLength.Width = 66;
            // 
            // ColComment
            // 
            this.ColComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColComment.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColComment.FillWeight = 35F;
            this.ColComment.HeaderText = "列批注";
            this.ColComment.MinimumWidth = 320;
            this.ColComment.Name = "ColComment";
            this.ColComment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BtnSaveGridData
            // 
            this.BtnSaveGridData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaveGridData.Location = new System.Drawing.Point(791, 500);
            this.BtnSaveGridData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSaveGridData.Name = "BtnSaveGridData";
            this.BtnSaveGridData.Size = new System.Drawing.Size(131, 42);
            this.BtnSaveGridData.TabIndex = 8;
            this.BtnSaveGridData.Values.Text = "保存";
            this.BtnSaveGridData.Click += new System.EventHandler(this.BtnSaveGridData_Click);
            // 
            // RibbonTabContainer
            // 
            this.RibbonTabContainer.Controls.Add(this.tpfile);
            this.RibbonTabContainer.Controls.Add(this.tptool);
            this.RibbonTabContainer.Controls.Add(this.apabout);
            this.RibbonTabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RibbonTabContainer.ItemSize = new System.Drawing.Size(65, 20);
            this.RibbonTabContainer.Location = new System.Drawing.Point(4, 2);
            this.RibbonTabContainer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RibbonTabContainer.Name = "RibbonTabContainer";
            this.RibbonTabContainer.SelectedIndex = 0;
            this.RibbonTabContainer.Size = new System.Drawing.Size(1427, 127);
            this.RibbonTabContainer.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.RibbonTabContainer.TabIndex = 3;
            this.RibbonTabContainer.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.RibbonTabContainer_Selecting);
            this.RibbonTabContainer.Selected += new System.Windows.Forms.TabControlEventHandler(this.RibbonTabContainer_Selected);
            this.RibbonTabContainer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RibbonTabContainer_MouseClick);
            this.RibbonTabContainer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RibbonTabContainer_MouseDoubleClick);
            // 
            // tpfile
            // 
            this.tpfile.Controls.Add(this.ribbonPageFile);
            this.tpfile.Location = new System.Drawing.Point(4, 24);
            this.tpfile.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tpfile.Name = "tpfile";
            this.tpfile.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tpfile.Size = new System.Drawing.Size(1419, 99);
            this.tpfile.TabIndex = 0;
            this.tpfile.Text = "文件";
            this.tpfile.ToolTipText = "文件";
            // 
            // ribbonPageFile
            // 
            this.ribbonPageFile.BackColor = System.Drawing.SystemColors.Control;
            this.ribbonPageFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ribbonPageFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPageFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbonPageFile.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ribbonPageFile.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.ribbonPageFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConnect,
            this.tsbRefresh,
            this.tsbBuild,
            this.tsWordExp,
            this.tsExcelExp,
            this.tsPdfExp,
            this.tsHtmlExp,
            this.tsXmlExp,
            this.toolStripButton1,
            this.loadConfig});
            this.ribbonPageFile.Location = new System.Drawing.Point(4, 2);
            this.ribbonPageFile.Name = "ribbonPageFile";
            this.ribbonPageFile.Size = new System.Drawing.Size(1411, 95);
            this.ribbonPageFile.TabIndex = 0;
            this.ribbonPageFile.Text = "toolStripFile";
            this.ribbonPageFile.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ribbonPageFile_ItemClicked);
            // 
            // tsbConnect
            // 
            this.tsbConnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbConnect.Image")));
            this.tsbConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnect.Name = "tsbConnect";
            this.tsbConnect.Size = new System.Drawing.Size(77, 92);
            this.tsbConnect.Text = "数据连接";
            this.tsbConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbConnect.Click += new System.EventHandler(this.tsbConnect_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(77, 92);
            this.tsbRefresh.Text = "重新获取";
            this.tsbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // tsbBuild
            // 
            this.tsbBuild.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuild.Image")));
            this.tsbBuild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuild.Name = "tsbBuild";
            this.tsbBuild.Size = new System.Drawing.Size(78, 92);
            this.tsbBuild.Tag = "chm";
            this.tsbBuild.Text = "CHM导出";
            this.tsbBuild.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBuild.Click += new System.EventHandler(this.tsbBuild_Click);
            // 
            // tsWordExp
            // 
            this.tsWordExp.Image = ((System.Drawing.Image)(resources.GetObject("tsWordExp.Image")));
            this.tsWordExp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsWordExp.Name = "tsWordExp";
            this.tsWordExp.Size = new System.Drawing.Size(81, 92);
            this.tsWordExp.Tag = "word";
            this.tsWordExp.Text = "Word导出";
            this.tsWordExp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsWordExp.Click += new System.EventHandler(this.tsbBuild_Click);
            // 
            // tsExcelExp
            // 
            this.tsExcelExp.Image = ((System.Drawing.Image)(resources.GetObject("tsExcelExp.Image")));
            this.tsExcelExp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExcelExp.Name = "tsExcelExp";
            this.tsExcelExp.Size = new System.Drawing.Size(79, 92);
            this.tsExcelExp.Tag = "excel";
            this.tsExcelExp.Text = "Excel导出";
            this.tsExcelExp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsExcelExp.Click += new System.EventHandler(this.tsbBuild_Click);
            // 
            // tsPdfExp
            // 
            this.tsPdfExp.Image = ((System.Drawing.Image)(resources.GetObject("tsPdfExp.Image")));
            this.tsPdfExp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPdfExp.Name = "tsPdfExp";
            this.tsPdfExp.Size = new System.Drawing.Size(71, 92);
            this.tsPdfExp.Tag = "pdf";
            this.tsPdfExp.Text = "PDF导出";
            this.tsPdfExp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsPdfExp.Click += new System.EventHandler(this.tsbBuild_Click);
            // 
            // tsHtmlExp
            // 
            this.tsHtmlExp.Image = ((System.Drawing.Image)(resources.GetObject("tsHtmlExp.Image")));
            this.tsHtmlExp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsHtmlExp.Name = "tsHtmlExp";
            this.tsHtmlExp.Size = new System.Drawing.Size(78, 92);
            this.tsHtmlExp.Tag = "html";
            this.tsHtmlExp.Text = "Html导出";
            this.tsHtmlExp.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsHtmlExp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsHtmlExp.ToolTipText = "Html导出";
            this.tsHtmlExp.Click += new System.EventHandler(this.tsbBuild_Click);
            // 
            // tsXmlExp
            // 
            this.tsXmlExp.Image = ((System.Drawing.Image)(resources.GetObject("tsXmlExp.Image")));
            this.tsXmlExp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsXmlExp.Name = "tsXmlExp";
            this.tsXmlExp.Size = new System.Drawing.Size(74, 92);
            this.tsXmlExp.Tag = "xml";
            this.tsXmlExp.Text = "XML导出";
            this.tsXmlExp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsXmlExp.Click += new System.EventHandler(this.tsbBuild_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(69, 92);
            this.toolStripButton1.Tag = "markdown";
            this.toolStripButton1.Text = "MD导出";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // loadConfig
            // 
            this.loadConfig.Image = ((System.Drawing.Image)(resources.GetObject("loadConfig.Image")));
            this.loadConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadConfig.Name = "loadConfig";
            this.loadConfig.Size = new System.Drawing.Size(77, 92);
            this.loadConfig.Tag = "markdown";
            this.loadConfig.Text = "加载配置";
            this.loadConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.loadConfig.ToolTipText = "加载数据库分类配置";
            this.loadConfig.Click += new System.EventHandler(this.loadConfig_Click);
            // 
            // tptool
            // 
            this.tptool.Controls.Add(this.tsbPDMUpload);
            this.tptool.Location = new System.Drawing.Point(4, 24);
            this.tptool.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tptool.Name = "tptool";
            this.tptool.Size = new System.Drawing.Size(1419, 98);
            this.tptool.TabIndex = 3;
            this.tptool.Text = "工具";
            this.tptool.UseVisualStyleBackColor = true;
            // 
            // tsbPDMUpload
            // 
            this.tsbPDMUpload.BackColor = System.Drawing.SystemColors.Control;
            this.tsbPDMUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbPDMUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsbPDMUpload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbPDMUpload.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsbPDMUpload.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.tsbPDMUpload.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3});
            this.tsbPDMUpload.Location = new System.Drawing.Point(0, 0);
            this.tsbPDMUpload.Name = "tsbPDMUpload";
            this.tsbPDMUpload.Size = new System.Drawing.Size(1419, 98);
            this.tsbPDMUpload.TabIndex = 1;
            this.tsbPDMUpload.Text = "toolStripFile";
            this.tsbPDMUpload.Click += new System.EventHandler(this.tsbSaveUpload_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(77, 95);
            this.toolStripButton3.Text = "批注上载";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // apabout
            // 
            this.apabout.BackColor = System.Drawing.SystemColors.Control;
            this.apabout.Controls.Add(this.ribbonPageAbout);
            this.apabout.Location = new System.Drawing.Point(4, 24);
            this.apabout.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.apabout.Name = "apabout";
            this.apabout.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.apabout.Size = new System.Drawing.Size(1419, 98);
            this.apabout.TabIndex = 2;
            this.apabout.Text = "关于";
            this.apabout.ToolTipText = "关于";
            // 
            // ribbonPageAbout
            // 
            this.ribbonPageAbout.BackColor = System.Drawing.SystemColors.Control;
            this.ribbonPageAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ribbonPageAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPageAbout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbonPageAbout.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ribbonPageAbout.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.ribbonPageAbout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAbout});
            this.ribbonPageAbout.Location = new System.Drawing.Point(4, 2);
            this.ribbonPageAbout.Name = "ribbonPageAbout";
            this.ribbonPageAbout.Size = new System.Drawing.Size(1411, 94);
            this.ribbonPageAbout.TabIndex = 0;
            this.ribbonPageAbout.Text = "toolStripAbout";
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(52, 91);
            this.toolStripButtonAbout.Text = "关于";
            this.toolStripButtonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "新项选择";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.miniToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(894, 70);
            this.miniToolStrip.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AcceptButton = this.BtnSaveGridData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 875);
            this.Controls.Add(this.tabLayoutPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBCHM";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabLayoutPnl.ResumeLayout(false);
            this.mainPnl.ResumeLayout(false);
            this.treePnl.ResumeLayout(false);
            this.treePnl.PerformLayout();
            this.gpxHandle.ResumeLayout(false);
            this.codePnl.ResumeLayout(false);
            this.pizhuPnl.ResumeLayout(false);
            this.gpCurrTable.ResumeLayout(false);
            this.gpCurrTable.PerformLayout();
            this.GpColumns.ResumeLayout(false);
            this.GpColumns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ColComments)).EndInit();
            this.RibbonTabContainer.ResumeLayout(false);
            this.tpfile.ResumeLayout(false);
            this.tpfile.PerformLayout();
            this.ribbonPageFile.ResumeLayout(false);
            this.ribbonPageFile.PerformLayout();
            this.tptool.ResumeLayout(false);
            this.tptool.PerformLayout();
            this.tsbPDMUpload.ResumeLayout(false);
            this.tsbPDMUpload.PerformLayout();
            this.apabout.ResumeLayout(false);
            this.apabout.PerformLayout();
            this.ribbonPageAbout.ResumeLayout(false);
            this.ribbonPageAbout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip tlTip;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.TableLayoutPanel tabLayoutPnl;
        private System.Windows.Forms.TabControl RibbonTabContainer;
        private System.Windows.Forms.TabPage tpfile;
        private System.Windows.Forms.ToolStrip ribbonPageFile;
        private System.Windows.Forms.ToolStripButton tsbConnect;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbBuild;
        private System.Windows.Forms.ToolStripButton tsWordExp;
        private System.Windows.Forms.ToolStripButton tsExcelExp;
        private System.Windows.Forms.ToolStripButton tsPdfExp;
        private System.Windows.Forms.ToolStripButton tsHtmlExp;
        private System.Windows.Forms.ToolStripButton tsXmlExp;
        private System.Windows.Forms.ToolStripButton loadConfig;
        private System.Windows.Forms.TabPage tptool;
        private System.Windows.Forms.TabPage apabout;
        private System.Windows.Forms.ToolStrip ribbonPageAbout;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.Label label1;
        private TreeViewEnhanced treeDB;
        private System.Windows.Forms.CheckBox CkReverse;
        private System.Windows.Forms.Label lblSelectRes;
        private System.Windows.Forms.TextBox TxtSearchWords;
        private System.Windows.Forms.CheckBox CkAll;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.Label lblTongJi;
        private System.Windows.Forms.Panel treePnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpxHandle;
        private System.Windows.Forms.Panel pizhuPnl;
        private System.Windows.Forms.GroupBox gpCurrTable;
        private System.Windows.Forms.Label labCurrTabComment;
        private System.Windows.Forms.TextBox TxtCurrTabComment;
        private System.Windows.Forms.Label LabCurrTabName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GpColumns;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.DataGridView GV_ColComments;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnSaveGridData;
        private System.Windows.Forms.Panel codePnl;
        private ICSharpCode.TextEditor.TextEditorControl txtCode;
        private System.Windows.Forms.ToolStrip tsbPDMUpload;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColXuHao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button clearBtn;
    }
}