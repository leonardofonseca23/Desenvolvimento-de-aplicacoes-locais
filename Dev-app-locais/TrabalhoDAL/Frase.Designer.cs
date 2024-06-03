namespace TrabalhoDAL
{
    partial class Frase
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
            label1 = new Label();
            btnConfirmar = new Button();
            txtFrase = new TextBox();
            txtLetra = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 49);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite uma frase:";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(123, 209);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtFrase
            // 
            txtFrase.Location = new Point(12, 67);
            txtFrase.Multiline = true;
            txtFrase.Name = "txtFrase";
            txtFrase.Size = new Size(309, 60);
            txtFrase.TabIndex = 2;
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(109, 164);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(100, 23);
            txtLetra.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 146);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 4;
            label2.Text = "Digite uma letra:";
            // 
            // Frase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 269);
            Controls.Add(label2);
            Controls.Add(txtLetra);
            Controls.Add(txtFrase);
            Controls.Add(btnConfirmar);
            Controls.Add(label1);
            Name = "Frase";
            Text = "Frase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnConfirmar;
        private TextBox txtFrase;
        private TextBox txtLetra;
        private Label label2;
    }
}