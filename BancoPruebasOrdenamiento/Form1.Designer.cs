namespace BancoPruebasOrdenamiento
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelSuperior = new Panel();
            lblTitulo = new Label();
            lblTamano = new Label();
            cmbTamano = new ComboBox();
            lblAlgoritmos = new Label();
            clbAlgoritmos = new CheckedListBox();
            btnEjecutar = new Button();
            btnEjecutarUno = new Button();
            btnLimpiar = new Button();
            progressBar = new ProgressBar();
            lblEstado = new Label();
            lblAdvertencia = new Label();
            dgvResultados = new DataGridView();
            colAlgoritmo = new DataGridViewTextBoxColumn();
            colTamano = new DataGridViewTextBoxColumn();
            colAleatorio = new DataGridViewTextBoxColumn();
            colOrdenado = new DataGridViewTextBoxColumn();
            colInverso = new DataGridViewTextBoxColumn();
            colPromedio = new DataGridViewTextBoxColumn();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(245, 247, 250);
            panelSuperior.Controls.Add(lblTitulo);
            panelSuperior.Controls.Add(lblTamano);
            panelSuperior.Controls.Add(cmbTamano);
            panelSuperior.Controls.Add(lblAlgoritmos);
            panelSuperior.Controls.Add(clbAlgoritmos);
            panelSuperior.Controls.Add(btnEjecutar);
            panelSuperior.Controls.Add(btnEjecutarUno);
            panelSuperior.Controls.Add(btnLimpiar);
            panelSuperior.Controls.Add(progressBar);
            panelSuperior.Controls.Add(lblEstado);
            panelSuperior.Controls.Add(lblAdvertencia);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Padding = new Padding(15);
            panelSuperior.Size = new Size(1332, 367);
            panelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 60, 90);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(661, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Banco de Pruebas - Algoritmos de Ordenamiento";
            // 
            // lblTamano
            // 
            lblTamano.AutoSize = true;
            lblTamano.Location = new Point(12, 55);
            lblTamano.Name = "lblTamano";
            lblTamano.Size = new Size(193, 25);
            lblTamano.TabIndex = 1;
            lblTamano.Text = "Tamaño del conjunto:";
            // 
            // cmbTamano
            // 
            cmbTamano.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTamano.FormattingEnabled = true;
            cmbTamano.Items.AddRange(new object[] { "10,000", "50,000", "100,000", "Todos" });
            cmbTamano.Location = new Point(211, 52);
            cmbTamano.Name = "cmbTamano";
            cmbTamano.Size = new Size(164, 33);
            cmbTamano.TabIndex = 2;
            // 
            // lblAlgoritmos
            // 
            lblAlgoritmos.AutoSize = true;
            lblAlgoritmos.Location = new Point(401, 52);
            lblAlgoritmos.Name = "lblAlgoritmos";
            lblAlgoritmos.Size = new Size(185, 25);
            lblAlgoritmos.TabIndex = 3;
            lblAlgoritmos.Text = "Algoritmos a probar:";
            // 
            // clbAlgoritmos
            // 
            clbAlgoritmos.BorderStyle = BorderStyle.FixedSingle;
            clbAlgoritmos.CheckOnClick = true;
            clbAlgoritmos.FormattingEnabled = true;
            clbAlgoritmos.Items.AddRange(new object[] { "Bubble Sort", "Insertion Sort", "Selection Sort", "Merge Sort", "Quick Sort", "Heap Sort" });
            clbAlgoritmos.Location = new Point(401, 94);
            clbAlgoritmos.Name = "clbAlgoritmos";
            clbAlgoritmos.Size = new Size(292, 182);
            clbAlgoritmos.TabIndex = 4;
            // 
            // btnEjecutar
            // 
            btnEjecutar.BackColor = Color.FromArgb(0, 120, 215);
            btnEjecutar.Cursor = Cursors.Hand;
            btnEjecutar.FlatAppearance.BorderSize = 0;
            btnEjecutar.FlatStyle = FlatStyle.Flat;
            btnEjecutar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEjecutar.ForeColor = Color.White;
            btnEjecutar.Location = new Point(12, 108);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(296, 36);
            btnEjecutar.TabIndex = 5;
            btnEjecutar.Text = "▶ Ejecutar todos los marcados";
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += BtnEjecutar_Click;
            // 
            // btnEjecutarUno
            // 
            btnEjecutarUno.BackColor = Color.FromArgb(0, 150, 80);
            btnEjecutarUno.Cursor = Cursors.Hand;
            btnEjecutarUno.FlatAppearance.BorderSize = 0;
            btnEjecutarUno.FlatStyle = FlatStyle.Flat;
            btnEjecutarUno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEjecutarUno.ForeColor = Color.White;
            btnEjecutarUno.Location = new Point(12, 162);
            btnEjecutarUno.Name = "btnEjecutarUno";
            btnEjecutarUno.Size = new Size(296, 36);
            btnEjecutarUno.TabIndex = 6;
            btnEjecutarUno.Text = "▶ Ejecutar solo el elegido";
            btnEjecutarUno.UseVisualStyleBackColor = false;
            btnEjecutarUno.Click += BtnEjecutarUno_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(12, 216);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(130, 36);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar Resultados";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += BtnLimpiar_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(18, 298);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(1296, 22);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 8;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.ForeColor = Color.DarkGreen;
            lblEstado.Location = new Point(0, 339);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(865, 25);
            lblEstado.TabIndex = 9;
            lblEstado.Text = "Listo. Se recomienda empezar con 10,000 elementos. Haz clic en un algoritmo de la lista para elegirlo.";
            lblEstado.Click += lblEstado_Click;
            // 
            // lblAdvertencia
            // 
            lblAdvertencia.Font = new Font("Segoe UI", 8.5F);
            lblAdvertencia.ForeColor = Color.DarkOrange;
            lblAdvertencia.Location = new Point(707, 246);
            lblAdvertencia.Name = "lblAdvertencia";
            lblAdvertencia.Size = new Size(607, 30);
            lblAdvertencia.TabIndex = 10;
            lblAdvertencia.Text = "⚠ Bubble / Insertion / Selection con 50k-100k pueden tardar varios minutos.";
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.AllowUserToDeleteRows = false;
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.BackgroundColor = Color.White;
            dgvResultados.BorderStyle = BorderStyle.None;
            dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { colAlgoritmo, colTamano, colAleatorio, colOrdenado, colInverso, colPromedio });
            dgvResultados.Dock = DockStyle.Fill;
            dgvResultados.EnableHeadersVisualStyles = false;
            dgvResultados.Location = new Point(0, 367);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersVisible = false;
            dgvResultados.RowHeadersWidth = 62;
            dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResultados.Size = new Size(1332, 218);
            dgvResultados.TabIndex = 1;
            // 
            // colAlgoritmo
            // 
            colAlgoritmo.HeaderText = "Algoritmo";
            colAlgoritmo.MinimumWidth = 8;
            colAlgoritmo.Name = "colAlgoritmo";
            colAlgoritmo.ReadOnly = true;
            // 
            // colTamano
            // 
            colTamano.HeaderText = "Tamaño";
            colTamano.MinimumWidth = 8;
            colTamano.Name = "colTamano";
            colTamano.ReadOnly = true;
            // 
            // colAleatorio
            // 
            colAleatorio.HeaderText = "Aleatorio (ms)";
            colAleatorio.MinimumWidth = 8;
            colAleatorio.Name = "colAleatorio";
            colAleatorio.ReadOnly = true;
            // 
            // colOrdenado
            // 
            colOrdenado.HeaderText = "Ordenado (ms)";
            colOrdenado.MinimumWidth = 8;
            colOrdenado.Name = "colOrdenado";
            colOrdenado.ReadOnly = true;
            // 
            // colInverso
            // 
            colInverso.HeaderText = "Orden Inverso (ms)";
            colInverso.MinimumWidth = 8;
            colInverso.Name = "colInverso";
            colInverso.ReadOnly = true;
            // 
            // colPromedio
            // 
            colPromedio.HeaderText = "Promedio (ms)";
            colPromedio.MinimumWidth = 8;
            colPromedio.Name = "colPromedio";
            colPromedio.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 585);
            Controls.Add(dgvResultados);
            Controls.Add(panelSuperior);
            Font = new Font("Segoe UI", 9.5F);
            MinimumSize = new Size(950, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tarea 5.2 - Banco de Pruebas de Algoritmos de Ordenamiento";
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Label lblTitulo;
        private Label lblTamano;
        private ComboBox cmbTamano;
        private Label lblAlgoritmos;
        private CheckedListBox clbAlgoritmos;
        private Button btnEjecutar;
        private Button btnEjecutarUno;
        private Button btnLimpiar;
        private ProgressBar progressBar;
        private Label lblEstado;
        private Label lblAdvertencia;
        private DataGridView dgvResultados;
        private DataGridViewTextBoxColumn colAlgoritmo;
        private DataGridViewTextBoxColumn colTamano;
        private DataGridViewTextBoxColumn colAleatorio;
        private DataGridViewTextBoxColumn colOrdenado;
        private DataGridViewTextBoxColumn colInverso;
        private DataGridViewTextBoxColumn colPromedio;
    }
}
