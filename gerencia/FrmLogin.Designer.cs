namespace gerencia
{
    partial class FrmLogin
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
            inputEmail = new TextBox();
            inputSenha = new TextBox();
            btnEnviar = new Button();
            btnCancelar = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 231);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 302);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(109, 223);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(177, 23);
            inputEmail.TabIndex = 2;
            // 
            // inputSenha
            // 
            inputSenha.Location = new Point(109, 294);
            inputSenha.Name = "inputSenha";
            inputSenha.Size = new Size(177, 23);
            inputSenha.TabIndex = 3;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(211, 424);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(57, 424);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(141, 473);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(65, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Criar conta";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 521);
            Controls.Add(linkLabel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnEnviar);
            Controls.Add(inputSenha);
            Controls.Add(inputEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(342, 560);
            MinimizeBox = false;
            MinimumSize = new Size(342, 560);
            Name = "FrmLogin";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox inputSenha;
        private TextBox inputEmail;
        private Button btnEnviar;
        private Button btnCancelar;
        private LinkLabel linkLabel1;
    }
}