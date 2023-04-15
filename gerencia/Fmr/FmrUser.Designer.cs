namespace gerencia.Fmr
{
    partial class FmrUser
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
            btnCancelar = new Button();
            btnEnviar = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            emailUsado = new Label();
            inputNome = new TextBox();
            inputEmail = new TextBox();
            inputSenha = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(56, 427);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(210, 427);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 10;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 318);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 264);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 6;
            label1.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 206);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 12;
            label3.Text = "Nome";
            label3.Click += label3_Click;
            // 
            // emailUsado
            // 
            emailUsado.AutoSize = true;
            emailUsado.Location = new Point(115, 282);
            emailUsado.Name = "emailUsado";
            emailUsado.Size = new Size(0, 15);
            emailUsado.TabIndex = 14;
            // 
            // inputNome
            // 
            inputNome.Location = new Point(124, 198);
            inputNome.Name = "inputNome";
            inputNome.Size = new Size(168, 23);
            inputNome.TabIndex = 15;
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(124, 256);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(168, 23);
            inputEmail.TabIndex = 16;
            // 
            // inputSenha
            // 
            inputSenha.Location = new Point(124, 310);
            inputSenha.Name = "inputSenha";
            inputSenha.Size = new Size(168, 23);
            inputSenha.TabIndex = 17;
            // 
            // FmrUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 521);
            Controls.Add(inputSenha);
            Controls.Add(inputEmail);
            Controls.Add(inputNome);
            Controls.Add(emailUsado);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnEnviar);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(342, 560);
            MinimumSize = new Size(342, 560);
            Name = "FmrUser";
            Text = "FmrUser";
            Load += FmrUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnEnviar;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label emailUsado;
        private TextBox inputNome;
        private TextBox inputEmail;
        private TextBox inputSenha;
    }
}