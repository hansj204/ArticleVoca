using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Word_of_the_Day.Controller;

namespace Word_of_the_Day.View
{
    public partial class Login : Form
    {
        MainForm mainForm;

        public Login(MainForm mainForm)
        {
            InitializeComponent();
            loginId.Focus();
            this.mainForm = mainForm;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
           Register register = new Register(this);
           register.Show();
           this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            int userIdExist = 0;
            string cryptPw = "";

            using (var context = new mssqlDBContext()) {

                var item = context.userInfo.Where(p => p.userId == loginId.Text);

                userIdExist = item.Count();

                if (userIdExist == 1) {
                    foreach (var i in item) {
                        cryptPw = i.userPassword;
                    }
                }
            }

            if (userIdExist == 0) {
                infoCheck.Text = "잘못된 정보가 입력되었습니다.";
            } else {
                var des = new DES(Word_of_the_Day.Properties.Resources.DesKey);
                var descrypt = des.result(DesType.Decrypt, cryptPw);
                var loginDate = "";

                descrypt = descrypt.Replace("\0", "").Trim();

                if (descrypt.Equals(loginPw.Text)) {

                    using (var context = new mssqlDBContext())
                    {
                        var userInfo = context.userInfo.Where(p => p.userId == loginId.Text).FirstOrDefault();

                        loginDate = userInfo.loginTimestamp;
                        userInfo.loginTimestamp = DateTime.Now.ToString();
                        context.SaveChanges();
                    }

                    infoCheck.Text = "";

                    this.Hide();
                    mainForm.setProfile(loginId.Text, loginDate);
                }
                else {
                    infoCheck.Text = "아이디와 패스워드를 확인하여 다시 입력하세요.";
                }
            }
        }

        private void loginPw_KeyDown(object sender, KeyEventArgs e)
        {
            loginBtn.Enabled = (loginPw.TextLength == 0)? false : true;

            if (e.KeyCode == Keys.Enter)
            {
                loginBtn.PerformClick();
            }
        }
    }
}
