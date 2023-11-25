namespace TextEncodingTest {
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
            this.lbxEncoding = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbxString = new System.Windows.Forms.TextBox();
            this.tbxBytes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxEncoding
            // 
            this.lbxEncoding.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbxEncoding.FormattingEnabled = true;
            this.lbxEncoding.ItemHeight = 12;
            this.lbxEncoding.Location = new System.Drawing.Point(0, 0);
            this.lbxEncoding.Name = "lbxEncoding";
            this.lbxEncoding.Size = new System.Drawing.Size(392, 773);
            this.lbxEncoding.TabIndex = 0;
            this.lbxEncoding.SelectedIndexChanged += new System.EventHandler(this.lbxEncoding_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(392, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbxString);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbxBytes);
            this.splitContainer1.Size = new System.Drawing.Size(886, 773);
            this.splitContainer1.SplitterDistance = 448;
            this.splitContainer1.TabIndex = 1;
            // 
            // tbxString
            // 
            this.tbxString.BackColor = System.Drawing.SystemColors.Window;
            this.tbxString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxString.Font = new System.Drawing.Font("굴림체", 9F);
            this.tbxString.Location = new System.Drawing.Point(0, 0);
            this.tbxString.Multiline = true;
            this.tbxString.Name = "tbxString";
            this.tbxString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxString.Size = new System.Drawing.Size(448, 773);
            this.tbxString.TabIndex = 4;
            this.tbxString.WordWrap = false;
            this.tbxString.TextChanged += new System.EventHandler(this.tbxString_TextChanged);
            // 
            // tbxBytes
            // 
            this.tbxBytes.BackColor = System.Drawing.SystemColors.Window;
            this.tbxBytes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxBytes.Font = new System.Drawing.Font("굴림체", 9F);
            this.tbxBytes.Location = new System.Drawing.Point(0, 0);
            this.tbxBytes.Multiline = true;
            this.tbxBytes.Name = "tbxBytes";
            this.tbxBytes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxBytes.Size = new System.Drawing.Size(434, 773);
            this.tbxBytes.TabIndex = 5;
            this.tbxBytes.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 773);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lbxEncoding);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxEncoding;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbxString;
        private System.Windows.Forms.TextBox tbxBytes;
    }
}

