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
using System.Globalization;
using DSP = System.ComponentModel.DisplayNameAttribute;
using CVT = System.ComponentModel.TypeConverterAttribute;

namespace TextEncodingChange {
   public partial class FormMain : Form {
      public FormMain() {
         InitializeComponent();
      }

      private void Preview() {
         if (this.lbxFile.SelectedItems.Count == 1) {
            FileEnc item = (FileEnc)this.lbxFile.SelectedItem;
            byte[] bytesSrc = File.ReadAllBytes(item.FilePath);
            byte[] bytesDst = Encoding.Convert(item.SrcEnc, item.DstEnc, bytesSrc);
            this.tbxSrcPreview.Text = item.SrcEnc.GetString(bytesSrc);;
            this.tbxDstPreview.Text = item.DstEnc.GetString(bytesDst);;
            this.lblPreviewSrc.Text = $"SRC Preview - {item.SrcEnc.EncodingName}";
            this.lblPreviewDst.Text = $"DST Preview - {item.DstEnc.EncodingName}";
         } else {
            this.tbxSrcPreview.Clear();
            this.tbxDstPreview.Clear();
            this.lblPreviewSrc.Text = "SRC Preview";
            this.lblPreviewDst.Text = "DST Preview";
         }
      }

      private void btnHelp_Click(object sender, EventArgs e) {
         Encoding enc = Encoding.UTF8;

         var caption = "Text Encoding Coverter";
         var link = "https://github.com/sim511777/TextEncodingChange";
         var message = link + "\r\nWould yo visit?";

         var dr = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
         if (dr == DialogResult.Yes) {
            System.Diagnostics.Process.Start(link);
         }
      }

      private void btnAdd_Click(object sender, EventArgs e) {
         if (this.dlgOpen.ShowDialog(this) != DialogResult.OK)
            return;
         
         var list1 = this.lbxFile.Items.Cast<FileEnc>().Select(item => item.FilePath);
         var sameFiles = list1.Intersect(this.dlgOpen.FileNames).ToArray();
         if (sameFiles.Length != 0) {
            MessageBox.Show(this, string.Join("\r\n", sameFiles), "The following files exist in list");
            return;
         }

         var addItems = this.dlgOpen.FileNames.Cast<string>().Select(file => new FileEnc() { FilePath = file }).ToArray();
         this.lbxFile.Items.AddRange(addItems);
      }

      private void btnDelete_Click(object sender, EventArgs e) {
         this.lbxFile.SelectedItems.Cast<object>().ToList().ForEach(obj => this.lbxFile.Items.Remove(obj));
      }

      private void lbxFile_SelectedIndexChanged(object sender, EventArgs e) {
         //var workList = this.lbxFile.SelectedItems.Cast<FileEnc>().ToArray();
         var workList = this.lbxFile.SelectedItems.OfType<FileEnc>().ToArray();
         this.grdEncoder.SelectedObjects = workList;
         if (workList.Length == 0)
            this.lblEncSetting.Text = $"Encoding Setting";
         else if (workList.Length == 1)
            this.lblEncSetting.Text = $"Encoding Setting - {Path.GetFileName(workList[0].FilePath)}";
         else
            this.lblEncSetting.Text = $"Encoding Setting - {workList.Length} items";
         this.Preview();
      }

      private void grdEncoder_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) {
         this.Preview();
      }

      private void btnDo_Click(object sender, EventArgs e) {
         var items = this.lbxFile.Items.Cast<FileEnc>();
         foreach (var item in items) {
            try {
               byte[] original = File.ReadAllBytes(item.FilePath);
               byte[] converted = Encoding.Convert(item.SrcEnc, item.DstEnc, original);

               if (item.Backup) {
                  string fileName = Path.GetFileName(item.FilePath);
                  string dir = Path.GetDirectoryName(item.FilePath);
                  string backDir = dir + "\\backup";
                  string backFilePath = backDir + "\\" + fileName;
                  if (Directory.Exists(backDir) == false) {
                     Directory.CreateDirectory(backDir);
                  }
                  if (File.Exists(backFilePath))
                     File.Delete(backFilePath);
                  File.Move(item.FilePath, backFilePath);
                  this.tbxLog.AppendText($"Backup : {backFilePath}\r\n");
               }

               File.WriteAllBytes(item.FilePath, converted);
               this.tbxLog.AppendText($"Convert : {item.FilePath} ({item.SrcEnc.EncodingName} -> {item.DstEnc.EncodingName})\r\n");
            } catch (Exception ex) {
               this.tbxLog.AppendText($"Convert Failed : {item.FilePath} ({item.SrcEnc.EncodingName} -> {item.DstEnc.EncodingName}) : {ex.Message}\r\n");
            }
         }
      }
   }

   class FileEnc {
      [Browsable(false)]
      public string FilePath { get; set; }
      [DSP("SRC Encoding"), CVT(typeof(EncodingConverter))]
      public Encoding SrcEnc { get; set; } = Encoding.Default;
      [DSP("DST Encoding"), CVT(typeof(EncodingConverter))]
      public Encoding DstEnc { get; set; } = Encoding.Default;
      [DSP("Make Backup file")]
      public bool Backup { get; set; } = true;
   }

   class EncodingConverter : TypeConverter {
      private Dictionary<string, Encoding> encTable = Encoding.GetEncodings().Select(ei=>ei.GetEncoding()).OrderBy(ei=>ei.EncodingName).ToDictionary(enc=>MakeStringKey(enc));
      
      // string to Encoding possible?
      public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) {
         if (sourceType == typeof(string)) {
            return true;
         }
         return base.CanConvertFrom(context, sourceType);
      }

      // string to Encoding
      public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) {
         if (value is string) {
            string text = value as string;
            try {
               return encTable[value as string];
            } catch {
               throw new ArgumentException($"'{text}' 이름의 개체를 '{typeof(Encoding)}' 형식으로 변환할 수 없습니다.");
            }
         }
         return base.ConvertFrom(context, culture, value);
      }

      public static string MakeStringKey(Encoding enc) {
         return $"{enc.EncodingName} [{enc.CodePage}]";
      }

      // Encoding to string
      public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) {
         if (value is Encoding && destinationType == typeof(string)) {
            var enc = value as Encoding;
            return MakeStringKey(enc);
         }

         return base.ConvertTo(context, culture, value, destinationType);
      }

      // 리스트 선택 가능?
      public override bool GetStandardValuesSupported(ITypeDescriptorContext context) {
         return true;
      }

      // 리스트 아이템 추가
      public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) {
         return new StandardValuesCollection(encTable.Values);
      }
   }
}
