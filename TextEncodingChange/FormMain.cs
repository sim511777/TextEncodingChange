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
         var encodings = Encoding.GetEncodings().Select(ei => ei.GetEncoding()).ToArray();
         this.cbxSrcEncoding.Items.AddRange(encodings);
         this.cbxDstEncoding.Items.AddRange(encodings);
      }

      private void btnDo_Click(object sender, EventArgs e) {
         var srcEnc = (Encoding)this.cbxSrcEncoding.SelectedItem;
         var dstEnc = (Encoding)this.cbxDstEncoding.SelectedItem;
         if (srcEnc == null || dstEnc == null)
            return;

         this.dlgOpen.ShowDialog(this);
         var files = this.dlgOpen.FileNames;
         if (files.Length == 0)
            return;

         foreach (var file in files) {
            // get string
            var text = File.ReadAllText(file, srcEnc);

            // backup original
            var fileName = Path.GetFileName(file);
            var backupDir = Path.GetDirectoryName(file) + "\\backup";
            if (Directory.Exists(backupDir) == false)
               Directory.CreateDirectory(backupDir);
            string backupFile = Path.Combine(backupDir, fileName);
            File.Move(file, backupFile);

            // convert
            File.WriteAllText(file, text, dstEnc);

            this.tbxLog.AppendText(file + Environment.NewLine);
         }
      }

      private void btnHelp_Click(object sender, EventArgs e) {
         var caption = "Text Encoding Coverter";
         var link = "https://github.com/sim511777/TextEncodingChange";
         var message = link + "\r\nWould yo visit?";

         var dr = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
         if (dr == DialogResult.Yes) {
            System.Diagnostics.Process.Start(link);
         }
      }
   }
}
