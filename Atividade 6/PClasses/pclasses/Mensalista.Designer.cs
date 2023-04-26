namespace pclasses
{
    partial class frmMensalista
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalMen = new System.Windows.Forms.Label();
            this.lblDataEntEmpre = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtDatEntEmpr = new System.Windows.Forms.TextBox();
            this.txtSalMensal = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gpbHomeOffice = new System.Windows.Forms.GroupBox();
            this.rbtnNão = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gpbHomeOffice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(59, 85);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(58, 15);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matricula";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(59, 123);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSalMen
            // 
            this.lblSalMen.AutoSize = true;
            this.lblSalMen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalMen.Location = new System.Drawing.Point(59, 159);
            this.lblSalMen.Name = "lblSalMen";
            this.lblSalMen.Size = new System.Drawing.Size(86, 15);
            this.lblSalMen.TabIndex = 2;
            this.lblSalMen.Text = "Salario Mensal";
            // 
            // lblDataEntEmpre
            // 
            this.lblDataEntEmpre.AutoSize = true;
            this.lblDataEntEmpre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntEmpre.Location = new System.Drawing.Point(59, 201);
            this.lblDataEntEmpre.Name = "lblDataEntEmpre";
            this.lblDataEntEmpre.Size = new System.Drawing.Size(140, 15);
            this.lblDataEntEmpre.TabIndex = 3;
            this.lblDataEntEmpre.Text = "Data Entrada na Empresa";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(212, 85);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(232, 22);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtDatEntEmpr
            // 
            this.txtDatEntEmpr.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatEntEmpr.Location = new System.Drawing.Point(212, 194);
            this.txtDatEntEmpr.Name = "txtDatEntEmpr";
            this.txtDatEntEmpr.Size = new System.Drawing.Size(232, 22);
            this.txtDatEntEmpr.TabIndex = 5;
            // 
            // txtSalMensal
            // 
            this.txtSalMensal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalMensal.Location = new System.Drawing.Point(212, 159);
            this.txtSalMensal.Name = "txtSalMensal";
            this.txtSalMensal.Size = new System.Drawing.Size(232, 22);
            this.txtSalMensal.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(212, 116);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(232, 22);
            this.txtNome.TabIndex = 7;
            // 
            // gpbHomeOffice
            // 
            this.gpbHomeOffice.Controls.Add(this.rbtnNão);
            this.gpbHomeOffice.Controls.Add(this.rbtnSim);
            this.gpbHomeOffice.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbHomeOffice.Location = new System.Drawing.Point(533, 106);
            this.gpbHomeOffice.Name = "gpbHomeOffice";
            this.gpbHomeOffice.Size = new System.Drawing.Size(200, 100);
            this.gpbHomeOffice.TabIndex = 8;
            this.gpbHomeOffice.TabStop = false;
            this.gpbHomeOffice.Text = "Trabalha em home office";
            this.gpbHomeOffice.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // rbtnNão
            // 
            this.rbtnNão.AutoSize = true;
            this.rbtnNão.Checked = true;
            this.rbtnNão.Location = new System.Drawing.Point(29, 51);
            this.rbtnNão.Name = "rbtnNão";
            this.rbtnNão.Size = new System.Drawing.Size(47, 19);
            this.rbtnNão.TabIndex = 1;
            this.rbtnNão.TabStop = true;
            this.rbtnNão.Text = "Não";
            this.rbtnNão.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(29, 20);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(44, 19);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(148, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 91);
            this.button1.TabIndex = 9;
            this.button1.Text = "Instanciar Mensalista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(403, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 91);
            this.button2.TabIndex = 10;
            this.button2.Text = "Instanciar Mensalista passando parâmetro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpbHomeOffice);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSalMensal);
            this.Controls.Add(this.txtDatEntEmpr);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDataEntEmpre);
            this.Controls.Add(this.lblSalMen);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmMensalista";
            this.Text = "Mensalista";
            this.gpbHomeOffice.ResumeLayout(false);
            this.gpbHomeOffice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalMen;
        private System.Windows.Forms.Label lblDataEntEmpre;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtDatEntEmpr;
        private System.Windows.Forms.TextBox txtSalMensal;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gpbHomeOffice;
        private System.Windows.Forms.RadioButton rbtnNão;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}