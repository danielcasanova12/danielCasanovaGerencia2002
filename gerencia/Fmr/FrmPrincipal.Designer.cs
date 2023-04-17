namespace gerencia
{
    partial class Frm_principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_principal));
            panelPrincipal = new Panel();
            btnMyEventos = new Button();
            btnRemover = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            btnBuscar = new Button();
            btnHome = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelForm = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panelPrincipal.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(0, 0, 100);
            panelPrincipal.Controls.Add(btnMyEventos);
            panelPrincipal.Controls.Add(btnRemover);
            panelPrincipal.Controls.Add(btnEditar);
            panelPrincipal.Controls.Add(btnAdicionar);
            panelPrincipal.Controls.Add(btnBuscar);
            panelPrincipal.Controls.Add(btnHome);
            panelPrincipal.Controls.Add(panelLogo);
            panelPrincipal.Dock = DockStyle.Left;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(200, 526);
            panelPrincipal.TabIndex = 0;
            // 
            // btnMyEventos
            // 
            btnMyEventos.Dock = DockStyle.Top;
            btnMyEventos.FlatAppearance.BorderSize = 0;
            btnMyEventos.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnMyEventos.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
            btnMyEventos.FlatStyle = FlatStyle.Flat;
            btnMyEventos.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMyEventos.ForeColor = Color.White;
            btnMyEventos.Image = (Image)resources.GetObject("btnMyEventos.Image");
            btnMyEventos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMyEventos.Location = new Point(0, 460);
            btnMyEventos.Name = "btnMyEventos";
            btnMyEventos.Padding = new Padding(10, 0, 0, 0);
            btnMyEventos.Size = new Size(200, 64);
            btnMyEventos.TabIndex = 6;
            btnMyEventos.Text = "Seus Eventos";
            btnMyEventos.TextAlign = ContentAlignment.MiddleLeft;
            btnMyEventos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMyEventos.UseVisualStyleBackColor = true;
            btnMyEventos.Click += btnMyEventos_Click;
            // 
            // btnRemover
            // 
            btnRemover.Dock = DockStyle.Top;
            btnRemover.FlatAppearance.BorderSize = 0;
            btnRemover.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnRemover.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemover.ForeColor = Color.White;
            btnRemover.Image = (Image)resources.GetObject("btnRemover.Image");
            btnRemover.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemover.Location = new Point(0, 396);
            btnRemover.Name = "btnRemover";
            btnRemover.Padding = new Padding(10, 0, 0, 0);
            btnRemover.Size = new Size(200, 64);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover Evento";
            btnRemover.TextAlign = ContentAlignment.MiddleLeft;
            btnRemover.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnEditar
            // 
            btnEditar.Dock = DockStyle.Top;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(0, 332);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(15, 0, 0, 0);
            btnEditar.Size = new Size(200, 64);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar Evento";
            btnEditar.TextAlign = ContentAlignment.MiddleLeft;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Dock = DockStyle.Top;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnAdicionar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionar.Location = new Point(0, 268);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(10, 0, 0, 0);
            btnAdicionar.Size = new Size(200, 64);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar Evento";
            btnAdicionar.TextAlign = ContentAlignment.MiddleLeft;
            btnAdicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Dock = DockStyle.Top;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(0, 204);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Padding = new Padding(15, 0, 0, 0);
            btnBuscar.Size = new Size(200, 64);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar Evento";
            btnBuscar.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 140);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(15, 0, 0, 0);
            btnHome.Size = new Size(200, 64);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Fuchsia;
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 140);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-13, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelForm
            // 
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(dataGridView1);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(200, 0);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(784, 526);
            panelForm.TabIndex = 1;
            panelForm.Paint += panelForm_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(221, 40);
            label1.Name = "label1";
            label1.Size = new Size(327, 37);
            label1.TabIndex = 41;
            label1.Text = "Todos os eventos publicos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(742, 358);
            dataGridView1.TabIndex = 40;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Frm_principal
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(984, 526);
            Controls.Add(panelForm);
            Controls.Add(panelPrincipal);
            Name = "Frm_principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento de Eventos";
            Load += Form1_Load;
            panelPrincipal.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Button btnMyEventos;
        private Button btnRemover;
        private Button btnEditar;
        private Button btnAdicionar;
        private Button btnBuscar;
        private Button btnHome;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Panel panelForm;
        private Label label1;
        private DataGridView dataGridView1;
    }
}