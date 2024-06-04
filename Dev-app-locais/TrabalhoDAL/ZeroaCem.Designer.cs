namespace TrabalhoDAL
{
    partial class ZeroaCem
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
            btnConferir = new Button();
            btnAdd = new Button();
            label1 = new Label();
            lbNumeros = new ListBox();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnConferir
            // 
            btnConferir.Location = new Point(114, 100);
            btnConferir.Name = "btnConferir";
            btnConferir.Size = new Size(75, 23);
            btnConferir.TabIndex = 0;
            btnConferir.Text = "Conferir";
            btnConferir.UseVisualStyleBackColor = true;
            btnConferir.Click += btnConferir_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(33, 100);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 39);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 2;
            label1.Text = "Digite um número de 0 a 100";
            // 
            // lbNumeros
            // 
            lbNumeros.FormattingEnabled = true;
            lbNumeros.ItemHeight = 15;
            lbNumeros.Location = new Point(54, 129);
            lbNumeros.Name = "lbNumeros";
            lbNumeros.Size = new Size(120, 94);
            lbNumeros.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(54, 57);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // ZeroaCem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 251);
            Controls.Add(numericUpDown1);
            Controls.Add(lbNumeros);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnConferir);
            Name = "ZeroaCem";
            Text = "ZeroaCem";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConferir;
        private Button btnAdd;
        private Label label1;
        private ListBox lbNumeros;
        private NumericUpDown numericUpDown1;
    }
}