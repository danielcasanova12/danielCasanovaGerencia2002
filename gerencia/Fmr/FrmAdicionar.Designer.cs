namespace gerencia
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
            cbM = new ComboBox();
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
            cbH = new ComboBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // cbM
            // 
            cbM.DropDownStyle = ComboBoxStyle.DropDownList;
            cbM.FormattingEnabled = true;
            cbM.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60" });
            cbM.Location = new Point(374, 241);
            cbM.Name = "cbM";
            cbM.Size = new Size(61, 23);
            cbM.TabIndex = 15;
            cbM.SelectedIndexChanged += cbM_SelectedIndexChanged;
            // 
            // inputNome
            // 
            inputNome.Location = new Point(287, 72);
            inputNome.Name = "inputNome";
            inputNome.Size = new Size(363, 23);
            inputNome.TabIndex = 0;
            // 
            // inputDescricao
            // 
            inputDescricao.Location = new Point(287, 122);
            inputDescricao.Name = "inputDescricao";
            inputDescricao.Size = new Size(363, 23);
            inputDescricao.TabIndex = 1;
            // 
            // datammyy
            // 
            datammyy.Location = new Point(287, 180);
            datammyy.Name = "datammyy";
            datammyy.Size = new Size(200, 23);
            datammyy.TabIndex = 3;
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
            label3.Click += label3_Click;
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
            label1.Click += label1_Click;
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
            label4.Click += label4_Click;
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
            // cbH
            // 
            cbH.DropDownStyle = ComboBoxStyle.DropDownList;
            cbH.FormattingEnabled = true;
            cbH.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" });
            cbH.Location = new Point(287, 241);
            cbH.Name = "cbH";
            cbH.Size = new Size(61, 23);
            cbH.TabIndex = 15;
            // 
            // button2
            // 
            button2.Location = new Point(273, 471);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmAdicionar
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(784, 526);
            Controls.Add(button2);
            Controls.Add(cbM);
            Controls.Add(cbH);
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
        private ComboBox cbH;
        private ComboBox cbM;
        private Button button2;
    }
}