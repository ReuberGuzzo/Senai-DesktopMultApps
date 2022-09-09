namespace MultApps.Client.Windows.Funcionalidades
{
    partial class frmPesoIdeal
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPesoIdeal = new System.Windows.Forms.Label();
            this.grbSexo = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.grbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(271, 13);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(42, 15);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura:";
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.AutoSize = true;
            this.lblPesoIdeal.Location = new System.Drawing.Point(143, 95);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(63, 15);
            this.lblPesoIdeal.TabIndex = 4;
            this.lblPesoIdeal.Text = "Peso Ideal:";
            // 
            // grbSexo
            // 
            this.grbSexo.Controls.Add(this.rdbFeminino);
            this.grbSexo.Controls.Add(this.rdbMasculino);
            this.grbSexo.Location = new System.Drawing.Point(21, 21);
            this.grbSexo.Name = "grbSexo";
            this.grbSexo.Size = new System.Drawing.Size(230, 71);
            this.grbSexo.TabIndex = 5;
            this.grbSexo.TabStop = false;
            this.grbSexo.Text = "Sexo";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(6, 32);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            this.rdbMasculino.CheckedChanged += new System.EventHandler(this.rdbMasculino_CheckedChanged);
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(122, 32);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(75, 19);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // txtAltura
            // 
            this.txtAltura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAltura.Location = new System.Drawing.Point(257, 40);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(80, 16);
            this.txtAltura.TabIndex = 6;
            // 
            // frmPesoIdeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 161);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.grbSexo);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.lblAltura);
            this.Name = "frmPesoIdeal";
            this.Text = "Peso Ideal";
            this.grbSexo.ResumeLayout(false);
            this.grbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAltura;
        private Label lblPesoIdeal;
        private GroupBox grbSexo;
        private RadioButton rdbFeminino;
        private RadioButton rdbMasculino;
        private TextBox txtAltura;
    }
}