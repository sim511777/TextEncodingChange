namespace TextEncodingChange {
   partial class FormMain {
      /// <summary>
      /// 필수 디자이너 변수입니다.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// 사용 중인 모든 리소스를 정리합니다.
      /// </summary>
      /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form 디자이너에서 생성한 코드

      /// <summary>
      /// 디자이너 지원에 필요한 메서드입니다. 
      /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
      /// </summary>
      private void InitializeComponent() {
         this.btnDo = new System.Windows.Forms.Button();
         this.tbxLog = new System.Windows.Forms.TextBox();
         this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
         this.btnHelp = new System.Windows.Forms.Button();
         this.lbxFile = new System.Windows.Forms.ListBox();
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.panel4 = new System.Windows.Forms.Panel();
         this.label2 = new System.Windows.Forms.Label();
         this.panel3 = new System.Windows.Forms.Panel();
         this.grdEncoder = new System.Windows.Forms.PropertyGrid();
         this.lblEncSetting = new System.Windows.Forms.Label();
         this.panel2 = new System.Windows.Forms.Panel();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnAdd = new System.Windows.Forms.Button();
         this.splitContainer2 = new System.Windows.Forms.SplitContainer();
         this.panel6 = new System.Windows.Forms.Panel();
         this.tbxSrcPreview = new System.Windows.Forms.TextBox();
         this.lblPreviewSrc = new System.Windows.Forms.Label();
         this.panel7 = new System.Windows.Forms.Panel();
         this.tbxDstPreview = new System.Windows.Forms.TextBox();
         this.lblPreviewDst = new System.Windows.Forms.Label();
         this.panel5 = new System.Windows.Forms.Panel();
         this.label3 = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         this.panel4.SuspendLayout();
         this.panel3.SuspendLayout();
         this.panel2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
         this.splitContainer2.Panel1.SuspendLayout();
         this.splitContainer2.Panel2.SuspendLayout();
         this.splitContainer2.SuspendLayout();
         this.panel6.SuspendLayout();
         this.panel7.SuspendLayout();
         this.panel5.SuspendLayout();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // btnDo
         // 
         this.btnDo.Location = new System.Drawing.Point(3, 6);
         this.btnDo.Name = "btnDo";
         this.btnDo.Size = new System.Drawing.Size(75, 23);
         this.btnDo.TabIndex = 0;
         this.btnDo.Text = "Go";
         this.btnDo.UseVisualStyleBackColor = true;
         this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
         // 
         // tbxLog
         // 
         this.tbxLog.BackColor = System.Drawing.SystemColors.Window;
         this.tbxLog.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tbxLog.Location = new System.Drawing.Point(0, 20);
         this.tbxLog.Multiline = true;
         this.tbxLog.Name = "tbxLog";
         this.tbxLog.ReadOnly = true;
         this.tbxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.tbxLog.Size = new System.Drawing.Size(689, 90);
         this.tbxLog.TabIndex = 1;
         // 
         // dlgOpen
         // 
         this.dlgOpen.Multiselect = true;
         // 
         // btnHelp
         // 
         this.btnHelp.Location = new System.Drawing.Point(84, 7);
         this.btnHelp.Name = "btnHelp";
         this.btnHelp.Size = new System.Drawing.Size(23, 23);
         this.btnHelp.TabIndex = 1;
         this.btnHelp.Text = "?";
         this.btnHelp.UseVisualStyleBackColor = true;
         this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
         // 
         // lbxFile
         // 
         this.lbxFile.AllowDrop = true;
         this.lbxFile.DisplayMember = "FilePath";
         this.lbxFile.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lbxFile.FormattingEnabled = true;
         this.lbxFile.ItemHeight = 12;
         this.lbxFile.Location = new System.Drawing.Point(0, 20);
         this.lbxFile.Name = "lbxFile";
         this.lbxFile.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
         this.lbxFile.Size = new System.Drawing.Size(339, 553);
         this.lbxFile.TabIndex = 2;
         this.lbxFile.SelectedIndexChanged += new System.EventHandler(this.lbxFile_SelectedIndexChanged);
         this.lbxFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbxFile_DragDrop);
         this.lbxFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbxFile_DragEnter);
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.Location = new System.Drawing.Point(0, 0);
         this.splitContainer1.Name = "splitContainer1";
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.panel4);
         this.splitContainer1.Panel1.Controls.Add(this.panel3);
         this.splitContainer1.Panel1.Controls.Add(this.panel2);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
         this.splitContainer1.Panel2.Controls.Add(this.panel5);
         this.splitContainer1.Panel2.Controls.Add(this.panel1);
         this.splitContainer1.Size = new System.Drawing.Size(1036, 720);
         this.splitContainer1.SplitterDistance = 341;
         this.splitContainer1.TabIndex = 3;
         // 
         // panel4
         // 
         this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel4.Controls.Add(this.lbxFile);
         this.panel4.Controls.Add(this.label2);
         this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel4.Location = new System.Drawing.Point(0, 0);
         this.panel4.Name = "panel4";
         this.panel4.Size = new System.Drawing.Size(341, 575);
         this.panel4.TabIndex = 5;
         // 
         // label2
         // 
         this.label2.Dock = System.Windows.Forms.DockStyle.Top;
         this.label2.Location = new System.Drawing.Point(0, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(339, 20);
         this.label2.TabIndex = 0;
         this.label2.Text = "Source File List";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // panel3
         // 
         this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel3.Controls.Add(this.grdEncoder);
         this.panel3.Controls.Add(this.lblEncSetting);
         this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel3.Location = new System.Drawing.Point(0, 575);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(341, 112);
         this.panel3.TabIndex = 4;
         // 
         // grdEncoder
         // 
         this.grdEncoder.Dock = System.Windows.Forms.DockStyle.Fill;
         this.grdEncoder.HelpVisible = false;
         this.grdEncoder.Location = new System.Drawing.Point(0, 20);
         this.grdEncoder.Name = "grdEncoder";
         this.grdEncoder.PropertySort = System.Windows.Forms.PropertySort.NoSort;
         this.grdEncoder.Size = new System.Drawing.Size(339, 90);
         this.grdEncoder.TabIndex = 0;
         this.grdEncoder.ToolbarVisible = false;
         this.grdEncoder.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.grdEncoder_PropertyValueChanged);
         // 
         // lblEncSetting
         // 
         this.lblEncSetting.Dock = System.Windows.Forms.DockStyle.Top;
         this.lblEncSetting.Location = new System.Drawing.Point(0, 0);
         this.lblEncSetting.Name = "lblEncSetting";
         this.lblEncSetting.Size = new System.Drawing.Size(339, 20);
         this.lblEncSetting.TabIndex = 0;
         this.lblEncSetting.Text = "Encoding Setting";
         this.lblEncSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.btnDelete);
         this.panel2.Controls.Add(this.btnAdd);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel2.Location = new System.Drawing.Point(0, 687);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(341, 33);
         this.panel2.TabIndex = 3;
         // 
         // btnDelete
         // 
         this.btnDelete.Location = new System.Drawing.Point(84, 6);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(75, 23);
         this.btnDelete.TabIndex = 1;
         this.btnDelete.Text = "Delete";
         this.btnDelete.UseVisualStyleBackColor = true;
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // btnAdd
         // 
         this.btnAdd.Location = new System.Drawing.Point(3, 6);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(75, 23);
         this.btnAdd.TabIndex = 0;
         this.btnAdd.Text = "Add";
         this.btnAdd.UseVisualStyleBackColor = true;
         this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
         // 
         // splitContainer2
         // 
         this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer2.Location = new System.Drawing.Point(0, 0);
         this.splitContainer2.Name = "splitContainer2";
         // 
         // splitContainer2.Panel1
         // 
         this.splitContainer2.Panel1.Controls.Add(this.panel6);
         // 
         // splitContainer2.Panel2
         // 
         this.splitContainer2.Panel2.Controls.Add(this.panel7);
         this.splitContainer2.Size = new System.Drawing.Size(691, 575);
         this.splitContainer2.SplitterDistance = 346;
         this.splitContainer2.TabIndex = 7;
         // 
         // panel6
         // 
         this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel6.Controls.Add(this.tbxSrcPreview);
         this.panel6.Controls.Add(this.lblPreviewSrc);
         this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel6.Location = new System.Drawing.Point(0, 0);
         this.panel6.Name = "panel6";
         this.panel6.Size = new System.Drawing.Size(346, 575);
         this.panel6.TabIndex = 6;
         // 
         // tbxSrcPreview
         // 
         this.tbxSrcPreview.BackColor = System.Drawing.SystemColors.Window;
         this.tbxSrcPreview.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tbxSrcPreview.Location = new System.Drawing.Point(0, 20);
         this.tbxSrcPreview.Multiline = true;
         this.tbxSrcPreview.Name = "tbxSrcPreview";
         this.tbxSrcPreview.ReadOnly = true;
         this.tbxSrcPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.tbxSrcPreview.Size = new System.Drawing.Size(344, 553);
         this.tbxSrcPreview.TabIndex = 3;
         // 
         // lblPreviewSrc
         // 
         this.lblPreviewSrc.Dock = System.Windows.Forms.DockStyle.Top;
         this.lblPreviewSrc.Location = new System.Drawing.Point(0, 0);
         this.lblPreviewSrc.Name = "lblPreviewSrc";
         this.lblPreviewSrc.Size = new System.Drawing.Size(344, 20);
         this.lblPreviewSrc.TabIndex = 0;
         this.lblPreviewSrc.Text = "SRC Preview";
         this.lblPreviewSrc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // panel7
         // 
         this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel7.Controls.Add(this.tbxDstPreview);
         this.panel7.Controls.Add(this.lblPreviewDst);
         this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel7.Location = new System.Drawing.Point(0, 0);
         this.panel7.Name = "panel7";
         this.panel7.Size = new System.Drawing.Size(341, 575);
         this.panel7.TabIndex = 7;
         // 
         // tbxDstPreview
         // 
         this.tbxDstPreview.BackColor = System.Drawing.SystemColors.Window;
         this.tbxDstPreview.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tbxDstPreview.Location = new System.Drawing.Point(0, 20);
         this.tbxDstPreview.Multiline = true;
         this.tbxDstPreview.Name = "tbxDstPreview";
         this.tbxDstPreview.ReadOnly = true;
         this.tbxDstPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.tbxDstPreview.Size = new System.Drawing.Size(339, 553);
         this.tbxDstPreview.TabIndex = 3;
         // 
         // lblPreviewDst
         // 
         this.lblPreviewDst.Dock = System.Windows.Forms.DockStyle.Top;
         this.lblPreviewDst.Location = new System.Drawing.Point(0, 0);
         this.lblPreviewDst.Name = "lblPreviewDst";
         this.lblPreviewDst.Size = new System.Drawing.Size(339, 20);
         this.lblPreviewDst.TabIndex = 0;
         this.lblPreviewDst.Text = "DST Preview";
         this.lblPreviewDst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // panel5
         // 
         this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel5.Controls.Add(this.tbxLog);
         this.panel5.Controls.Add(this.label3);
         this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel5.Location = new System.Drawing.Point(0, 575);
         this.panel5.Name = "panel5";
         this.panel5.Size = new System.Drawing.Size(691, 112);
         this.panel5.TabIndex = 5;
         // 
         // label3
         // 
         this.label3.Dock = System.Windows.Forms.DockStyle.Top;
         this.label3.Location = new System.Drawing.Point(0, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(689, 20);
         this.label3.TabIndex = 0;
         this.label3.Text = "Result";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.btnHelp);
         this.panel1.Controls.Add(this.btnDo);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel1.Location = new System.Drawing.Point(0, 687);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(691, 33);
         this.panel1.TabIndex = 0;
         // 
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1036, 720);
         this.Controls.Add(this.splitContainer1);
         this.Name = "FormMain";
         this.Text = "Text Encoding Converter";
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         this.panel4.ResumeLayout(false);
         this.panel3.ResumeLayout(false);
         this.panel2.ResumeLayout(false);
         this.splitContainer2.Panel1.ResumeLayout(false);
         this.splitContainer2.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
         this.splitContainer2.ResumeLayout(false);
         this.panel6.ResumeLayout(false);
         this.panel6.PerformLayout();
         this.panel7.ResumeLayout(false);
         this.panel7.PerformLayout();
         this.panel5.ResumeLayout(false);
         this.panel5.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnDo;
      private System.Windows.Forms.TextBox tbxLog;
      private System.Windows.Forms.OpenFileDialog dlgOpen;
      private System.Windows.Forms.Button btnHelp;
      private System.Windows.Forms.ListBox lbxFile;
      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.Panel panel4;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.PropertyGrid grdEncoder;
      private System.Windows.Forms.Label lblEncSetting;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.Panel panel6;
      private System.Windows.Forms.TextBox tbxSrcPreview;
      private System.Windows.Forms.Label lblPreviewSrc;
      private System.Windows.Forms.Panel panel5;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.SplitContainer splitContainer2;
      private System.Windows.Forms.Panel panel7;
      private System.Windows.Forms.TextBox tbxDstPreview;
      private System.Windows.Forms.Label lblPreviewDst;
   }
}

