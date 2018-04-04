using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MereFille
{
    public partial class FFille : Form
    {
        private string monNom;
        private FMere maMere;
        public FFille(FMere maMere,int numero)
        {
            InitializeComponent();
            this.Text = "Fille n°" + numero;
            this.monNom = this.Text;
            this.maMere = maMere;
            this.tbFille.TextChanged += new EventHandler(tbFille_textchanged);
            this.FormClosing += new FormClosingEventHandler(FFille_FormClosing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        void FFille_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            MessageBox.Show("aled");
        }

        private void btnChanger_Click(object sender, EventArgs e)
        {
             this.Text=tbFille.Text;
        }

        private void btnMaMere_Click(object sender, EventArgs e)
        {
            MessageBox.Show( maMere.GetMaMere());
        }

        private void FFille_Load(object sender, EventArgs e)
        {
            MessageBox.Show("evenement load sur " + this.monNom);
        }
        void tbFille_textchanged(object sender, EventArgs e)
        { 
            this.Text = this.tbFille.Text;
        }
        void btnMaMere_click(object sender, EventArgs e)
        {

            this.Text = tbFille.Text;
        }

    }
}
