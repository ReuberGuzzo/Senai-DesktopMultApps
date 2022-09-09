namespace MultApps.Client.Windows.Funcionalidades
{
    partial class frmMatriculaAluno
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblAnoNascimento = new System.Windows.Forms.Label();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblInserirCategoria = new System.Windows.Forms.Label();
            this.dtAnoNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblHoje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(14, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "&Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(386, 23);
            this.txtNome.TabIndex = 1;
            // 
            // lblAnoNascimento
            // 
            this.lblAnoNascimento.AutoSize = true;
            this.lblAnoNascimento.Location = new System.Drawing.Point(12, 60);
            this.lblAnoNascimento.Name = "lblAnoNascimento";
            this.lblAnoNascimento.Size = new System.Drawing.Size(96, 15);
            this.lblAnoNascimento.TabIndex = 2;
            this.lblAnoNascimento.Text = "Ano Nascimento";
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(12, 109);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(169, 25);
            this.btnCategoria.TabIndex = 6;
            this.btnCategoria.Text = "Identificar Categoria";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(223, 114);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(58, 15);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblInserirCategoria
            // 
            this.lblInserirCategoria.BackColor = System.Drawing.Color.Yellow;
            this.lblInserirCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInserirCategoria.Location = new System.Drawing.Point(287, 109);
            this.lblInserirCategoria.Name = "lblInserirCategoria";
            this.lblInserirCategoria.Size = new System.Drawing.Size(161, 23);
            this.lblInserirCategoria.TabIndex = 8;
            this.lblInserirCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtAnoNascimento
            // 
            this.dtAnoNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAnoNascimento.Location = new System.Drawing.Point(114, 57);
            this.dtAnoNascimento.Name = "dtAnoNascimento";
            this.dtAnoNascimento.Size = new System.Drawing.Size(99, 23);
            this.dtAnoNascimento.TabIndex = 9;
            // 
            // lblHoje
            // 
            this.lblHoje.AutoSize = true;
            this.lblHoje.Location = new System.Drawing.Point(245, 60);
            this.lblHoje.Name = "lblHoje";
            this.lblHoje.Size = new System.Drawing.Size(44, 15);
            this.lblHoje.TabIndex = 11;
            this.lblHoje.Text = "Hoje é:";
            // 
            // frmMatriculaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 161);
            this.Controls.Add(this.lblHoje);
            this.Controls.Add(this.dtAnoNascimento);
            this.Controls.Add(this.lblInserirCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.lblAnoNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmMatriculaAluno";
            this.Text = "frmMatriculaAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblAnoNascimento;
        private Button btnCategoria;
        private Label lblCategoria;
        private Label lblInserirCategoria;
        private DateTimePicker dtAnoNascimento;
        private Label lblHoje;
    }
}