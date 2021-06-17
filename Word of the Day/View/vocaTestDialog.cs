using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_of_the_Day.View
{
    public partial class vocaTestDialog : Form
    {
        private MainForm mainForm;

        public vocaTestDialog()
        {
            InitializeComponent();
        }

        public vocaTestDialog(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void vocaTestBtn_Click(object sender, EventArgs e)
        {
            mainForm.paintVocaTest("S");
            this.Hide();
        }

        private void vocaMeanBtn_Click(object sender, EventArgs e)
        {
            mainForm.paintVocaTest("M");
            this.Hide();
        }

        private void vocaTestDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
