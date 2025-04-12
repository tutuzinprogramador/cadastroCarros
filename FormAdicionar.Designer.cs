namespace Lista_de_Carros_v2
{
    partial class FormAdicionar
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
            this.edtCor = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edtMarca = new System.Windows.Forms.TextBox();
            this.edtModelo = new System.Windows.Forms.TextBox();
            this.edtAno = new System.Windows.Forms.TextBox();
            this.edtPotencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chbAerofolio = new System.Windows.Forms.CheckBox();
            this.numPortas = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPortas)).BeginInit();
            this.SuspendLayout();
            // 
            // edtCor
            // 
            this.edtCor.Location = new System.Drawing.Point(28, 37);
            this.edtCor.Name = "edtCor";
            this.edtCor.Size = new System.Drawing.Size(100, 22);
            this.edtCor.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // edtMarca
            // 
            this.edtMarca.Location = new System.Drawing.Point(28, 81);
            this.edtMarca.Name = "edtMarca";
            this.edtMarca.Size = new System.Drawing.Size(100, 22);
            this.edtMarca.TabIndex = 2;
            // 
            // edtModelo
            // 
            this.edtModelo.Location = new System.Drawing.Point(28, 135);
            this.edtModelo.Name = "edtModelo";
            this.edtModelo.Size = new System.Drawing.Size(100, 22);
            this.edtModelo.TabIndex = 3;
            // 
            // edtAno
            // 
            this.edtAno.Location = new System.Drawing.Point(28, 192);
            this.edtAno.Name = "edtAno";
            this.edtAno.Size = new System.Drawing.Size(100, 22);
            this.edtAno.TabIndex = 4;
            // 
            // edtPotencia
            // 
            this.edtPotencia.Location = new System.Drawing.Point(28, 350);
            this.edtPotencia.Name = "edtPotencia";
            this.edtPotencia.Size = new System.Drawing.Size(100, 22);
            this.edtPotencia.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "potencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Portas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "ano";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Modelo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Marca";
            // 
            // chbAerofolio
            // 
            this.chbAerofolio.AutoSize = true;
            this.chbAerofolio.Checked = true;
            this.chbAerofolio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAerofolio.Location = new System.Drawing.Point(28, 235);
            this.chbAerofolio.Name = "chbAerofolio";
            this.chbAerofolio.Size = new System.Drawing.Size(83, 20);
            this.chbAerofolio.TabIndex = 5;
            this.chbAerofolio.Text = "Aerofolio";
            this.chbAerofolio.UseVisualStyleBackColor = true;
            // 
            // numPortas
            // 
            this.numPortas.Location = new System.Drawing.Point(28, 290);
            this.numPortas.Name = "numPortas";
            this.numPortas.Size = new System.Drawing.Size(120, 22);
            this.numPortas.TabIndex = 6;
            this.numPortas.ValueChanged += new System.EventHandler(this.numPortas_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numPortas);
            this.Controls.Add(this.chbAerofolio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtPotencia);
            this.Controls.Add(this.edtAno);
            this.Controls.Add(this.edtModelo);
            this.Controls.Add(this.edtMarca);
            this.Controls.Add(this.edtCor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdicionar";
            this.Load += new System.EventHandler(this.FormAdicionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPortas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtCor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox edtMarca;
        private System.Windows.Forms.TextBox edtModelo;
        private System.Windows.Forms.TextBox edtAno;
        private System.Windows.Forms.TextBox edtPotencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chbAerofolio;
        private System.Windows.Forms.NumericUpDown numPortas;
        private System.Windows.Forms.Button button1;
    }
}