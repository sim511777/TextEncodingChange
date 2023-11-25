using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEncodingTest {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
            lbxEncoding.DisplayMember = "Item1";
            lbxEncoding.ValueMember = "Item2";
            lbxEncoding.DataSource = Encoding.GetEncodings().Select(encInfo => encInfo.GetEncoding()).Select(enc => Tuple.Create(enc.EncodingName, enc)).ToArray();
        }

        private void tbxString_TextChanged(object sender, EventArgs e) {
            Test();
        }

        private void lbxEncoding_SelectedIndexChanged(object sender, EventArgs e) {
            Test();
        }

        private void Test() {
            var str = tbxString.Text;
            var enc = (Encoding)lbxEncoding.SelectedValue;
            var bytes = enc.GetBytes(str);
            var hex = BitConverter.ToString(bytes);
            tbxBytes.Text = hex;
        }
    }
}
