using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToBase64Hash_KızılAslan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] veridizim = ASCIIEncoding.ASCII.GetBytes(rchtxtMetin.Text);
                rchtxtSifre.Text = Convert.ToBase64String(veridizim);
            }
            catch (Exception Aciklama)
            {
                MessageBox.Show(Aciklama.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] cozulenvarilerim = Convert.FromBase64String(rchtxtSifre.Text);
                rchtxtMetin.Text = ASCIIEncoding.ASCII.GetString(cozulenvarilerim);
            }
            catch (Exception Aciklama)
            {
                MessageBox.Show(Aciklama.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
