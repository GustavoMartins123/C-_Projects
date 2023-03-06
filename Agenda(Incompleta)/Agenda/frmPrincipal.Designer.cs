namespace Agenda
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Contato = new Button();
            SuspendLayout();
            // 
            // btn_Contato
            // 
            btn_Contato.Location = new Point(7, 10);
            btn_Contato.Name = "btn_Contato";
            btn_Contato.Size = new Size(127, 75);
            btn_Contato.TabIndex = 0;
            btn_Contato.Text = "Contato";
            btn_Contato.UseVisualStyleBackColor = true;
            btn_Contato.Click += button1_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(784, 561);
            Controls.Add(btn_Contato);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Contato;
    }
}