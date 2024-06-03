namespace TrabalhoDAL;

partial class Nota
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
        txtNota = new TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(73, 83);
        label1.Name = "label1";
        label1.Size = new Size(86, 15);
        label1.TabIndex = 0;
        label1.Text = "Digite sua nota";
        // 
        // btnConfirmar
        // 
        btnConfirmar.Location = new Point(84, 130);
        btnConfirmar.Name = "btnConfirmar";
        btnConfirmar.Size = new Size(75, 23);
        btnConfirmar.TabIndex = 1;
        btnConfirmar.Text = "Confirmar";
        btnConfirmar.UseVisualStyleBackColor = true;
        btnConfirmar.Click += btnConfirmar_Click;
        // 
        // txtNota
        // 
        txtNota.Location = new Point(70, 101);
        txtNota.Name = "txtNota";
        txtNota.Size = new Size(100, 23);
        txtNota.TabIndex = 2;
        // 
        // Nota
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(244, 251);
        Controls.Add(txtNota);
        Controls.Add(btnConfirmar);
        Controls.Add(label1);
        Name = "Nota";
        Text = "Nota";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Button btnConfirmar;
    private TextBox txtNota;
}