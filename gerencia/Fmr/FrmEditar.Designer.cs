namespace gerencia
{
    partial class FrmEditar
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
            cbH = new ComboBox();
            btnEditar = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            inputLocalizacao = new TextBox();
            comboBoxPrivacidade = new ComboBox();
            datammyy = new DateTimePicker();
            inputDescricao = new TextBox();
            inputNome = new TextBox();
            label7 = new Label();
            inputId = new TextBox();
            btnBuscarid = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // cbM
            // 
            cbM.DropDownStyle = ComboBoxStyle.DropDownList;
            cbM.FormattingEnabled = true;
            cbM.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60" });
            cbM.Location = new Point(375, 267);
            cbM.Name = "cbM";
            cbM.Size = new Size(61, 23);
            cbM.TabIndex = 28;
            // 
            // cbH
            // 
            cbH.DropDownStyle = ComboBoxStyle.DropDownList;
            cbH.FormattingEnabled = true;
            cbH.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" });
            cbH.Location = new Point(288, 267);
            cbH.Name = "cbH";
            cbH.Size = new Size(61, 23);
            cbH.TabIndex = 29;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(551, 435);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 33);
            btnEditar.TabIndex = 27;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(162, 385);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 26;
            label6.Text = "Privacidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(162, 327);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 25;
            label5.Text = "Localização";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(162, 265);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 24;
            label4.Text = "Horario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(162, 206);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 23;
            label1.Text = "Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(162, 146);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 22;
            label3.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(162, 100);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 21;
            label2.Text = "Nome";
            // 
            // inputLocalizacao
            // 
            inputLocalizacao.Location = new Point(288, 325);
            inputLocalizacao.Name = "inputLocalizacao";
            inputLocalizacao.Size = new Size(363, 23);
            inputLocalizacao.TabIndex = 20;
            // 
            // comboBoxPrivacidade
            // 
            comboBoxPrivacidade.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrivacidade.FormattingEnabled = true;
            comboBoxPrivacidade.Items.AddRange(new object[] { "Publico", "Privado", "SomenteConvidados" });
            comboBoxPrivacidade.Location = new Point(288, 383);
            comboBoxPrivacidade.Name = "comboBoxPrivacidade";
            comboBoxPrivacidade.Size = new Size(121, 23);
            comboBoxPrivacidade.TabIndex = 19;
            // 
            // datammyy
            // 
            datammyy.Location = new Point(288, 206);
            datammyy.Name = "datammyy";
            datammyy.Size = new Size(200, 23);
            datammyy.TabIndex = 18;
            // 
            // inputDescricao
            // 
            inputDescricao.Location = new Point(288, 148);
            inputDescricao.Name = "inputDescricao";
            inputDescricao.Size = new Size(363, 23);
            inputDescricao.TabIndex = 17;
            // 
            // inputNome
            // 
            inputNome.Location = new Point(288, 98);
            inputNome.Name = "inputNome";
            inputNome.Size = new Size(363, 23);
            inputNome.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(162, 55);
            label7.Name = "label7";
            label7.Size = new Size(25, 21);
            label7.TabIndex = 31;
            label7.Text = "ID";
            label7.Click += label7_Click;
            // 
            // inputId
            // 
            inputId.Location = new Point(288, 53);
            inputId.Name = "inputId";
            inputId.Size = new Size(61, 23);
            inputId.TabIndex = 30;
            inputId.TextChanged += textBox1_TextChanged;
            // 
            // btnBuscarid
            // 
            btnBuscarid.Location = new Point(453, 53);
            btnBuscarid.Name = "btnBuscarid";
            btnBuscarid.Size = new Size(75, 23);
            btnBuscarid.TabIndex = 32;
            btnBuscarid.Text = "Buscar";
            btnBuscarid.UseVisualStyleBackColor = true;
            btnBuscarid.Click += btnBuscarid_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(288, 435);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 33);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmEditar
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(768, 487);
            Controls.Add(btnCancelar);
            Controls.Add(btnBuscarid);
            Controls.Add(label7);
            Controls.Add(inputId);
            Controls.Add(cbM);
            Controls.Add(cbH);
            Controls.Add(btnEditar);
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
            Name = "FrmEditar";
            Text = "FrmEditar";
            Load += FrmEditar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbM;
        private ComboBox cbH;
        private Button btnEditar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox inputLocalizacao;
        private ComboBox comboBoxPrivacidade;
        private DateTimePicker datammyy;
        private TextBox inputDescricao;
        private TextBox inputNome;
        private Label label7;
        private TextBox inputId;
        private Button btnBuscarid;
        private Button btnCancelar;
    }
}