namespace MultApps.Client.Windows
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnAbrirFormPesoIdeal = new System.Windows.Forms.Button();
            this.btnAbrirFormMatriculaAluno = new System.Windows.Forms.Button();
            this.btnAbrirFormReajusteSalarial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirFormPesoIdeal
            // 
            this.btnAbrirFormPesoIdeal.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAbrirFormPesoIdeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirFormPesoIdeal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirFormPesoIdeal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAbrirFormPesoIdeal.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirFormPesoIdeal.Image")));
            this.btnAbrirFormPesoIdeal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbrirFormPesoIdeal.Location = new System.Drawing.Point(21, 23);
            this.btnAbrirFormPesoIdeal.Name = "btnAbrirFormPesoIdeal";
            this.btnAbrirFormPesoIdeal.Size = new System.Drawing.Size(95, 108);
            this.btnAbrirFormPesoIdeal.TabIndex = 0;
            this.btnAbrirFormPesoIdeal.Text = "Peso Ideal";
            this.btnAbrirFormPesoIdeal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirFormPesoIdeal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrirFormPesoIdeal.UseVisualStyleBackColor = true;
            this.btnAbrirFormPesoIdeal.Click += new System.EventHandler(this.btnAbrirFormPesoIdeal_Click);
            // 
            // btnAbrirFormMatriculaAluno
            // 
            this.btnAbrirFormMatriculaAluno.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAbrirFormMatriculaAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirFormMatriculaAluno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirFormMatriculaAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirFormMatriculaAluno.Image")));
            this.btnAbrirFormMatriculaAluno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbrirFormMatriculaAluno.Location = new System.Drawing.Point(125, 23);
            this.btnAbrirFormMatriculaAluno.Name = "btnAbrirFormMatriculaAluno";
            this.btnAbrirFormMatriculaAluno.Size = new System.Drawing.Size(95, 108);
            this.btnAbrirFormMatriculaAluno.TabIndex = 1;
            this.btnAbrirFormMatriculaAluno.Text = "Matricula de Aluno";
            this.btnAbrirFormMatriculaAluno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirFormMatriculaAluno.UseVisualStyleBackColor = true;
            this.btnAbrirFormMatriculaAluno.Click += new System.EventHandler(this.btnAbrirFormMatriculaAluno_Click);
            // 
            // btnAbrirFormReajusteSalarial
            // 
            this.btnAbrirFormReajusteSalarial.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAbrirFormReajusteSalarial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirFormReajusteSalarial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirFormReajusteSalarial.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirFormReajusteSalarial.Image")));
            this.btnAbrirFormReajusteSalarial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbrirFormReajusteSalarial.Location = new System.Drawing.Point(229, 23);
            this.btnAbrirFormReajusteSalarial.Name = "btnAbrirFormReajusteSalarial";
            this.btnAbrirFormReajusteSalarial.Size = new System.Drawing.Size(95, 108);
            this.btnAbrirFormReajusteSalarial.TabIndex = 2;
            this.btnAbrirFormReajusteSalarial.Text = "Reajuste Salarial";
            this.btnAbrirFormReajusteSalarial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirFormReajusteSalarial.UseVisualStyleBackColor = true;
            this.btnAbrirFormReajusteSalarial.Click += new System.EventHandler(this.btnAbrirFormReajusteSalarial_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(353, 188);
            this.Controls.Add(this.btnAbrirFormReajusteSalarial);
            this.Controls.Add(this.btnAbrirFormMatriculaAluno);
            this.Controls.Add(this.btnAbrirFormPesoIdeal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiApps";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAbrirFormPesoIdeal;
        private Button btnAbrirFormMatriculaAluno;
        private Button btnAbrirFormReajusteSalarial;
    }
}