namespace Proyecto_Hospital
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDiag = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.hospitalDataSet = new Proyecto_Hospital.hospitalDataSet();
            this.pacienteDiagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteDiagTableAdapter = new Proyecto_Hospital.hospitalDataSetTableAdapters.pacienteDiagTableAdapter();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sintomasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDiagBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(25, 72);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar Paciente";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDiag
            // 
            this.btnDiag.Location = new System.Drawing.Point(25, 119);
            this.btnDiag.Name = "btnDiag";
            this.btnDiag.Size = new System.Drawing.Size(114, 23);
            this.btnDiag.TabIndex = 2;
            this.btnDiag.Text = "Agregar Diagnostico";
            this.btnDiag.UseVisualStyleBackColor = true;
            this.btnDiag.Click += new System.EventHandler(this.btnDiag_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(25, 166);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(114, 23);
            this.btnHistorial.TabIndex = 3;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(25, 209);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(114, 23);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "Informacion";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "CONTROLADOR";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(42, 265);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Proyecto_Hospital.Properties.Resources.raccoon_dance;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 294);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.cbGenero);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblGenero);
            this.panel1.Controls.Add(this.lblEdad);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtEdad);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Location = new System.Drawing.Point(187, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 403);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtMedicamento);
            this.panel2.Controls.Add(this.txtDiagnostico);
            this.panel2.Controls.Add(this.txtSintomas);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.txtpid);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(187, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 403);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(392, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Location = new System.Drawing.Point(90, 369);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(123, 20);
            this.txtMedicamento.TabIndex = 11;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(90, 311);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(123, 20);
            this.txtDiagnostico.TabIndex = 10;
            // 
            // txtSintomas
            // 
            this.txtSintomas.Location = new System.Drawing.Point(90, 281);
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(123, 20);
            this.txtSintomas.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(15, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Medicamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(15, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Diagnostico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(15, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sintomas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidDataGridViewTextBoxColumn,
            this.sintomasDataGridViewTextBoxColumn,
            this.diagnosticoDataGridViewTextBoxColumn,
            this.medicamentoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pacienteDiagBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 78);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(132, 77);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(213, 20);
            this.txtpid.TabIndex = 2;
            this.txtpid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(30, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Pid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(261, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Agregar Diagnostico de Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Agregar nuevo paciente";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(395, 335);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Mapache"});
            this.cbGenero.Location = new System.Drawing.Point(377, 217);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 16;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(77, 266);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(80, 13);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "ID del Paciente";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(77, 225);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 12;
            this.lblGenero.Text = "Genero";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.Color.White;
            this.lblEdad.Location = new System.Drawing.Point(77, 184);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 11;
            this.lblEdad.Text = "Edad";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(77, 141);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(77, 91);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(77, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(377, 134);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(377, 259);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 4;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(377, 177);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(121, 20);
            this.txtEdad.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(377, 84);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(121, 20);
            this.txtDireccion.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(377, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "hospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteDiagBindingSource
            // 
            this.pacienteDiagBindingSource.DataMember = "pacienteDiag";
            this.pacienteDiagBindingSource.DataSource = this.hospitalDataSet;
            // 
            // pacienteDiagTableAdapter
            // 
            this.pacienteDiagTableAdapter.ClearBeforeFill = true;
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "pid";
            this.pidDataGridViewTextBoxColumn.HeaderText = "pid";
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            // 
            // sintomasDataGridViewTextBoxColumn
            // 
            this.sintomasDataGridViewTextBoxColumn.DataPropertyName = "sintomas";
            this.sintomasDataGridViewTextBoxColumn.HeaderText = "sintomas";
            this.sintomasDataGridViewTextBoxColumn.Name = "sintomasDataGridViewTextBoxColumn";
            // 
            // diagnosticoDataGridViewTextBoxColumn
            // 
            this.diagnosticoDataGridViewTextBoxColumn.DataPropertyName = "diagnostico";
            this.diagnosticoDataGridViewTextBoxColumn.HeaderText = "diagnostico";
            this.diagnosticoDataGridViewTextBoxColumn.Name = "diagnosticoDataGridViewTextBoxColumn";
            // 
            // medicamentoDataGridViewTextBoxColumn
            // 
            this.medicamentoDataGridViewTextBoxColumn.DataPropertyName = "medicamento";
            this.medicamentoDataGridViewTextBoxColumn.HeaderText = "medicamento";
            this.medicamentoDataGridViewTextBoxColumn.Name = "medicamentoDataGridViewTextBoxColumn";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnDiag);
            this.Controls.Add(this.btnAdd);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDiagBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDiag;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private hospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource pacienteDiagBindingSource;
        private hospitalDataSetTableAdapters.pacienteDiagTableAdapter pacienteDiagTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sintomasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamentoDataGridViewTextBoxColumn;
    }
}