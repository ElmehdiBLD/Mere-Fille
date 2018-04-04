namespace MereFille
{
    partial class FFille
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
            this.lbFille = new System.Windows.Forms.Label();
            this.tbFille = new System.Windows.Forms.TextBox();
            this.btnChanger = new System.Windows.Forms.Button();
            this.btnMaMere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFille
            // 
            this.lbFille.AutoSize = true;
            this.lbFille.Location = new System.Drawing.Point(13, 54);
            this.lbFille.Name = "lbFille";
            this.lbFille.Size = new System.Drawing.Size(104, 13);
            this.lbFille.TabIndex = 0;
            this.lbFille.Text = "je change de nom :  ";
            // 
            // tbFille
            // 
            this.tbFille.Location = new System.Drawing.Point(111, 51);
            this.tbFille.Name = "tbFille";
            this.tbFille.Size = new System.Drawing.Size(100, 20);
            this.tbFille.TabIndex = 1;
            
            // 
            // btnChanger
            // 
            this.btnChanger.Location = new System.Drawing.Point(220, 49);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(75, 23);
            this.btnChanger.TabIndex = 2;
            this.btnChanger.Text = "Changer";
            this.btnChanger.UseVisualStyleBackColor = true;
            this.btnChanger.Click += new System.EventHandler(this.btnChanger_Click);
            // 
            // btnMaMere
            // 
            this.btnMaMere.Location = new System.Drawing.Point(111, 118);
            this.btnMaMere.Name = "btnMaMere";
            this.btnMaMere.Size = new System.Drawing.Size(75, 23);
            this.btnMaMere.TabIndex = 3;
            this.btnMaMere.Text = "Ma Mere";
            this.btnMaMere.UseVisualStyleBackColor = true;
            this.btnMaMere.Click += new System.EventHandler(this.btnMaMere_Click);
            // 
            // FFille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 177);
            this.Controls.Add(this.btnMaMere);
            this.Controls.Add(this.btnChanger);
            this.Controls.Add(this.tbFille);
            this.Controls.Add(this.lbFille);
            this.Name = "FFille";
            this.Text = "FFille";
            this.Load += new System.EventHandler(this.FFille_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFille;
        private System.Windows.Forms.TextBox tbFille;
        private System.Windows.Forms.Button btnChanger;
        private System.Windows.Forms.Button btnMaMere;
    }
}