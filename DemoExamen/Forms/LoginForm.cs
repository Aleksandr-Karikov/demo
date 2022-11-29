using DemoExamen.Dto;
using DemoExamen.Forms.Base;
using DemoExamen.Services;
using SD2022Users_NN_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoExamen.Forms
{
    public partial class LoginForm : BaseForm
    {
        Timer timer = new Timer();
        public LoginForm()
        {
            InitializeComponent();
            //var moks = new List<TimeSpan>() {
            //    new TimeSpan(10, 0, 0),
            //    new TimeSpan(11, 0, 0),
            //    new TimeSpan(15, 0, 0),
            //    new TimeSpan(15, 30, 0),
            //    new TimeSpan(16, 50, 0),
            //};
            //var moks2 = new List<int>() {
            //    60, 30, 10,10, 40
            //};
            //var res = Calculations.AvailablePeriods(moks.ToArray(), moks2.ToArray(), new TimeSpan(8, 0, 0), new TimeSpan(18, 0, 0), 30);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var loginDto = new LoginDto() { Login = loginBox.Text, Password = passwordBox.Text };
            try
            {
                var user = AuthService.Login(loginDto);
                var dialogResult = new Captcha().ShowDialog();
                if (dialogResult == DialogResult.Abort)
                {
                    timer.Interval = 10000;
                    timer.Tick += timer_Tick;
                    timer.Start();
                    loginButton.Enabled = false;
                }
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProductsForm().Show();
        }

        void timer_Tick(object sender, System.EventArgs e)
        {
            loginButton.Enabled = true;
            timer.Stop();
        }
    }
}
