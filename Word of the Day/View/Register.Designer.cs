
namespace Word_of_the_Day.View
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.overlapCheckBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addInfoBtn = new System.Windows.Forms.Button();
            this.newPw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.infoCheck = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.warnLabel = new System.Windows.Forms.Label();
            this.warnPwLabel = new System.Windows.Forms.Label();
            this.showPwdBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // overlapCheckBtn
            // 
            this.overlapCheckBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(246)))));
            this.overlapCheckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overlapCheckBtn.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.overlapCheckBtn.Location = new System.Drawing.Point(285, 209);
            this.overlapCheckBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.overlapCheckBtn.Name = "overlapCheckBtn";
            this.overlapCheckBtn.Size = new System.Drawing.Size(75, 30);
            this.overlapCheckBtn.TabIndex = 6;
            this.overlapCheckBtn.Text = "중복검사";
            this.overlapCheckBtn.UseVisualStyleBackColor = false;
            this.overlapCheckBtn.Click += new System.EventHandler(this.overlapCheck_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Word_of_the_Day.Properties.Resources.dictionary;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(109, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 140);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // addInfoBtn
            // 
            this.addInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(246)))));
            this.addInfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addInfoBtn.Enabled = false;
            this.addInfoBtn.FlatAppearance.BorderSize = 0;
            this.addInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addInfoBtn.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addInfoBtn.ForeColor = System.Drawing.Color.Black;
            this.addInfoBtn.Location = new System.Drawing.Point(215, 405);
            this.addInfoBtn.Name = "addInfoBtn";
            this.addInfoBtn.Size = new System.Drawing.Size(145, 35);
            this.addInfoBtn.TabIndex = 19;
            this.addInfoBtn.Text = "가입";
            this.addInfoBtn.UseVisualStyleBackColor = false;
            this.addInfoBtn.Click += new System.EventHandler(this.addInfoBtn_Click);
            // 
            // newPw
            // 
            this.newPw.BackColor = System.Drawing.Color.White;
            this.newPw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPw.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.newPw.Location = new System.Drawing.Point(45, 309);
            this.newPw.Multiline = true;
            this.newPw.Name = "newPw";
            this.newPw.PasswordChar = '•';
            this.newPw.Size = new System.Drawing.Size(267, 28);
            this.newPw.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어라운드 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "PASSWORD";
            // 
            // newId
            // 
            this.newId.BackColor = System.Drawing.Color.White;
            this.newId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newId.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.newId.Location = new System.Drawing.Point(45, 209);
            this.newId.Multiline = true;
            this.newId.Name = "newId";
            this.newId.Size = new System.Drawing.Size(234, 28);
            this.newId.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어라운드 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(49, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID";
            // 
            // infoCheck
            // 
            this.infoCheck.AutoSize = true;
            this.infoCheck.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.infoCheck.ForeColor = System.Drawing.Color.Red;
            this.infoCheck.Location = new System.Drawing.Point(42, 321);
            this.infoCheck.Name = "infoCheck";
            this.infoCheck.Size = new System.Drawing.Size(0, 15);
            this.infoCheck.TabIndex = 14;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(45, 405);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(149, 35);
            this.cancelBtn.TabIndex = 22;
            this.cancelBtn.Text = "취소";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // warnLabel
            // 
            this.warnLabel.AutoSize = true;
            this.warnLabel.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.warnLabel.ForeColor = System.Drawing.Color.Red;
            this.warnLabel.Location = new System.Drawing.Point(46, 248);
            this.warnLabel.Name = "warnLabel";
            this.warnLabel.Size = new System.Drawing.Size(0, 14);
            this.warnLabel.TabIndex = 23;
            // 
            // warnPwLabel
            // 
            this.warnPwLabel.AutoSize = true;
            this.warnPwLabel.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.warnPwLabel.ForeColor = System.Drawing.Color.Red;
            this.warnPwLabel.Location = new System.Drawing.Point(50, 351);
            this.warnPwLabel.Name = "warnPwLabel";
            this.warnPwLabel.Size = new System.Drawing.Size(0, 14);
            this.warnPwLabel.TabIndex = 25;
            // 
            // showPwdBtn
            // 
            this.showPwdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(246)))));
            this.showPwdBtn.BackgroundImage = global::Word_of_the_Day.Properties.Resources._private;
            this.showPwdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showPwdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPwdBtn.Location = new System.Drawing.Point(318, 309);
            this.showPwdBtn.Name = "showPwdBtn";
            this.showPwdBtn.Size = new System.Drawing.Size(35, 30);
            this.showPwdBtn.TabIndex = 26;
            this.showPwdBtn.UseVisualStyleBackColor = false;
            this.showPwdBtn.Click += new System.EventHandler(this.showPwdBtn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(399, 466);
            this.Controls.Add(this.showPwdBtn);
            this.Controls.Add(this.warnPwLabel);
            this.Controls.Add(this.warnLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addInfoBtn);
            this.Controls.Add(this.newPw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.infoCheck);
            this.Controls.Add(this.overlapCheckBtn);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원가입";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button overlapCheckBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addInfoBtn;
        private System.Windows.Forms.TextBox newPw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label infoCheck;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label warnLabel;
        private System.Windows.Forms.Label warnPwLabel;
        private System.Windows.Forms.Button showPwdBtn;
    }
}