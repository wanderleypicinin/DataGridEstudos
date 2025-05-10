namespace DataGridEstudos
{
    partial class FormAdicionarCliente
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
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpDataCadastro = new DateTimePicker();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnPrincipal = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(166, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(166, 86);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(171, 133);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(95, 23);
            txtTelefone.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 45);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 89);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 4;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 141);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 5;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 184);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 6;
            label4.Text = "Data Cadastro";
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Location = new Point(200, 178);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.Size = new Size(200, 23);
            dtpDataCadastro.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(325, 235);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(325, 296);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnPrincipal
            // 
            btnPrincipal.Location = new Point(124, 239);
            btnPrincipal.Name = "btnPrincipal";
            btnPrincipal.Size = new Size(75, 23);
            btnPrincipal.TabIndex = 10;
            btnPrincipal.Text = "Principal";
            btnPrincipal.UseVisualStyleBackColor = true;
            // 
            // FormAdicionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrincipal);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(dtpDataCadastro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Name = "FormAdicionarCliente";
            Text = "FormAdicionarCliente";
            Load += FormAdicionarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpDataCadastro;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnPrincipal;
    }
}