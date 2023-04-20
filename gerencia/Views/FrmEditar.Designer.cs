namespace gerencia.Views
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
            this.cbM = new System.Windows.Forms.ComboBox();
            this.cbH = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputLocalizacao = new System.Windows.Forms.TextBox();
            this.comboBoxPrivacidade = new System.Windows.Forms.ComboBox();
            this.datammyy = new System.Windows.Forms.DateTimePicker();
            this.inputDescricao = new System.Windows.Forms.TextBox();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inputId = new System.Windows.Forms.TextBox();
            this.btnBuscarid = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbM
            // 
            this.cbM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbM.FormattingEnabled = true;
            this.cbM.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.cbM.Location = new System.Drawing.Point(375, 267);
            this.cbM.Name = "cbM";
            this.cbM.Size = new System.Drawing.Size(61, 23);
            this.cbM.TabIndex = 28;
            // 
            // cbH
            // 
            this.cbH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbH.FormattingEnabled = true;
            this.cbH.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cbH.Location = new System.Drawing.Point(288, 267);
            this.cbH.Name = "cbH";
            this.cbH.Size = new System.Drawing.Size(61, 23);
            this.cbH.TabIndex = 29;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(551, 435);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 33);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(162, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Privacidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(162, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Localização";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(162, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Horario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(162, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(162, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(162, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome";
            // 
            // inputLocalizacao
            // 
            this.inputLocalizacao.Location = new System.Drawing.Point(288, 325);
            this.inputLocalizacao.Name = "inputLocalizacao";
            this.inputLocalizacao.Size = new System.Drawing.Size(363, 23);
            this.inputLocalizacao.TabIndex = 20;
            // 
            // comboBoxPrivacidade
            // 
            this.comboBoxPrivacidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrivacidade.FormattingEnabled = true;
            this.comboBoxPrivacidade.Items.AddRange(new object[] {
            "Publico",
            "Privado",
            "SomenteConvidados"});
            this.comboBoxPrivacidade.Location = new System.Drawing.Point(288, 383);
            this.comboBoxPrivacidade.Name = "comboBoxPrivacidade";
            this.comboBoxPrivacidade.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPrivacidade.TabIndex = 19;
            // 
            // datammyy
            // 
            this.datammyy.Location = new System.Drawing.Point(288, 206);
            this.datammyy.Name = "datammyy";
            this.datammyy.Size = new System.Drawing.Size(200, 23);
            this.datammyy.TabIndex = 18;
            // 
            // inputDescricao
            // 
            this.inputDescricao.Location = new System.Drawing.Point(288, 148);
            this.inputDescricao.Name = "inputDescricao";
            this.inputDescricao.Size = new System.Drawing.Size(363, 23);
            this.inputDescricao.TabIndex = 17;
            // 
            // inputNome
            // 
            this.inputNome.Location = new System.Drawing.Point(288, 98);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(363, 23);
            this.inputNome.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(162, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "ID";
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(288, 53);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(61, 23);
            this.inputId.TabIndex = 30;
            // 
            // btnBuscarid
            // 
            this.btnBuscarid.Location = new System.Drawing.Point(453, 53);
            this.btnBuscarid.Name = "btnBuscarid";
            this.btnBuscarid.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarid.TabIndex = 32;
            this.btnBuscarid.Text = "Buscar";
            this.btnBuscarid.UseVisualStyleBackColor = true;
            this.btnBuscarid.Click += new System.EventHandler(this.btnBuscarid_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(288, 435);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 33);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(768, 487);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscarid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.cbM);
            this.Controls.Add(this.cbH);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputLocalizacao);
            this.Controls.Add(this.comboBoxPrivacidade);
            this.Controls.Add(this.datammyy);
            this.Controls.Add(this.inputDescricao);
            this.Controls.Add(this.inputNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditar";
            this.Text = "FrmEditar";
            this.Load += new System.EventHandler(this.FrmEditar_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

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