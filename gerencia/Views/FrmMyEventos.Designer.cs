﻿namespace gerencia.Views
{
    partial class FrmMyEventos
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
            label1 = new Label();
            label2 = new Label();
            dataGridView3 = new DataGridView();
            btnConvidados = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 40);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(741, 167);
            dataGridView2.TabIndex = 39;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 42;
            label1.Text = "Seus Eventos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 279);
            label2.Name = "label2";
            label2.Size = new Size(189, 28);
            label2.TabIndex = 44;
            label2.Text = "Eventos Convidados";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(12, 310);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(741, 186);
            dataGridView3.TabIndex = 43;
            // 
            // btnConvidados
            // 
            btnConvidados.Location = new Point(605, 251);
            btnConvidados.Name = "btnConvidados";
            btnConvidados.Size = new Size(144, 23);
            btnConvidados.TabIndex = 45;
            btnConvidados.Text = "Adicionar convidados";
            btnConvidados.UseVisualStyleBackColor = true;
            btnConvidados.Click += btnConvidados_Click;
            // 
            // button1
            // 
            button1.Location = new Point(431, 251);
            button1.Name = "button1";
            button1.Size = new Size(144, 23);
            button1.TabIndex = 46;
            button1.Text = "Ver convidados";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmMyEventos
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(784, 526);
            Controls.Add(button1);
            Controls.Add(btnConvidados);
            Controls.Add(label2);
            Controls.Add(dataGridView3);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMyEventos";
            Text = "FrmMyEventos";
            Load += FrmMyEventos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView3;
        private Button btnConvidados;
        private Button button1;
    }
}