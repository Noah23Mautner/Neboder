using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neboder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_izracunaj_Click(object sender, EventArgs e)
        {
            neboder neboder = new neboder();// stvaramo novi objekt neboder
            neboder.Brojkatova = Convert.ToInt32(txtbrojkatova.Text);//Upisane brojke iz stringa pretvara u int
            txtVisinazgrade.Text = neboder.IzracunajVisinu(neboder.Brojkatova).ToString();//ispisuje  visinu zgrade
        }
    }
}
