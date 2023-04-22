namespace gerencia.Views
{
    partial class FmrListaConvidados
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
            dataGridView2 = new DataGridView();
            BtnDeletar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(363, 366);
            dataGridView2.TabIndex = 40;
            dataGridView2.CellContentClick += dataGridView2_CellCClick;
            // 
            // BtnDeletar
            // 
            BtnDeletar.Location = new Point(228, 415);
            BtnDeletar.Name = "BtnDeletar";
            BtnDeletar.Size = new Size(75, 23);
            BtnDeletar.TabIndex = 0;
            BtnDeletar.Text = "Deletar";
            BtnDeletar.Click += BtnDeletar_Click;
            // 
            // FmrListaConvidados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 450);
            Controls.Add(BtnDeletar);
            Controls.Add(dataGridView2);
            MaximumSize = new Size(379, 489);
            MinimumSize = new Size(379, 489);
            Name = "FmrListaConvidados";
            Text = "FmrListaConvidados";
            Load += FmrListaConvidados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView2;
        private Button BtnDeletar;
    }
}