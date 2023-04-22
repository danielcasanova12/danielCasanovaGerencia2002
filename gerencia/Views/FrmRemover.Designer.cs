namespace gerencia.Views
{
    partial class FrmRemover
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
            label7 = new Label();
            inputId = new TextBox();
            label1 = new Label();
            dataGridView5 = new DataGridView();
            btnBuscar = new Button();
            inputRemover = new TextBox();
            btnRmover = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarid
            // 
            btnBuscarid.Location = new Point(431, 209);
            btnBuscarid.Name = "btnBuscarid";
            btnBuscarid.Size = new Size(75, 23);
            btnBuscarid.TabIndex = 37;
            btnBuscarid.Text = "Buscar";
            btnBuscarid.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(140, 211);
            label7.Name = "label7";
            label7.Size = new Size(25, 21);
            label7.TabIndex = 36;
            label7.Text = "ID";
            // 
            // inputId
            // 
            inputId.Location = new Point(266, 209);
            inputId.Name = "inputId";
            inputId.Size = new Size(61, 23);
            inputId.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 31);
            label1.Name = "label1";
            label1.Size = new Size(267, 21);
            label1.TabIndex = 46;
            label1.Text = "Remvoa por: Id Nome ou Localização";
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(21, 102);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowTemplate.Height = 25;
            dataGridView5.Size = new Size(735, 310);
            dataGridView5.TabIndex = 45;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(634, 31);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 23);
            btnBuscar.TabIndex = 44;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // inputRemover
            // 
            inputRemover.Location = new Point(342, 31);
            inputRemover.Name = "inputRemover";
            inputRemover.PlaceholderText = "Buscar : ID Nome ou Localização";
            inputRemover.Size = new Size(258, 23);
            inputRemover.TabIndex = 43;
            inputRemover.TextChanged += inputRemover_TextChanged;
            // 
            // btnRmover
            // 
            btnRmover.Location = new Point(634, 446);
            btnRmover.Name = "btnRmover";
            btnRmover.Size = new Size(96, 29);
            btnRmover.TabIndex = 47;
            btnRmover.Text = "Remover";
            btnRmover.UseVisualStyleBackColor = true;
            btnRmover.Click += btnRmover_Click;
            // 
            // FrmRemover
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(784, 526);
            Controls.Add(btnRmover);
            Controls.Add(label1);
            Controls.Add(dataGridView5);
            Controls.Add(btnBuscar);
            Controls.Add(inputRemover);
            Controls.Add(btnBuscarid);
            Controls.Add(label7);
            Controls.Add(inputId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRemover";
            Text = "FrmDeletar";
            Load += FrmRemover_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarid;
        private Label label7;
        private TextBox inputId;
        private Label label1;
        private DataGridView dataGridView5;
        private Button btnBuscar;
        private TextBox inputRemover;
        private Button btnRmover;
    }
}