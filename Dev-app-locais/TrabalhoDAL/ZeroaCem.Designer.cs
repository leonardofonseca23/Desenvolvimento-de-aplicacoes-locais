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
            txtNum = new TextBox();
            lbNumeros = new ListBox();
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
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(33, 100);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
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
            // txtNum
            // 
            txtNum.Location = new Point(63, 57);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 3;
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
            // ZeroaCem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 251);
            Controls.Add(lbNumeros);
            Controls.Add(txtNum);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnConferir);
            Name = "ZeroaCem";
            Text = "ZeroaCem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConferir;
        private Button btnAdd;
        private Label label1;
        private TextBox txtNum;
        private ListBox lbNumeros;
    }
}