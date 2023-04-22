namespace gerencia.Views
{
    partial class FrmConvidados
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
            inputEmail = new TextBox();
            btnCancelar = new Button();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(75, 188);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 1;
            label1.Text = "email";
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(174, 186);
            inputEmail.Name = "inputEmail";
            inputEmail.PlaceholderText = "Email";
            inputEmail.Size = new Size(168, 23);
            inputEmail.TabIndex = 24;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(75, 318);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(267, 318);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 20;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // FrmConvidados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 450);
            Controls.Add(label1);
            Controls.Add(inputEmail);
            Controls.Add(btnCancelar);
            Controls.Add(btnEnviar);
            Name = "FrmConvidados";
            Text = "FrmConvidados";
            Load += FrmConvidados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox inputEmail;
        private Button btnCancelar;
        private Button btnEnviar;
    }
}