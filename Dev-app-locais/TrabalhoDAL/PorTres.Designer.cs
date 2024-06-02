namespace TrabalhoDAL
{
    partial class PorTres
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
            btnConfirmar = new Button();
            label1 = new Label();
            txtDivisao = new TextBox();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(75, 139);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 77);
            label1.Name = "label1";
            label1.Size = new Size(139, 30);
            label1.TabIndex = 1;
            label1.Text = "Digite um número para\r\n saber se é divisivel por 3:";
            // 
            // txtDivisao
            // 
            txtDivisao.Location = new Point(65, 110);
            txtDivisao.Name = "txtDivisao";
            txtDivisao.Size = new Size(100, 23);
            txtDivisao.TabIndex = 2;
            // 
            // PorTres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 251);
            Controls.Add(txtDivisao);
            Controls.Add(label1);
            Controls.Add(btnConfirmar);
            Name = "PorTres";
            Text = "PorTres";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private Label label1;
        private TextBox txtDivisao;
    }
}