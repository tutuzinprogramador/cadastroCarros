namespace Lista_de_Carros_v2
{
    partial class FormRemover
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
            this.label1 = new System.Windows.Forms.Label();
            this.bntRemover = new System.Windows.Forms.Button();
            this.edtRemoverId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o ID do seu carro para remove-lo";
            // 
            // bntRemover
            // 
            this.bntRemover.BackColor = System.Drawing.Color.Red;
            this.bntRemover.Location = new System.Drawing.Point(103, 230);
            this.bntRemover.Name = "bntRemover";
            this.bntRemover.Size = new System.Drawing.Size(146, 51);
            this.bntRemover.TabIndex = 1;
            this.bntRemover.Text = "remover";
            this.bntRemover.UseVisualStyleBackColor = false;
            this.bntRemover.Click += new System.EventHandler(this.bntRemover_Click);
            // 
            // edtRemoverId
            // 
            this.edtRemoverId.Location = new System.Drawing.Point(94, 164);
            this.edtRemoverId.Name = "edtRemoverId";
            this.edtRemoverId.Size = new System.Drawing.Size(166, 22);
            this.edtRemoverId.TabIndex = 2;
            // 
            // FormRemover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(349, 478);
            this.Controls.Add(this.edtRemoverId);
            this.Controls.Add(this.bntRemover);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormRemover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRemover";
            this.Load += new System.EventHandler(this.FormRemover_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntRemover;
        private System.Windows.Forms.TextBox edtRemoverId;
    }
}