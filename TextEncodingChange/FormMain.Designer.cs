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
         this.SuspendLayout();
         // 
         // btnDo
         // 
         this.btnDo.Location = new System.Drawing.Point(12, 12);
         this.btnDo.Name = "btnDo";
         this.btnDo.Size = new System.Drawing.Size(75, 23);
         this.btnDo.TabIndex = 0;
         this.btnDo.Text = "Do";
         this.btnDo.UseVisualStyleBackColor = true;
         this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
         // 
         // tbxLog
         // 
         this.tbxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tbxLog.Location = new System.Drawing.Point(12, 41);
         this.tbxLog.Multiline = true;
         this.tbxLog.Name = "tbxLog";
         this.tbxLog.Size = new System.Drawing.Size(444, 321);
         this.tbxLog.TabIndex = 1;
         // 
         // cbxSrcEncoding
         // 
         this.cbxSrcEncoding.DisplayMember = "DisplayName";
         this.cbxSrcEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbxSrcEncoding.FormattingEnabled = true;
         this.cbxSrcEncoding.Location = new System.Drawing.Point(93, 12);
         this.cbxSrcEncoding.Name = "cbxSrcEncoding";
         this.cbxSrcEncoding.Size = new System.Drawing.Size(178, 20);
         this.cbxSrcEncoding.Sorted = true;
         this.cbxSrcEncoding.TabIndex = 2;
         // 
         // dlgOpen
         // 
         this.dlgOpen.Multiselect = true;
         // 
         // cbxDstEncoding
         // 
         this.cbxDstEncoding.DisplayMember = "DisplayName";
         this.cbxDstEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbxDstEncoding.FormattingEnabled = true;
         this.cbxDstEncoding.Location = new System.Drawing.Point(278, 12);
         this.cbxDstEncoding.Name = "cbxDstEncoding";
         this.cbxDstEncoding.Size = new System.Drawing.Size(178, 20);
         this.cbxDstEncoding.Sorted = true;
         this.cbxDstEncoding.TabIndex = 2;
         this.cbxDstEncoding.ValueMember = "Name";
         // 
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(468, 374);
         this.Controls.Add(this.cbxDstEncoding);
         this.Controls.Add(this.cbxSrcEncoding);
         this.Controls.Add(this.tbxLog);
         this.Controls.Add(this.btnDo);
         this.Name = "FormMain";
         this.Text = "Text Encoding Converter";
         this.Load += new System.EventHandler(this.FormMain_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnDo;
      private System.Windows.Forms.TextBox tbxLog;
      private System.Windows.Forms.ComboBox cbxSrcEncoding;
      private System.Windows.Forms.OpenFileDialog dlgOpen;
      private System.Windows.Forms.ComboBox cbxDstEncoding;
   }
}

