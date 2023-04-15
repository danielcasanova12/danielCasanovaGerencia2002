namespace gerencia
{
    partial class FrmBuscar
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
            btnBuscarid = new Button();
            inputPesquisa = new TextBox();
            dataGridView4 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarid
            // 
            btnBuscarid.Location = new Point(640, 33);
            btnBuscarid.Name = "btnBuscarid";
            btnBuscarid.Size = new Size(96, 23);
            btnBuscarid.TabIndex = 40;
            btnBuscarid.Text = "Buscar";
            btnBuscarid.UseVisualStyleBackColor = true;
            btnBuscarid.Click += btnBuscarid_Click;
            // 
            // inputPesquisa
            // 
            inputPesquisa.Location = new Point(348, 33);
            inputPesquisa.Name = "inputPesquisa";
            inputPesquisa.Size = new Size(258, 23);
            inputPesquisa.TabIndex = 38;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(27, 104);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(735, 410);
            dataGridView4.TabIndex = 41;
            dataGridView4.CellContentClick += dataGridView4_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(72, 33);
            label1.Name = "label1";
            label1.Size = new Size(270, 21);
            label1.TabIndex = 42;
            label1.Text = "Pesquise por: Id Nome ou Localização";
            // 
            // FrmBuscar
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new Size(784, 526);
            Controls.Add(label1);
            Controls.Add(dataGridView4);
            Controls.Add(btnBuscarid);
            Controls.Add(inputPesquisa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBuscar";
            Text = "FrmBuscar";
            Load += FrmBuscar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarid;
        private TextBox inputPesquisa;
        private DataGridView dataGridView4;
        private Label label1;
    }
}