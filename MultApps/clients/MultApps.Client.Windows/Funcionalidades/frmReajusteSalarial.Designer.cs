namespace MultApps.Client.Windows.Funcionalidades
{
    partial class frmReajusteSalarial
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
            this.components = new System.ComponentModel.Container();
            this.lblSalarioMin = new System.Windows.Forms.Label();
            this.lblHorasTrabalhadas = new System.Windows.Forms.Label();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.grbCategoria = new System.Windows.Forms.GroupBox();
            this.rdbVeterano = new System.Windows.Forms.RadioButton();
            this.rdbCalouro = new System.Windows.Forms.RadioButton();
            this.grbTurno = new System.Windows.Forms.GroupBox();
            this.rdbNoturno = new System.Windows.Forms.RadioButton();
            this.rdbVespertino = new System.Windows.Forms.RadioButton();
            this.rdbMatutino = new System.Windows.Forms.RadioButton();
            this.lbxResumo = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSituacaoEstagiario = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grbCategoria.SuspendLayout();
            this.grbTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalarioMin
            // 
            this.lblSalarioMin.AutoSize = true;
            this.lblSalarioMin.Location = new System.Drawing.Point(21, 26);
            this.lblSalarioMin.Name = "lblSalarioMin";
            this.lblSalarioMin.Size = new System.Drawing.Size(87, 15);
            this.lblSalarioMin.TabIndex = 0;
            this.lblSalarioMin.Text = "Salario Minimo";
            // 
            // lblHorasTrabalhadas
            // 
            this.lblHorasTrabalhadas.AutoSize = true;
            this.lblHorasTrabalhadas.Location = new System.Drawing.Point(22, 58);
            this.lblHorasTrabalhadas.Name = "lblHorasTrabalhadas";
            this.lblHorasTrabalhadas.Size = new System.Drawing.Size(103, 15);
            this.lblHorasTrabalhadas.TabIndex = 1;
            this.lblHorasTrabalhadas.Text = "Horas Trabalhadas";
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Location = new System.Drawing.Point(136, 18);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(100, 23);
            this.txtSalarioMinimo.TabIndex = 2;
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(136, 50);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(100, 23);
            this.txtHorasTrabalhadas.TabIndex = 3;
            // 
            // grbCategoria
            // 
            this.grbCategoria.Controls.Add(this.rdbVeterano);
            this.grbCategoria.Controls.Add(this.rdbCalouro);
            this.grbCategoria.Location = new System.Drawing.Point(22, 93);
            this.grbCategoria.Name = "grbCategoria";
            this.grbCategoria.Size = new System.Drawing.Size(191, 52);
            this.grbCategoria.TabIndex = 4;
            this.grbCategoria.TabStop = false;
            this.grbCategoria.Text = "Categoria";
            // 
            // rdbVeterano
            // 
            this.rdbVeterano.AutoSize = true;
            this.rdbVeterano.Location = new System.Drawing.Point(110, 22);
            this.rdbVeterano.Name = "rdbVeterano";
            this.rdbVeterano.Size = new System.Drawing.Size(71, 19);
            this.rdbVeterano.TabIndex = 1;
            this.rdbVeterano.Text = "Veterano";
            this.rdbVeterano.UseVisualStyleBackColor = true;
            // 
            // rdbCalouro
            // 
            this.rdbCalouro.AutoSize = true;
            this.rdbCalouro.Checked = true;
            this.rdbCalouro.Location = new System.Drawing.Point(6, 22);
            this.rdbCalouro.Name = "rdbCalouro";
            this.rdbCalouro.Size = new System.Drawing.Size(67, 19);
            this.rdbCalouro.TabIndex = 0;
            this.rdbCalouro.TabStop = true;
            this.rdbCalouro.Text = "Calouro";
            this.rdbCalouro.UseVisualStyleBackColor = true;
            // 
            // grbTurno
            // 
            this.grbTurno.Controls.Add(this.rdbNoturno);
            this.grbTurno.Controls.Add(this.rdbVespertino);
            this.grbTurno.Controls.Add(this.rdbMatutino);
            this.grbTurno.Location = new System.Drawing.Point(242, 18);
            this.grbTurno.Name = "grbTurno";
            this.grbTurno.Size = new System.Drawing.Size(93, 110);
            this.grbTurno.TabIndex = 5;
            this.grbTurno.TabStop = false;
            this.grbTurno.Text = "Turno";
            // 
            // rdbNoturno
            // 
            this.rdbNoturno.AutoSize = true;
            this.rdbNoturno.Location = new System.Drawing.Point(7, 74);
            this.rdbNoturno.Name = "rdbNoturno";
            this.rdbNoturno.Size = new System.Drawing.Size(70, 19);
            this.rdbNoturno.TabIndex = 2;
            this.rdbNoturno.Text = "Noturno";
            this.rdbNoturno.UseVisualStyleBackColor = true;
            // 
            // rdbVespertino
            // 
            this.rdbVespertino.AutoSize = true;
            this.rdbVespertino.Location = new System.Drawing.Point(7, 49);
            this.rdbVespertino.Name = "rdbVespertino";
            this.rdbVespertino.Size = new System.Drawing.Size(80, 19);
            this.rdbVespertino.TabIndex = 1;
            this.rdbVespertino.Text = "Vespertino";
            this.rdbVespertino.UseVisualStyleBackColor = true;
            // 
            // rdbMatutino
            // 
            this.rdbMatutino.AutoSize = true;
            this.rdbMatutino.Checked = true;
            this.rdbMatutino.Location = new System.Drawing.Point(7, 24);
            this.rdbMatutino.Name = "rdbMatutino";
            this.rdbMatutino.Size = new System.Drawing.Size(74, 19);
            this.rdbMatutino.TabIndex = 0;
            this.rdbMatutino.TabStop = true;
            this.rdbMatutino.Text = "Matutino";
            this.rdbMatutino.UseVisualStyleBackColor = true;
            // 
            // lbxResumo
            // 
            this.lbxResumo.BackColor = System.Drawing.Color.White;
            this.lbxResumo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxResumo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbxResumo.FormattingEnabled = true;
            this.lbxResumo.ItemHeight = 15;
            this.lbxResumo.Location = new System.Drawing.Point(28, 151);
            this.lbxResumo.MultiColumn = true;
            this.lbxResumo.Name = "lbxResumo";
            this.lbxResumo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxResumo.Size = new System.Drawing.Size(313, 124);
            this.lbxResumo.TabIndex = 6;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ajuda";
            // 
            // txtSituacaoEstagiario
            // 
            this.txtSituacaoEstagiario.BackColor = System.Drawing.Color.Yellow;
            this.txtSituacaoEstagiario.Location = new System.Drawing.Point(28, 300);
            this.txtSituacaoEstagiario.Name = "txtSituacaoEstagiario";
            this.txtSituacaoEstagiario.Size = new System.Drawing.Size(208, 23);
            this.txtSituacaoEstagiario.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(247, 300);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmReajusteSalarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(358, 343);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSituacaoEstagiario);
            this.Controls.Add(this.lbxResumo);
            this.Controls.Add(this.grbTurno);
            this.Controls.Add(this.grbCategoria);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.lblHorasTrabalhadas);
            this.Controls.Add(this.lblSalarioMin);
            this.Name = "frmReajusteSalarial";
            this.Text = "Reajuste Salarial";
            this.grbCategoria.ResumeLayout(false);
            this.grbCategoria.PerformLayout();
            this.grbTurno.ResumeLayout(false);
            this.grbTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSalarioMin;
        private Label lblHorasTrabalhadas;
        private TextBox txtSalarioMinimo;
        private TextBox txtHorasTrabalhadas;
        private GroupBox grbCategoria;
        private RadioButton rdbVeterano;
        private RadioButton rdbCalouro;
        private GroupBox grbTurno;
        private RadioButton rdbNoturno;
        private RadioButton rdbVespertino;
        private RadioButton rdbMatutino;
        private ListBox lbxResumo;
        private ToolTip toolTip1;
        private TextBox txtSituacaoEstagiario;
        private Button btnCalcular;
    }
}