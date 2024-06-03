namespace TrabalhoDAL
{
    partial class NumerosRepetidos
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
            label2 = new Label();
            btnConfirmar = new Button();
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            lb1 = new ListBox();
            lb2 = new ListBox();
            btnAdd1 = new Button();
            btnAdd2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 37);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite um número:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 37);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Digite um número:";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(128, 234);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(195, 55);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 3;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(37, 55);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 4;
            // 
            // lb1
            // 
            lb1.FormattingEnabled = true;
            lb1.ItemHeight = 15;
            lb1.Location = new Point(17, 124);
            lb1.Name = "lb1";
            lb1.Size = new Size(120, 94);
            lb1.TabIndex = 5;
            // 
            // lb2
            // 
            lb2.FormattingEnabled = true;
            lb2.ItemHeight = 15;
            lb2.Location = new Point(195, 124);
            lb2.Name = "lb2";
            lb2.Size = new Size(120, 94);
            lb2.TabIndex = 6;
            // 
            // btnAdd1
            // 
            btnAdd1.Location = new Point(62, 95);
            btnAdd1.Name = "btnAdd1";
            btnAdd1.Size = new Size(75, 23);
            btnAdd1.TabIndex = 7;
            btnAdd1.Text = "Adicionar";
            btnAdd1.UseVisualStyleBackColor = true;
            // 
            // btnAdd2
            // 
            btnAdd2.Location = new Point(195, 95);
            btnAdd2.Name = "btnAdd2";
            btnAdd2.Size = new Size(75, 23);
            btnAdd2.TabIndex = 8;
            btnAdd2.Text = "Adicionar";
            btnAdd2.UseVisualStyleBackColor = true;
            // 
            // NumerosRepetidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 269);
            Controls.Add(btnAdd2);
            Controls.Add(btnAdd1);
            Controls.Add(lb2);
            Controls.Add(lb1);
            Controls.Add(txtNum1);
            Controls.Add(txtNum2);
            Controls.Add(btnConfirmar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NumerosRepetidos";
            Text = "NumerosRepetidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnConfirmar;
        private TextBox txtNum2;
        private TextBox txtNum1;
        private ListBox lb1;
        private ListBox lb2;
        private Button btnAdd1;
        private Button btnAdd2;
    }
}