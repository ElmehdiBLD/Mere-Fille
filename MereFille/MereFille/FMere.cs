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
    public partial class FMere : Form
    {
        private List<FFille> lesFilles;
        private int nombreFille;
        private string nomMere = "ah";
        public FMere()
        {
            InitializeComponent();
            this.Text = "Papa";
            this.nomMere = "Papa";
            lesFilles = new List<FFille>();
            btnNew.Click += new EventHandler(btnNew_Click);
            btnNew.Click += new EventHandler(btnNew_Click_Message);
            btnShow.Click += new EventHandler(btnShow_Click);
            btnHide.Click += new EventHandler(btnHide_Click);
            btnDialog.Click += new EventHandler(btnDialog_Click);
            btnClose.Click += new EventHandler(btnClose_Click);

        }

        void btnClose_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Close();
            }
        }

        void btnDialog_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].ShowDialog();
            }
        }

        void btnHide_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Hide();
            }

        }

        void btnNew_Click(object sender, EventArgs e)
        {
            FFille nouvelleFille;
            this.nombreFille = this.nombreFille + 1;
            nouvelleFille = new FFille(this, nombreFille);
            lesFilles.Add(nouvelleFille);
            lbLesFilles.Items.Add("Fille n°" + this.nombreFille);
        }
        void btnNew_Click_Message(object sender, EventArgs e)
        {
            MessageBox.Show("une fenetre fille a été instanciée");
            
        }
        public string GetMaMere()
        {
            return this.nomMere;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Show();
            }
        }
        void nouvelleFille_Textchanged(object sender ,EventArgs e){
            FFille maFille =(FFille)sender;
            MaFilleChangeDeNom(maFille.Text,maFille);
        }
        public void MaFilleChangeDeNom(string nouveaunom, FFille MaFille)
        {
            int position = lesFilles.IndexOf(MaFille);
            lbLesFilles.Items[position] = nouveaunom;
        }

    }
    }

