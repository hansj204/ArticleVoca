using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Word_of_the_Day.Controller;
using Word_of_the_Day.Model;

namespace Word_of_the_Day.View
{
    public partial class Register : Form
    {

        bool idFlag = false;

        public Login login { get; }

        public Register(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void addInfoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Regex rxPassword = new Regex(@"^(?=.*?[a-z])(?=.*?[#?!@$%^&*-])$", RegexOptions.IgnorePatternWhitespace);

                if (rxPassword.IsMatch(newPw.Text) == false && newPw.Text.Length < 5)
                {
                    warnPwLabel.Text = "비밀번호는 최소 5자 이상이고\n특수문자를 포함해야합니다.";
                    return;
                }

                if (newPw.Text.Length > 20)
                {
                    warnPwLabel.Text = "비밀번호는 최대 20자입니다.";
                    return;
                }
                if (newId.Text.Length > 20)
                {
                    warnPwLabel.Text = "아이디는 최대 20자입니다.";
                    return;
                }

                warnPwLabel.Text = "";

                using (var context = new mssqlDBContext())
                {

                    string uid = newId.Text;
                    string upw = newPw.Text;

                    var des = new DES(Word_of_the_Day.Properties.Resources.DesKey);
                    var encrypt = des.result(DesType.Encrypt, upw);

                    var user = new userInfo()
                    {
                        userId = uid,
                        userPassword = encrypt,
                        alarmYN = "N"
                    };

                    context.userInfo.Add(user);
                    context.SaveChanges();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            formExit();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            formExit();
        }

        private void overlapCheck_Click(object sender, EventArgs e)
        {
            using (var ctx = new mssqlDBContext())
            {
                string uid = newId.Text;
                var item = ctx.userInfo.SingleOrDefault(p => p.userId == uid);

                if (item == null)
                {
                    idFlag = true;
                    warnLabel.Text = "사용가능한 아이디입니다.";
                    addInfoBtn.Enabled = true;
                } else
                {
                    warnLabel.Text = "중복된 아이디입니다.";
                }
            }
        }

        private void showPwdBtn_Click(object sender, EventArgs e)
        {
            if (newPw.PasswordChar == default(char))
            {
                showPwdBtn.BackgroundImage = Word_of_the_Day.Properties.Resources._private;
                newPw.PasswordChar = '•';
            } 
            else
            {
                showPwdBtn.BackgroundImage = Word_of_the_Day.Properties.Resources.view;
                newPw.PasswordChar = default(char);
            }

        }

        private void formExit()
        {
            this.Hide();
            login.Show();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            formExit();
        }
    }
}
