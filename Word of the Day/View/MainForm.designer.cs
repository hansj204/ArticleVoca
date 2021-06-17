namespace Word_of_the_Day
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuArea = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.accountBtn = new System.Windows.Forms.Button();
            this.alarmBtn = new System.Windows.Forms.Button();
            this.vocaTestBtn = new System.Windows.Forms.Button();
            this.vocaBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rowConnect = new System.Windows.Forms.Label();
            this.loginUserIdLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.vocaListArea = new System.Windows.Forms.Panel();
            this.columnTitle = new System.Windows.Forms.Label();
            this.columnContent = new System.Windows.Forms.RichTextBox();
            this.vocaInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vacaMeaningInput = new System.Windows.Forms.TextBox();
            this.literatureArea = new System.Windows.Forms.Panel();
            this.vacaSearchBtn = new System.Windows.Forms.Button();
            this.vocaDataArea = new System.Windows.Forms.TableLayoutPanel();
            this.vocaNoteArea = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.afternoon = new System.Windows.Forms.RadioButton();
            this.morning = new System.Windows.Forms.RadioButton();
            this.timeMin = new System.Windows.Forms.ComboBox();
            this.timeHour = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.showNowTime = new System.Windows.Forms.GroupBox();
            this.every = new System.Windows.Forms.Label();
            this.nowTime = new System.Windows.Forms.Label();
            this.setAlramBtn = new System.Windows.Forms.Button();
            this.subscribeY = new System.Windows.Forms.RadioButton();
            this.subscribeN = new System.Windows.Forms.RadioButton();
            this.alarmArea = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.miniumBtn = new System.Windows.Forms.Button();
            this.vocaTestArea = new System.Windows.Forms.Panel();
            this.makeTestBtn = new System.Windows.Forms.Button();
            this.vocaTestGrid = new System.Windows.Forms.DataGridView();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArea.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.literatureArea.SuspendLayout();
            this.vocaNoteArea.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.showNowTime.SuspendLayout();
            this.alarmArea.SuspendLayout();
            this.panel1.SuspendLayout();
            this.vocaTestArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vocaTestGrid)).BeginInit();
            this.trayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuArea
            // 
            this.menuArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.menuArea.Controls.Add(this.pnlNav);
            this.menuArea.Controls.Add(this.accountBtn);
            this.menuArea.Controls.Add(this.alarmBtn);
            this.menuArea.Controls.Add(this.vocaTestBtn);
            this.menuArea.Controls.Add(this.vocaBtn);
            this.menuArea.Controls.Add(this.homeBtn);
            this.menuArea.Controls.Add(this.panel2);
            this.menuArea.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuArea.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuArea.Location = new System.Drawing.Point(0, 0);
            this.menuArea.Name = "menuArea";
            this.menuArea.Size = new System.Drawing.Size(217, 605);
            this.menuArea.TabIndex = 0;
            this.menuArea.Paint += new System.Windows.Forms.PaintEventHandler(this.menuArea_Paint);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.pnlNav.Location = new System.Drawing.Point(-7, 178);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(10, 92);
            this.pnlNav.TabIndex = 2;
            // 
            // accountBtn
            // 
            this.accountBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.accountBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.accountBtn.FlatAppearance.BorderSize = 0;
            this.accountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountBtn.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountBtn.ForeColor = System.Drawing.Color.White;
            this.accountBtn.Location = new System.Drawing.Point(0, 566);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(217, 39);
            this.accountBtn.TabIndex = 1;
            this.accountBtn.Text = "계정관리";
            this.accountBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.accountBtn.UseVisualStyleBackColor = true;
            this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
            // 
            // alarmBtn
            // 
            this.alarmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.alarmBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.alarmBtn.FlatAppearance.BorderSize = 0;
            this.alarmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alarmBtn.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.alarmBtn.ForeColor = System.Drawing.Color.White;
            this.alarmBtn.Location = new System.Drawing.Point(0, 259);
            this.alarmBtn.Name = "alarmBtn";
            this.alarmBtn.Size = new System.Drawing.Size(217, 39);
            this.alarmBtn.TabIndex = 1;
            this.alarmBtn.Text = "알림 설정";
            this.alarmBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.alarmBtn.UseVisualStyleBackColor = false;
            this.alarmBtn.Click += new System.EventHandler(this.alarmBtn_Click);
            // 
            // vocaTestBtn
            // 
            this.vocaTestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.vocaTestBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.vocaTestBtn.FlatAppearance.BorderSize = 0;
            this.vocaTestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vocaTestBtn.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vocaTestBtn.ForeColor = System.Drawing.Color.White;
            this.vocaTestBtn.Location = new System.Drawing.Point(0, 220);
            this.vocaTestBtn.Name = "vocaTestBtn";
            this.vocaTestBtn.Size = new System.Drawing.Size(217, 39);
            this.vocaTestBtn.TabIndex = 1;
            this.vocaTestBtn.Text = "단어 테스트";
            this.vocaTestBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.vocaTestBtn.UseVisualStyleBackColor = false;
            this.vocaTestBtn.Click += new System.EventHandler(this.vocaTestBtn_Click);
            // 
            // vocaBtn
            // 
            this.vocaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.vocaBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.vocaBtn.FlatAppearance.BorderSize = 0;
            this.vocaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vocaBtn.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vocaBtn.ForeColor = System.Drawing.Color.White;
            this.vocaBtn.Location = new System.Drawing.Point(0, 181);
            this.vocaBtn.Name = "vocaBtn";
            this.vocaBtn.Size = new System.Drawing.Size(217, 39);
            this.vocaBtn.TabIndex = 1;
            this.vocaBtn.Text = "단어장";
            this.vocaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.vocaBtn.UseVisualStyleBackColor = false;
            this.vocaBtn.Click += new System.EventHandler(this.vocaBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.homeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Location = new System.Drawing.Point(0, 142);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(217, 39);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "HOME";
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.rowConnect);
            this.panel2.Controls.Add(this.loginUserIdLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 142);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Word_of_the_Day.Properties.Resources.bag_on_head;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 87);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // rowConnect
            // 
            this.rowConnect.AutoSize = true;
            this.rowConnect.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rowConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.rowConnect.Location = new System.Drawing.Point(108, 82);
            this.rowConnect.Name = "rowConnect";
            this.rowConnect.Size = new System.Drawing.Size(12, 14);
            this.rowConnect.TabIndex = 2;
            this.rowConnect.Text = "-";
            // 
            // loginUserIdLabel
            // 
            this.loginUserIdLabel.AutoSize = true;
            this.loginUserIdLabel.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginUserIdLabel.ForeColor = System.Drawing.Color.White;
            this.loginUserIdLabel.Location = new System.Drawing.Point(106, 56);
            this.loginUserIdLabel.Name = "loginUserIdLabel";
            this.loginUserIdLabel.Size = new System.Drawing.Size(82, 14);
            this.loginUserIdLabel.TabIndex = 1;
            this.loginUserIdLabel.Text = "Anonymous";
            this.loginUserIdLabel.TextChanged += new System.EventHandler(this.loginUserIdLabel_TextChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.closeBtn.ForeColor = System.Drawing.Color.Black;
            this.closeBtn.Location = new System.Drawing.Point(1101, 1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(42, 35);
            this.closeBtn.TabIndex = 12;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // vocaListArea
            // 
            this.vocaListArea.AutoSize = true;
            this.vocaListArea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vocaListArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vocaListArea.Location = new System.Drawing.Point(0, 605);
            this.vocaListArea.Name = "vocaListArea";
            this.vocaListArea.Size = new System.Drawing.Size(1145, 0);
            this.vocaListArea.TabIndex = 29;
            // 
            // columnTitle
            // 
            this.columnTitle.AutoEllipsis = true;
            this.columnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(71)))));
            this.columnTitle.Font = new System.Drawing.Font("나눔스퀘어라운드 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.columnTitle.ForeColor = System.Drawing.Color.White;
            this.columnTitle.Location = new System.Drawing.Point(20, 20);
            this.columnTitle.MaximumSize = new System.Drawing.Size(665, 20);
            this.columnTitle.Name = "columnTitle";
            this.columnTitle.Size = new System.Drawing.Size(648, 20);
            this.columnTitle.TabIndex = 15;
            this.columnTitle.Text = "해외소개 칼럼 타이틀";
            // 
            // columnContent
            // 
            this.columnContent.BackColor = System.Drawing.Color.White;
            this.columnContent.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.columnContent.Location = new System.Drawing.Point(24, 77);
            this.columnContent.Name = "columnContent";
            this.columnContent.ReadOnly = true;
            this.columnContent.Size = new System.Drawing.Size(644, 466);
            this.columnContent.TabIndex = 2;
            this.columnContent.Text = "";
            // 
            // vocaInput
            // 
            this.vocaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.vocaInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vocaInput.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vocaInput.ForeColor = System.Drawing.Color.White;
            this.vocaInput.Location = new System.Drawing.Point(688, 57);
            this.vocaInput.Name = "vocaInput";
            this.vocaInput.Size = new System.Drawing.Size(212, 22);
            this.vocaInput.TabIndex = 22;
            this.vocaInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vocaInput_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(71)))));
            this.label3.Font = new System.Drawing.Font("나눔스퀘어라운드 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(684, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "영어단어 검색";
            // 
            // vacaMeaningInput
            // 
            this.vacaMeaningInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.vacaMeaningInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vacaMeaningInput.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vacaMeaningInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.vacaMeaningInput.Location = new System.Drawing.Point(688, 96);
            this.vacaMeaningInput.Multiline = true;
            this.vacaMeaningInput.Name = "vacaMeaningInput";
            this.vacaMeaningInput.ReadOnly = true;
            this.vacaMeaningInput.Size = new System.Drawing.Size(212, 447);
            this.vacaMeaningInput.TabIndex = 25;
            // 
            // literatureArea
            // 
            this.literatureArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(71)))));
            this.literatureArea.Controls.Add(this.vacaSearchBtn);
            this.literatureArea.Controls.Add(this.vacaMeaningInput);
            this.literatureArea.Controls.Add(this.label3);
            this.literatureArea.Controls.Add(this.vocaInput);
            this.literatureArea.Controls.Add(this.columnContent);
            this.literatureArea.Controls.Add(this.columnTitle);
            this.literatureArea.Location = new System.Drawing.Point(214, 36);
            this.literatureArea.Name = "literatureArea";
            this.literatureArea.Size = new System.Drawing.Size(934, 569);
            this.literatureArea.TabIndex = 25;
            // 
            // vacaSearchBtn
            // 
            this.vacaSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.vacaSearchBtn.BackgroundImage = global::Word_of_the_Day.Properties.Resources.search;
            this.vacaSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vacaSearchBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.vacaSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vacaSearchBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.vacaSearchBtn.Location = new System.Drawing.Point(875, 61);
            this.vacaSearchBtn.Name = "vacaSearchBtn";
            this.vacaSearchBtn.Size = new System.Drawing.Size(16, 16);
            this.vacaSearchBtn.TabIndex = 26;
            this.vacaSearchBtn.UseVisualStyleBackColor = false;
            this.vacaSearchBtn.Click += new System.EventHandler(this.vacaSearchBtn_Click);
            // 
            // vocaDataArea
            // 
            this.vocaDataArea.ColumnCount = 3;
            this.vocaDataArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.25062F));
            this.vocaDataArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.49876F));
            this.vocaDataArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.25062F));
            this.vocaDataArea.Location = new System.Drawing.Point(37, 40);
            this.vocaDataArea.Name = "vocaDataArea";
            this.vocaDataArea.RowCount = 9;
            this.vocaDataArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.vocaDataArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.vocaDataArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.vocaDataArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.vocaDataArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.vocaDataArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.vocaDataArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.vocaDataArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.vocaDataArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.vocaDataArea.Size = new System.Drawing.Size(854, 478);
            this.vocaDataArea.TabIndex = 0;
            // 
            // vocaNoteArea
            // 
            this.vocaNoteArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(71)))));
            this.vocaNoteArea.Controls.Add(this.vocaDataArea);
            this.vocaNoteArea.Location = new System.Drawing.Point(214, 36);
            this.vocaNoteArea.Name = "vocaNoteArea";
            this.vocaNoteArea.Size = new System.Drawing.Size(931, 585);
            this.vocaNoteArea.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어라운드 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "알림 여부";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.afternoon);
            this.groupBox5.Controls.Add(this.morning);
            this.groupBox5.Controls.Add(this.timeMin);
            this.groupBox5.Controls.Add(this.timeHour);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(26, 202);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(866, 90);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "시간 설정";
            // 
            // afternoon
            // 
            this.afternoon.AutoSize = true;
            this.afternoon.Location = new System.Drawing.Point(81, 39);
            this.afternoon.Name = "afternoon";
            this.afternoon.Size = new System.Drawing.Size(49, 18);
            this.afternoon.TabIndex = 16;
            this.afternoon.TabStop = true;
            this.afternoon.Text = "오후";
            this.afternoon.UseVisualStyleBackColor = true;
            // 
            // morning
            // 
            this.morning.AutoSize = true;
            this.morning.Location = new System.Drawing.Point(26, 39);
            this.morning.Name = "morning";
            this.morning.Size = new System.Drawing.Size(49, 18);
            this.morning.TabIndex = 15;
            this.morning.TabStop = true;
            this.morning.Text = "오전";
            this.morning.UseVisualStyleBackColor = true;
            // 
            // timeMin
            // 
            this.timeMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeMin.FormattingEnabled = true;
            this.timeMin.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.timeMin.Location = new System.Drawing.Point(335, 34);
            this.timeMin.Name = "timeMin";
            this.timeMin.Size = new System.Drawing.Size(121, 22);
            this.timeMin.TabIndex = 13;
            // 
            // timeHour
            // 
            this.timeHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeHour.FormattingEnabled = true;
            this.timeHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.timeHour.Location = new System.Drawing.Point(158, 34);
            this.timeHour.Name = "timeHour";
            this.timeHour.Size = new System.Drawing.Size(121, 22);
            this.timeHour.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "분마다";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "시";
            // 
            // showNowTime
            // 
            this.showNowTime.Controls.Add(this.every);
            this.showNowTime.Controls.Add(this.nowTime);
            this.showNowTime.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.showNowTime.ForeColor = System.Drawing.Color.White;
            this.showNowTime.Location = new System.Drawing.Point(25, 111);
            this.showNowTime.Name = "showNowTime";
            this.showNowTime.Size = new System.Drawing.Size(866, 72);
            this.showNowTime.TabIndex = 13;
            this.showNowTime.TabStop = false;
            this.showNowTime.Text = "설정한 알림 시각";
            // 
            // every
            // 
            this.every.AutoSize = true;
            this.every.Location = new System.Drawing.Point(391, 34);
            this.every.Name = "every";
            this.every.Size = new System.Drawing.Size(31, 14);
            this.every.TabIndex = 12;
            this.every.Text = "매일";
            // 
            // nowTime
            // 
            this.nowTime.AutoSize = true;
            this.nowTime.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nowTime.Location = new System.Drawing.Point(428, 26);
            this.nowTime.Name = "nowTime";
            this.nowTime.Size = new System.Drawing.Size(88, 25);
            this.nowTime.TabIndex = 11;
            this.nowTime.Text = "00:00:00";
            this.nowTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setAlramBtn
            // 
            this.setAlramBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.setAlramBtn.Enabled = false;
            this.setAlramBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setAlramBtn.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.setAlramBtn.ForeColor = System.Drawing.Color.White;
            this.setAlramBtn.Location = new System.Drawing.Point(812, 317);
            this.setAlramBtn.Name = "setAlramBtn";
            this.setAlramBtn.Size = new System.Drawing.Size(80, 31);
            this.setAlramBtn.TabIndex = 14;
            this.setAlramBtn.Text = "설정";
            this.setAlramBtn.UseVisualStyleBackColor = false;
            this.setAlramBtn.Click += new System.EventHandler(this.setAlramBtn_Click);
            // 
            // subscribeY
            // 
            this.subscribeY.AutoSize = true;
            this.subscribeY.Font = new System.Drawing.Font("나눔스퀘어라운드 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.subscribeY.ForeColor = System.Drawing.Color.White;
            this.subscribeY.Location = new System.Drawing.Point(135, 20);
            this.subscribeY.Name = "subscribeY";
            this.subscribeY.Size = new System.Drawing.Size(70, 30);
            this.subscribeY.TabIndex = 17;
            this.subscribeY.Text = "Yes";
            this.subscribeY.UseVisualStyleBackColor = true;
            this.subscribeY.Click += new System.EventHandler(this.subscribeY_Click);
            // 
            // subscribeN
            // 
            this.subscribeN.AutoSize = true;
            this.subscribeN.Checked = true;
            this.subscribeN.Font = new System.Drawing.Font("나눔스퀘어라운드 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.subscribeN.ForeColor = System.Drawing.Color.White;
            this.subscribeN.Location = new System.Drawing.Point(213, 20);
            this.subscribeN.Name = "subscribeN";
            this.subscribeN.Size = new System.Drawing.Size(62, 30);
            this.subscribeN.TabIndex = 18;
            this.subscribeN.TabStop = true;
            this.subscribeN.Text = "No";
            this.subscribeN.UseVisualStyleBackColor = true;
            this.subscribeN.Click += new System.EventHandler(this.subscribeN_Click);
            // 
            // alarmArea
            // 
            this.alarmArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(71)))));
            this.alarmArea.Controls.Add(this.panel1);
            this.alarmArea.Controls.Add(this.setAlramBtn);
            this.alarmArea.Controls.Add(this.showNowTime);
            this.alarmArea.Controls.Add(this.groupBox5);
            this.alarmArea.Location = new System.Drawing.Point(217, 36);
            this.alarmArea.Name = "alarmArea";
            this.alarmArea.Size = new System.Drawing.Size(931, 569);
            this.alarmArea.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.subscribeN);
            this.panel1.Controls.Add(this.subscribeY);
            this.panel1.Location = new System.Drawing.Point(26, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 63);
            this.panel1.TabIndex = 19;
            // 
            // miniumBtn
            // 
            this.miniumBtn.BackColor = System.Drawing.Color.White;
            this.miniumBtn.FlatAppearance.BorderSize = 0;
            this.miniumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniumBtn.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.miniumBtn.ForeColor = System.Drawing.Color.Black;
            this.miniumBtn.Location = new System.Drawing.Point(1053, 0);
            this.miniumBtn.Name = "miniumBtn";
            this.miniumBtn.Size = new System.Drawing.Size(42, 35);
            this.miniumBtn.TabIndex = 41;
            this.miniumBtn.Text = "ㅡ";
            this.miniumBtn.UseVisualStyleBackColor = false;
            this.miniumBtn.Click += new System.EventHandler(this.miniumBtn_Click);
            // 
            // vocaTestArea
            // 
            this.vocaTestArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(71)))));
            this.vocaTestArea.Controls.Add(this.makeTestBtn);
            this.vocaTestArea.Controls.Add(this.vocaTestGrid);
            this.vocaTestArea.Location = new System.Drawing.Point(208, 36);
            this.vocaTestArea.Name = "vocaTestArea";
            this.vocaTestArea.Size = new System.Drawing.Size(943, 585);
            this.vocaTestArea.TabIndex = 20;
            // 
            // makeTestBtn
            // 
            this.makeTestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.makeTestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.makeTestBtn.Enabled = false;
            this.makeTestBtn.FlatAppearance.BorderSize = 0;
            this.makeTestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeTestBtn.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.makeTestBtn.ForeColor = System.Drawing.Color.White;
            this.makeTestBtn.Location = new System.Drawing.Point(389, 511);
            this.makeTestBtn.Name = "makeTestBtn";
            this.makeTestBtn.Size = new System.Drawing.Size(149, 35);
            this.makeTestBtn.TabIndex = 23;
            this.makeTestBtn.Text = "채점하기";
            this.makeTestBtn.UseVisualStyleBackColor = false;
            this.makeTestBtn.Click += new System.EventHandler(this.makeTestBtn_Click);
            // 
            // vocaTestGrid
            // 
            this.vocaTestGrid.AllowUserToAddRows = false;
            this.vocaTestGrid.AllowUserToDeleteRows = false;
            this.vocaTestGrid.BackgroundColor = System.Drawing.Color.White;
            this.vocaTestGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vocaTestGrid.Location = new System.Drawing.Point(133, 23);
            this.vocaTestGrid.Name = "vocaTestGrid";
            this.vocaTestGrid.RowTemplate.Height = 23;
            this.vocaTestGrid.Size = new System.Drawing.Size(648, 461);
            this.vocaTestGrid.TabIndex = 0;
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayContextMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "칼럼보카";
            this.trayIcon.Visible = true;
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.trayContextMenu.Name = "trayContextMenu";
            this.trayContextMenu.Size = new System.Drawing.Size(99, 48);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1145, 605);
            this.Controls.Add(this.menuArea);
            this.Controls.Add(this.vocaTestArea);
            this.Controls.Add(this.miniumBtn);
            this.Controls.Add(this.alarmArea);
            this.Controls.Add(this.vocaNoteArea);
            this.Controls.Add(this.vocaListArea);
            this.Controls.Add(this.literatureArea);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "x";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuArea.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.literatureArea.ResumeLayout(false);
            this.literatureArea.PerformLayout();
            this.vocaNoteArea.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.showNowTime.ResumeLayout(false);
            this.showNowTime.PerformLayout();
            this.alarmArea.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.vocaTestArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vocaTestGrid)).EndInit();
            this.trayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuArea;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label rowConnect;
        private System.Windows.Forms.Label loginUserIdLabel;
        private System.Windows.Forms.Button accountBtn;
        private System.Windows.Forms.Button alarmBtn;
        private System.Windows.Forms.Button vocaTestBtn;
        private System.Windows.Forms.Button vocaBtn;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel vocaListArea;
        private System.Windows.Forms.Label columnTitle;
        private System.Windows.Forms.RichTextBox columnContent;
        private System.Windows.Forms.TextBox vocaInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vacaMeaningInput;
        private System.Windows.Forms.Panel literatureArea;
        private System.Windows.Forms.Button vacaSearchBtn;
        private System.Windows.Forms.TableLayoutPanel vocaDataArea;
        private System.Windows.Forms.Panel vocaNoteArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton afternoon;
        private System.Windows.Forms.RadioButton morning;
        private System.Windows.Forms.ComboBox timeMin;
        private System.Windows.Forms.ComboBox timeHour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox showNowTime;
        private System.Windows.Forms.Label every;
        private System.Windows.Forms.Label nowTime;
        private System.Windows.Forms.Button setAlramBtn;
        private System.Windows.Forms.RadioButton subscribeY;
        private System.Windows.Forms.RadioButton subscribeN;
        private System.Windows.Forms.Panel alarmArea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button miniumBtn;
        private System.Windows.Forms.Panel vocaTestArea;
        private System.Windows.Forms.DataGridView vocaTestGrid;
        private System.Windows.Forms.Button makeTestBtn;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
    }
}

