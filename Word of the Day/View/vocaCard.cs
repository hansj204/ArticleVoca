using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_of_the_Day.View
{
    public partial class vocaCard : Form
    {

        public vocaCard(string vocaName, string vocaMeaning)
        {
            InitializeComponent();
            voca.Text = vocaName;
            vocaMean.Text = vocaMeaning;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
