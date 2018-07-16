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
         this.cbxSrcEncoding = new System.Windows.Forms.ComboBox();
         this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
         this.cbxDstEncoding = new System.Windows.Forms.ComboBox();
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.btnHelp = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // btnDo
         // 
         this.btnDo.Dock = System.Windows.Forms.DockStyle.Right;
         this.btnDo.Location = new System.Drawing.Point(382, 0);
         this.btnDo.Name = "btnDo";
         this.btnDo.Size = new System.Drawing.Size(44, 20);
         this.btnDo.TabIndex = 0;
         this.btnDo.Text = "Go";
         this.btnDo.UseVisualStyleBackColor = true;
         this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
         // 
         // tbxLog
         // 
         this.tbxLog.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tbxLog.Location = new System.Drawing.Point(0, 20);
         this.tbxLog.Multiline = true;
         this.tbxLog.Name = "tbxLog";
         this.tbxLog.Size = new System.Drawing.Size(448, 347);
         this.tbxLog.TabIndex = 1;
         // 
         // cbxSrcEncoding
         // 
         this.cbxSrcEncoding.DisplayMember = "EncodingName";
         this.cbxSrcEncoding.Dock = System.Windows.Forms.DockStyle.Fill;
         this.cbxSrcEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbxSrcEncoding.FormattingEnabled = true;
         this.cbxSrcEncoding.Location = new System.Drawing.Point(30, 0);
         this.cbxSrcEncoding.Name = "cbxSrcEncoding";
         this.cbxSrcEncoding.Size = new System.Drawing.Size(166, 20);
         this.cbxSrcEncoding.Sorted = true;
         this.cbxSrcEncoding.TabIndex = 2;
         // 
         // dlgOpen
         // 
         this.dlgOpen.Multiselect = true;
         // 
         // cbxDstEncoding
         // 
         this.cbxDstEncoding.DisplayMember = "EncodingName";
         this.cbxDstEncoding.Dock = System.Windows.Forms.DockStyle.Fill;
         this.cbxDstEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbxDstEncoding.FormattingEnabled = true;
         this.cbxDstEncoding.Location = new System.Drawing.Point(29, 0);
         this.cbxDstEncoding.Name = "cbxDstEncoding";
         this.cbxDstEncoding.Size = new System.Drawing.Size(153, 20);
         this.cbxDstEncoding.Sorted = true;
         this.cbxDstEncoding.TabIndex = 2;
         this.cbxDstEncoding.ValueMember = "Name";
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.Location = new System.Drawing.Point(0, 0);
         this.splitContainer1.Name = "splitContainer1";
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.cbxSrcEncoding);
         this.splitContainer1.Panel1.Controls.Add(this.label1);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.cbxDstEncoding);
         this.splitContainer1.Panel2.Controls.Add(this.label2);
         this.splitContainer1.Size = new System.Drawing.Size(382, 20);
         this.splitContainer1.SplitterDistance = 196;
         this.splitContainer1.TabIndex = 3;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Dock = System.Windows.Forms.DockStyle.Left;
         this.label1.Location = new System.Drawing.Point(0, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(30, 12);
         this.label1.TabIndex = 0;
         this.label1.Text = "SRC";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Dock = System.Windows.Forms.DockStyle.Left;
         this.label2.Location = new System.Drawing.Point(0, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(29, 12);
         this.label2.TabIndex = 1;
         this.label2.Text = "DST";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.splitContainer1);
         this.panel1.Controls.Add(this.btnDo);
         this.panel1.Controls.Add(this.btnHelp);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(448, 20);
         this.panel1.TabIndex = 4;
         // 
         // btnHelp
         // 
         this.btnHelp.Dock = System.Windows.Forms.DockStyle.Right;
         this.btnHelp.Location = new System.Drawing.Point(426, 0);
         this.btnHelp.Name = "btnHelp";
         this.btnHelp.Size = new System.Drawing.Size(22, 20);
         this.btnHelp.TabIndex = 1;
         this.btnHelp.Text = "?";
         this.btnHelp.UseVisualStyleBackColor = true;
         this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
         // 
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(448, 367);
         this.Controls.Add(this.tbxLog);
         this.Controls.Add(this.panel1);
         this.Name = "FormMain";
         this.Text = "Text Encoding Converter";
         this.Load += new System.EventHandler(this.FormMain_Load);
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel1.PerformLayout();
         this.splitContainer1.Panel2.ResumeLayout(false);
         this.splitContainer1.Panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnDo;
      private System.Windows.Forms.TextBox tbxLog;
      private System.Windows.Forms.ComboBox cbxSrcEncoding;
      private System.Windows.Forms.OpenFileDialog dlgOpen;
      private System.Windows.Forms.ComboBox cbxDstEncoding;
      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button btnHelp;
   }
}

