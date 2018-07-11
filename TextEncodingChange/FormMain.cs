using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEncodingChange {
   public partial class FormMain : Form {
      public FormMain() {
         InitializeComponent();
      }

      private void FormMain_Load(object sender, EventArgs e) {
         foreach (var encoding in Encoding.GetEncodings()) {
            this.cbxSrcEncoding.Items.Add(encoding);
            this.cbxDstEncoding.Items.Add(encoding);
         }
      }

      private void btnDo_Click(object sender, EventArgs e) {
         var srcEnc = (EncodingInfo)this.cbxSrcEncoding.SelectedItem;
         var dstEnc = (EncodingInfo)this.cbxDstEncoding.SelectedItem;
         if (srcEnc == null || dstEnc == null)
            return;

         this.dlgOpen.ShowDialog(this);
         var files = this.dlgOpen.FileNames;
         if (files.Length == 0)
            return;

         foreach (var file in files) {
            // get string
            var text = File.ReadAllText(file, srcEnc.GetEncoding());

            // backup original
            var fileName = Path.GetFileName(file);
            var backupDir = Path.GetDirectoryName(file) + "\\backup";
            if (Directory.Exists(backupDir) == false)
               Directory.CreateDirectory(backupDir);
            string backupFile = Path.Combine(backupDir, fileName);
            File.Move(file, backupFile);

            // convert
            File.WriteAllText(file, text, dstEnc.GetEncoding());

            this.tbxLog.AppendText(file + Environment.NewLine);
         }
      }
   }
}
