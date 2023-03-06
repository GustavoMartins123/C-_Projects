namespace Agenda
{
    partial class frmConsultaContato
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
            txt_Valor = new TextBox();
            btn_Executar = new Button();
            dgd_Dados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgd_Dados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Contato";
            // 
            // txt_Valor
            // 
            txt_Valor.Location = new Point(16, 27);
            txt_Valor.Name = "txt_Valor";
            txt_Valor.Size = new Size(656, 23);
            txt_Valor.TabIndex = 1;
            // 
            // btn_Executar
            // 
            btn_Executar.Location = new Point(697, 27);
            btn_Executar.Name = "btn_Executar";
            btn_Executar.Size = new Size(75, 23);
            btn_Executar.TabIndex = 2;
            btn_Executar.Text = "Localizar";
            btn_Executar.UseVisualStyleBackColor = true;
            btn_Executar.Click += btn_Executar_Click;
            // 
            // dgd_Dados
            // 
            dgd_Dados.AllowUserToAddRows = false;
            dgd_Dados.AllowUserToDeleteRows = false;
            dgd_Dados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgd_Dados.Location = new Point(16, 60);
            dgd_Dados.Name = "dgd_Dados";
            dgd_Dados.ReadOnly = true;
            dgd_Dados.RowTemplate.Height = 25;
            dgd_Dados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgd_Dados.Size = new Size(756, 489);
            dgd_Dados.TabIndex = 3;
            dgd_Dados.CellDoubleClick += dgd_Dados_CellDoubleClick;
            // 
            // frmConsultaContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(784, 561);
            Controls.Add(dgd_Dados);
            Controls.Add(btn_Executar);
            Controls.Add(txt_Valor);
            Controls.Add(label1);
            Name = "frmConsultaContato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de Contatos";
            ((System.ComponentModel.ISupportInitialize)dgd_Dados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Valor;
        private Button btn_Executar;
        private DataGridView dgd_Dados;
    }
}