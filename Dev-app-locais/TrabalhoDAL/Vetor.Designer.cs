namespace TrabalhoDAL
{
    partial class Vetor
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
            txtNum = new TextBox();
            label1 = new Label();
            lbVetor = new ListBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // txtNum
            // 
            txtNum.Location = new Point(21, 31);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(120, 23);
            txtNum.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 13);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 1;
            label1.Text = "Digite um número:";
            // 
            // lbVetor
            // 
            lbVetor.FormattingEnabled = true;
            lbVetor.ItemHeight = 15;
            lbVetor.Location = new Point(21, 97);
            lbVetor.Name = "lbVetor";
            lbVetor.Size = new Size(120, 184);
            lbVetor.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(42, 68);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Vetor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(162, 293);
            Controls.Add(btnAdd);
            Controls.Add(lbVetor);
            Controls.Add(label1);
            Controls.Add(txtNum);
            Name = "Vetor";
            Text = "Vetor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum;
        private Label label1;
        private ListBox lbVetor;
        private Button btnAdd;
    }
}