using DemoExamen.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoExamen.Forms
{
    public partial class Captcha : Form
    {

        public Captcha()
        {
            InitializeComponent();
            label1.Text = Helper.RandomString(6);
        }

        private void captchaAccept_Click(object sender, EventArgs e)
        {
            if (captchaBox.Text == label1.Text)
            {
                this.DialogResult = DialogResult.OK;
            }
            else {
                this.DialogResult = DialogResult.Abort;
            }
            this.Close();

        }
    }
}
