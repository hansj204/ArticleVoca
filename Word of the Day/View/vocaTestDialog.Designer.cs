
namespace Word_of_the_Day.View
{
    partial class vocaTestDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vocaTestDialog));
            this.vocaMeanBtn = new System.Windows.Forms.Button();
            this.vocaTestBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vocaMeanBtn
            // 
            this.vocaMeanBtn.BackColor = System.Drawing.Color.White;
            this.vocaMeanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vocaMeanBtn.FlatAppearance.BorderSize = 0;
            this.vocaMeanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vocaMeanBtn.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vocaMeanBtn.ForeColor = System.Drawing.Color.Black;
            this.vocaMeanBtn.Location = new System.Drawing.Point(248, 115);
            this.vocaMeanBtn.Name = "vocaMeanBtn";
            this.vocaMeanBtn.Size = new System.Drawing.Size(191, 35);
            this.vocaMeanBtn.TabIndex = 10;
            this.vocaMeanBtn.Text = "단어 뜻 테스트";
            this.vocaMeanBtn.UseVisualStyleBackColor = false;
            this.vocaMeanBtn.Click += new System.EventHandler(this.vocaMeanBtn_Click);
            // 
            // vocaTestBtn
            // 
            this.vocaTestBtn.BackColor = System.Drawing.Color.White;
            this.vocaTestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vocaTestBtn.FlatAppearance.BorderSize = 0;
            this.vocaTestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vocaTestBtn.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vocaTestBtn.ForeColor = System.Drawing.Color.Black;
            this.vocaTestBtn.Location = new System.Drawing.Point(31, 115);
            this.vocaTestBtn.Name = "vocaTestBtn";
            this.vocaTestBtn.Size = new System.Drawing.Size(191, 35);
            this.vocaTestBtn.TabIndex = 11;
            this.vocaTestBtn.Text = "단어 테스트";
            this.vocaTestBtn.UseVisualStyleBackColor = false;
            this.vocaTestBtn.Click += new System.EventHandler(this.vocaTestBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어라운드 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(101, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "진행할 테스트 종류를 선택해주세요";
            // 
            // vocaTestDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(474, 197);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vocaTestBtn);
            this.Controls.Add(this.vocaMeanBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vocaTestDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "테스트 타입 선택";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vocaMeanBtn;
        private System.Windows.Forms.Button vocaTestBtn;
        private System.Windows.Forms.Label label4;
    }
}