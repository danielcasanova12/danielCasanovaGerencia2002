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
            this.btnBuscarid = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.inputId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.inputRemover = new System.Windows.Forms.TextBox();
            this.btnRmover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarid
            // 
            this.btnBuscarid.Location = new System.Drawing.Point(431, 209);
            this.btnBuscarid.Name = "btnBuscarid";
            this.btnBuscarid.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarid.TabIndex = 37;
            this.btnBuscarid.Text = "Buscar";
            this.btnBuscarid.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(140, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 21);
            this.label7.TabIndex = 36;
            this.label7.Text = "ID";
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(266, 209);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(61, 23);
            this.inputId.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Remvoa por: Id Nome ou Localização";
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(21, 102);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 25;
            this.dataGridView5.Size = new System.Drawing.Size(735, 310);
            this.dataGridView5.TabIndex = 45;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(634, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 23);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // inputRemover
            // 
            this.inputRemover.Location = new System.Drawing.Point(342, 31);
            this.inputRemover.Name = "inputRemover";
            this.inputRemover.Size = new System.Drawing.Size(258, 23);
            this.inputRemover.TabIndex = 43;
            // 
            // btnRmover
            // 
            this.btnRmover.Location = new System.Drawing.Point(634, 446);
            this.btnRmover.Name = "btnRmover";
            this.btnRmover.Size = new System.Drawing.Size(96, 29);
            this.btnRmover.TabIndex = 47;
            this.btnRmover.Text = "Remover";
            this.btnRmover.UseVisualStyleBackColor = true;
            this.btnRmover.Click += new System.EventHandler(this.btnRmover_Click);
            // 
            // FrmRemover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(768, 487);
            this.Controls.Add(this.btnRmover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.inputRemover);
            this.Controls.Add(this.btnBuscarid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRemover";
            this.Text = "FrmDeletar";
            this.Load += new System.EventHandler(this.FrmRemover_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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