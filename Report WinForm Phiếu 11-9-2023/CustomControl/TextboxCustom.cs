using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_WinForm_Phiếu_11_9_2023.CustomControl
{
    public partial class TextboxCustom : UserControl
    {
        public TextboxCustom()
        {
            InitializeComponent();
            _textBox = textBox2;
            textEdt = _textBox.Text;
        }
        public String textEdt { get; set; }
        public TextBox _textBox {  get; set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textEdt = textBox2.Text;
        }
        public event KeyPressEventHandler TextBoxKeyPress;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress?.Invoke(sender, e);
        }


    }
}
