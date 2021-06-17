using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Diagnostics;
using Microsoft.Edge.SeleniumTools;
using Word_of_the_Day.Controller;
using Word_of_the_Day.Model;
using Word_of_the_Day.View;
using System.Text.RegularExpressions;
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.Foundation.Collections;

namespace Word_of_the_Day
{
    public partial class MainForm: Form
    {
        
        protected EdgeDriverService driverService = null;
        protected EdgeOptions options = null;
        protected EdgeDriver driver = null;

        private Color btnClickColor = Color.FromArgb(72, 79, 112);
        private Color btnLeaveColor = Color.FromArgb(31, 35, 55);

        public string loginUserId = "";
        public string testType = "";

        System.Threading.Timer vocaAlarmTimer;
        System.Threading.Timer updateColumnTimer;

        private delegate void TimerDelegate();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );

        public MainForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = homeBtn.Height;
            pnlNav.Top = homeBtn.Top;
            pnlNav.Left = homeBtn.Left;
            homeBtn.BackColor = Color.FromArgb(46, 51, 73);
        }

    
        public void setProfile(string userId, string loginDate)
        {
            loginUserId = userId;
            loginUserIdLabel.Text = loginUserId;

            if (loginDate == null || loginDate.Length > 0)
            {
                var connectDate = DateTime.Now - Convert.ToDateTime(loginDate);
                rowConnect.Text = (connectDate.Hours < 24) ? "매일 영어공부를\n도전해보세요" : "어제에 이어\n 연속 접속중";
            }
            else
            {
                rowConnect.Text = "매일 영어공부를\n도전해보세요";
            }

            setAlarmTimer();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            homeBtn.PerformClick();
            vocaBtn.Enabled = false;
            vocaTestBtn.Enabled = false;
            alarmBtn.Enabled = false;

            try
            {
                //영단어 검색을 위한 준비
                driverService = EdgeDriverService.CreateChromiumService();
                driverService.HideCommandPromptWindow = true;

                options = new EdgeOptions();
                options.UseChromium = true;
                options.AddArgument("headless");

                //매일 고전문학 해외칼럼 업데이트
                var saveTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);

                if (DateTime.Compare(saveTime, DateTime.Now) < 0) {
                    if (columnContent.Text.Length == 0) this.updateLiterature();
                    return;
                }

                TimeSpan ts = saveTime - DateTime.Now;
                  
                this.updateColumnTimer = new System.Threading.Timer(this.updateColumnTimerCallBack);
                this.updateColumnTimer.Change(ts, new TimeSpan(0));
            }
            catch (Exception exc)
            {
                Trace.WriteLine(exc.Message);
                MessageBox.Show("오류가 발생하였습니다.");
            }
        }

        private void updateColumnTimerCallBack(object t)
        {
            TimerDelegate del = new TimerDelegate(this.updateLiterature);
            del.Invoke();
        }

        private void updateLiterature()
        {            
            string url = "https://koreanliteraturenow.com/api/?t=proetry";
            XElement xElement = XElement.Load(url);
            var xmlQuery = from item in xElement.Descendants("item") select item;

            Random rand = new Random();
            int index = rand.Next(0, xmlQuery.Count());
            var element = xmlQuery.ElementAt(index);

            columnTitle.Text = (string)element.Element("title");
            columnTitle.Text = columnTitle.Text.Replace("[Inkstone]", "");

            var content = (string)element.Element("content");
            content = GetPlainTextFromHtml(content);
            content = content.TrimStart();
            columnContent.Text = content;
        }

        private string GetPlainTextFromHtml(string htmlString)
        {
            string htmlTagPattern = "<[^>]*>";
            var regexCss = new Regex("(\\<script(.+?)\\</script\\>)|(\\<style(.+?)\\</style\\>)", RegexOptions.Singleline | RegexOptions.IgnoreCase);
            htmlString = regexCss.Replace(htmlString, string.Empty);
            htmlString = Regex.Replace(htmlString, htmlTagPattern, string.Empty);
            //htmlString = Regex.Replace(htmlString, @"^\s*$\n", "", RegexOptions.Multiline);
            htmlString = htmlString.Replace("&nbsp;", string.Empty);

            return htmlString;
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void vacaSearchBtn_Click(object sender, EventArgs e)
        {
            searchVoca();
        }

        private void vocaInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchVoca();
            }
        }

        private void searchVoca()
        {
            vacaMeaningInput.Text = "검색중...";

            try
            {
                Regex emailregex = new Regex(@"[a-zA-Z]");
                Boolean ismatch = emailregex.IsMatch(vocaInput.Text);
                if (!ismatch)
                {
                    MessageBox.Show("영문자만 입력해 주세요.");
                    vocaInput.Text = "";
                    return;

                }

                driver = new EdgeDriver(driverService, options);

                driver.Navigate().GoToUrl("https://dic.daum.net/");

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                var searchBox = driver.FindElementByXPath("//*[@id='q']");
                searchBox.SendKeys(vocaInput.Text);

                var searchButton = driver.FindElementByXPath("//*[@id='daumBtnSearch']");
                searchButton.Click();

                searchBox = driver.FindElementByXPath("//*[@id='mArticle']/div[1]/div[2]/div[2]/div/ul");
                vacaMeaningInput.Text = searchBox.Text;

                if (loginUserId.Length == 0) return;

                using (var context = new mssqlDBContext())
                {
                    var voca = context.vocabulary.Where(b => b.wordName == vocaInput.Text && b.userId == loginUserId);

                    if (voca.Count() > 0) return;

                    var meaning = searchBox.Text.Replace("\r\n", " ").Replace("1.", "").Replace(".", ",");
                    meaning = Regex.Replace(meaning, @"\d", "");

                    var newVoca = new vocabulary()
                    {
                        userId = loginUserId,
                        wordName = vocaInput.Text,
                        wordMeaning = meaning,
                        wrongCnt = 0
                    };

                    context.vocabulary.Add(newVoca);
                    context.SaveChanges();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(driver != null) driver.Quit();
            Dispose(true);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            changePage(homeBtn.Top, homeBtn.Height, "H");
        }

        private void vocaBtn_Click(object sender, EventArgs e)
        {
           changePage(vocaBtn.Top, vocaBtn.Height, "V");
           paintVocaCard();
        }

        private void selectItem(string voca, string vocaMeaning)
        {    
            vocaCard cardDialog = new vocaCard(voca, vocaMeaning);
            cardDialog.Show();
            paintVocaCard();
        }

        private void deleteItem(int vocaNo)
        {
            using (var context = new mssqlDBContext())
            {

                var voca = context.vocabulary.Where(b => b.userId == loginUserId && b.vocaNo == vocaNo).FirstOrDefault();
                context.vocabulary.Remove(voca);
                context.SaveChanges();
            }

            paintVocaCard();
        }

        private void paintVocaCard()
        {
            vocaDataArea.Visible = false;

            vocaDataArea.Controls.Clear();

            using (var context = new mssqlDBContext())
            {
                var rowCnt = 0;
                var columnuCnt = -1;
                var vocaData = context.vocabulary.Where(b => b.userId == loginUserId).OrderBy(b => b.wrongCnt);

                foreach (var voca in vocaData)
                {

                    if (3 > columnuCnt)
                    {
                        columnuCnt = columnuCnt + 1;
                    }

                    if (columnuCnt == 3)
                    {
                        rowCnt++;
                        columnuCnt = 0;
                    }

                    if(rowCnt == 9)
                    {
                        vocaDataArea.RowCount++;
                        this.vocaDataArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
                    }

                    Label title = new Label();
                    title.Text = voca.wordName;
                    title.ForeColor = Color.White;
                    title.Location = new Point(0, 0);
                    title.Size = new Size(250, 30);
                    title.Font = new Font("나눔스퀘어라운드", 15, FontStyle.Bold);

                    Console.WriteLine(voca.wordMeaning);

                    Label content = new Label();
                    content.Text = voca.wordMeaning.Replace("\t"," ");
                    content.ForeColor = Color.White;
                    content.Location = new Point(0, 30);
                    content.Size = new Size(250, 20);
                    content.MaximumSize = new Size(250, 20);
                    content.Font = new Font("나눔스퀘어라운드", 12);
                    content.AutoEllipsis = true;

                    Panel panel = new Panel();
                    panel.Controls.Add(title);
                    panel.Controls.Add(content);
                    panel.Size = new Size(250, 50);
                    panel.BackColor = Color.FromArgb(72, 79, 112);
                    
                    ContextMenu contextMenu = new ContextMenu();

                    MenuItem selectItem = new MenuItem("상세보기");
                    selectItem.Click += (objectArgs, eventArgs) => { this.selectItem(voca.wordName, voca.wordMeaning); };

                    MenuItem deleteItem = new MenuItem("삭제");
                    deleteItem.Click += (objectArgs, eventArgs) => { this.deleteItem(voca.vocaNo); };

                    contextMenu.MenuItems.Add(selectItem);
                    contextMenu.MenuItems.Add(deleteItem);
                    panel.ContextMenu = contextMenu;
                    ToolTip toolTip = new ToolTip();
                    toolTip.SetToolTip(panel, content.Text);

                    vocaDataArea.Controls.Add(panel, columnuCnt, rowCnt);
                }

                vocaDataArea.Visible = true;
            }
        }

            private void vocaTestBtn_Click(object sender, EventArgs e)
        {            
            changePage(vocaTestBtn.Top, vocaTestBtn.Height, "T");
            
            vocaTestDialog vocaTestDialog = new vocaTestDialog(this);
            vocaTestDialog.Show();
        }

        public void paintVocaTest(string type)
        {
            testType = type;
            makeTestBtn.Enabled = true;

            using (var context = new mssqlDBContext())
            {

                var vocaData = context.vocabulary.Where(b => b.userId == loginUserId);

                DataTable testGrid = new DataTable();

                testGrid.Columns.Add("영어단어", typeof(string));
                testGrid.Columns.Add("뜻", typeof(string));

                if (testType == "S") testGrid.Columns.Add("원본 영어단어", typeof(string));
                else testGrid.Columns.Add("원본 뜻", typeof(string));

                foreach (var voca in vocaData)
                {
                    if (testType == "S") testGrid.Rows.Add("", voca.wordMeaning, voca.wordName);
                    else testGrid.Rows.Add(voca.wordName, "", voca.wordMeaning);
                }

                vocaTestGrid.Font = new Font("나눔스퀘어라운드", 11);
                vocaTestGrid.DataSource = testGrid;
                vocaTestGrid.Columns[0].Width = 250;
                vocaTestGrid.Columns[1].Width = 350;

                vocaTestGrid.Columns[1].ReadOnly = true;
                vocaTestGrid.Columns[2].Visible = false;
            }
        }

        private void alarmBtn_Click(object sender, EventArgs e)
        {
            changePage(alarmBtn.Top, alarmBtn.Height, "A");
        }

        private void changePage(int top, int height, string type)
        {

            if(type != "T" && vocaTestGrid.DataSource != null)
            {
                DialogResult r = MessageBox.Show("다른 탭으로 이동시 진행중인 테스트가 초기화됩니다. 계속 진행하시겠습니까?", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (r == DialogResult.Cancel)
                    return; 

                vocaTestGrid.DataSource = null;
                makeTestBtn.Enabled = false;
            }

            pnlNav.Top = top;
            pnlNav.Height = height;

            if(type != "H" && loginUserId == null)
            {
                MessageBox.Show("로그인한 사용자만 이용할 수 있는 기능입니다.");
            }

            vocaInput.Text = "";
            vacaMeaningInput.Text = "";

            homeBtn.BackColor = ("H" == type) ? btnClickColor : btnLeaveColor;
            vocaBtn.BackColor = ("V" == type) ? btnClickColor : btnLeaveColor;
            vocaTestBtn.BackColor = ("T" == type) ? btnClickColor : btnLeaveColor;
            alarmBtn.BackColor = ("A" == type) ? btnClickColor : btnLeaveColor;

            literatureArea.Visible = ("H" == type) ? true : false;
            vocaNoteArea.Visible = ("V" == type) ? true : false;
            vocaTestArea.Visible = ("T" == type) ? true : false;
            alarmArea.Visible = ("A" == type) ? true : false;
        }

        private void setAlramBtn_Click(object sender, EventArgs e)
        {

            if (timeHour.Text.Length == 0 || timeHour.Text.Length == 0 || (!morning.Checked && !afternoon.Checked))
            {
                MessageBox.Show("시간을 세팅해주세요");
                return;
            }

            var alarmHour = (morning.Checked) ? Int32.Parse(timeHour.Text) : Int32.Parse(timeHour.Text) + 12;
            if(alarmHour == 24) alarmHour = 0;
            var alarmMinute = Int32.Parse(timeMin.Text);

            using (var context = new mssqlDBContext())
            {
                var alarmTime = new TimeSpan(alarmHour, alarmMinute, 0);

                var user = context.userInfo.Where(b => b.userId == loginUserId).FirstOrDefault();

                user.alarmYN = "Y";
                user.alarmTimestamp = alarmTime;
                context.SaveChanges();
            }
           
            setAlarmTimer();
        }

        private void setAlarmTimer()
        {

            if (loginUserId == null || loginUserId.Length == 0) return;

            //로그인 알림 기능
            string[] time = new string[3];
            Boolean yesAlarm = true;

            try
            {
                using (var context = new mssqlDBContext())
                {

                    var userInfo = context.userInfo.Where(b => b.userId == loginUserId).FirstOrDefault();

                    if (userInfo.alarmYN.Replace("\0", "").Trim().Equals("N"))
                    {
                        nowTime.Text = "";
                        subscribeY.Checked = false;
                        subscribeN.Checked = true;
                        yesAlarm = false;
                    } else
                    {
                        subscribeY.Checked = true;
                        subscribeN.Checked = false;
                        nowTime.Text = userInfo.alarmTimestamp.ToString();
                        setAlramBtn.Enabled = true;
                        time = userInfo.alarmTimestamp.ToString().Split(':');
                    }
                }

                if (!yesAlarm) return;

                var saveTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Int32.Parse(time[0]), Int32.Parse(time[1]), 0);

                if (DateTime.Compare(saveTime, DateTime.Now) < 0) return;

                TimeSpan ts = saveTime - DateTime.Now;

                this.vocaAlarmTimer = new System.Threading.Timer(this.vocaAlarmTimerCallBack);
                this.vocaAlarmTimer.Change(ts, new TimeSpan(0));                
            }
            catch (Exception e)
            {
                MessageBox.Show("알림 오류가 발생하였습니다.");
            }

            morning.Checked = (Int32.Parse(time[0]) < 12) ? true : false;
            afternoon.Checked = (Int32.Parse(time[0]) < 12) ? false : true;

            var timeHourText = (Int32.Parse(time[0]) < 12) ? time[0] : (Int32.Parse(time[0]) - 12).ToString();
            timeHourText = (Int32.Parse(timeHourText) > 9) ? timeHourText : ("0" + timeHourText);
            timeHour.Text = timeHourText;
            timeMin.Text = time[1];
        }

        private void vocaAlarmTimerCallBack(object t)
        {
            TimerDelegate del = new TimerDelegate(this.columnAlarm);
            del.Invoke();
        }

        private void columnAlarm()
        {
            new ToastContentBuilder()
            .AddArgument("action", "viewConversation")
            .AddArgument("conversationId", 9813)
            .AddText("칼럼보카 알림")
            .AddText("오늘도 영문 칼럼 기사가 업데이트되었습니다.")
            .Show();
        }
        private void accountBtn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(this);
            loginForm.Show();
        }

        private void loginUserIdLabel_TextChanged(object sender, EventArgs e)
        {
            if(loginUserId == null || loginUserId.Length == 0)
            {
                vocaBtn.Enabled = false;
                vocaTestBtn.Enabled = false;
                alarmBtn.Enabled = false;
            } else
            {
                vocaBtn.Enabled = true;
                vocaTestBtn.Enabled = true;
                alarmBtn.Enabled = true;
            }
        }

        private void miniumBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void makeTestBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("정말 체점하시겠습니까?", "테스트 체점", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dr != DialogResult.OK) return;

            using (var context = new mssqlDBContext())
            {

                string writeVoca = string.Empty;
                string answerVoca = string.Empty;
                var isMsg = false;

                for (int i = 0; i < vocaTestGrid.Rows.Count; i++)
                {
                    DataGridViewRow row = vocaTestGrid.Rows[i];


                    writeVoca = (string)row.Cells[0].Value;
                    answerVoca = (string)vocaTestGrid.Rows[i].Cells[2].Value.ToString();

                    if (testType == "S")
                    {
                        if (answerVoca.Contains(writeVoca) && (writeVoca.Trim().Length > 0 || writeVoca != null))
                            vocaTestGrid.Rows.Remove(vocaTestGrid.Rows[i]);
                        else
                            isMsg = true;
                    }
                    else
                    {
                        if (answerVoca.Contains(writeVoca) && (writeVoca.Trim().Length > 0 || writeVoca != null))
                            vocaTestGrid.Rows.Remove(vocaTestGrid.Rows[i]);
                        else 
                            isMsg = true;
                    }
                }

                if (isMsg) MessageBox.Show("틀린 문제가 있습니다. 재시험을 보세요.");
                else
                {
                    DialogResult r= MessageBox.Show("테스트를 통과하셨습니다. 다른 테스트를 계속 진행하겠습니까?", "테스트 진행", MessageBoxButtons.OKCancel);
                   if(r == DialogResult.OK)
                    {
                        MessageBox.Show("테스트를 종료되었습니다");
                        vocaTestGrid.DataSource = null;
                        makeTestBtn.Enabled = false;
                    }
                   else
                    {
                        paintVocaTest((testType == "S") ? "M" : "S");
                    }
                }
                context.SaveChanges();
            }
        }

        private void subscribeY_Click(object sender, EventArgs e)
        {
            setAlramBtn.Enabled = true;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            ToastNotificationManagerCompat.History.Clear();
        }

        private void subscribeN_Click(object sender, EventArgs e)
        {
            setAlramBtn.Enabled = false;
        }

        private void menuArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("프로그램을 종료하면 알림을 받을 수 없습니다. 종료하시겠습니까?", "종료", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
               
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }
    }
}
