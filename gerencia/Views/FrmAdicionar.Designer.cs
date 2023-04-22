namespace gerencia.Views
{
    partial class FrmAdicionar
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
            inputNome = new TextBox();
            inputDescricao = new TextBox();
            datammyy = new DateTimePicker();
            comboBoxPrivacidade = new ComboBox();
            inputLocalizacao = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCadastrar = new Button();
            dateTimePicker = new DateTimePicker();
            button2 = new Button();
            SuspendLayout();
            // 
            // inputNome
            // 
            inputNome.Location = new Point(287, 72);
            inputNome.Name = "inputNome";
            inputNome.PlaceholderText = "Nome";
            inputNome.Size = new Size(363, 23);
            inputNome.TabIndex = 0;
            // 
            // inputDescricao
            // 
            inputDescricao.Location = new Point(287, 122);
            inputDescricao.Name = "inputDescricao";
            inputDescricao.PlaceholderText = "Descrição";
            inputDescricao.Size = new Size(363, 23);
            inputDescricao.TabIndex = 1;
            // 
            // datammyy
            // 
            datammyy.Location = new Point(287, 180);
            datammyy.Name = "datammyy";
            datammyy.Size = new Size(200, 23);
            datammyy.TabIndex = 3;
            datammyy.ValueChanged += datammyy_ValueChanged;
            // 
            // comboBoxPrivacidade
            // 
            comboBoxPrivacidade.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrivacidade.FormattingEnabled = true;
            comboBoxPrivacidade.Items.AddRange(new object[] { "Publico", "Privado", "SomenteConvidados" });
            comboBoxPrivacidade.Location = new Point(287, 357);
            comboBoxPrivacidade.Name = "comboBoxPrivacidade";
            comboBoxPrivacidade.Size = new Size(121, 23);
            comboBoxPrivacidade.TabIndex = 4;
            // 
            // inputLocalizacao
            // 
            inputLocalizacao.Location = new Point(287, 299);
            inputLocalizacao.Name = "inputLocalizacao";
            inputLocalizacao.PlaceholderText = "Localização";
            inputLocalizacao.Size = new Size(363, 23);
            inputLocalizacao.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(161, 74);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(161, 120);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 8;
            label3.Text = "Descrição";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(161, 180);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 9;
            label1.Text = "Data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(161, 239);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 10;
            label4.Text = "Horario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(161, 301);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 11;
            label5.Text = "Localização";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(161, 359);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 12;
            label6.Text = "Privacidade";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(550, 449);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(100, 33);
            btnCadastrar.TabIndex = 13;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(287, 238);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 14;
            // 
            // button2
            // 
            button2.Location = new Point(287, 449);
            button2.Name = "button2";
            button2.Size = new Size(100, 33);
            button2.TabIndex = 15;
            button2.Text = "Add Varios";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // FrmAdicionar
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(784, 526);
            Controls.Add(button2);
            Controls.Add(dateTimePicker);
            Controls.Add(btnCadastrar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(inputLocalizacao);
            Controls.Add(comboBoxPrivacidade);
            Controls.Add(datammyy);
            Controls.Add(inputDescricao);
            Controls.Add(inputNome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAdicionar";
            Text = "FrmAdicionar";
            Load += FrmAdicionar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox inputNome;
        private TextBox inputDescricao;
        private DateTimePicker datammyy;
        private ComboBox comboBoxPrivacidade;
        private Label label1;
        private TextBox inputLocalizacao;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCadastrar;
        private Button btnCancelar;
        private DateTimePicker dateTimePicker;
        private Button button2;
    }
}