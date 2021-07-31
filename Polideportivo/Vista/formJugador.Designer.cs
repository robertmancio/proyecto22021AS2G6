﻿
namespace Polideportivo.Vista
{
    partial class formJugador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formJugador));
            this.tablaJugadores = new Zuby.ADGV.AdvancedDataGridView();
            this.pkIdJugadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anotacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdRolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdDeporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwjugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaJugadores1 = new Polideportivo.tablaJugadores();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.btnModificarJugador = new System.Windows.Forms.Button();
            this.btnAgregarJugador = new System.Windows.Forms.Button();
            this.vwjugadorTableAdapter = new Polideportivo.tablaJugadoresTableAdapters.vwjugadorTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwjugadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadores1)).BeginInit();
            this.parrotGradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaJugadores
            // 
            this.tablaJugadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaJugadores.AutoGenerateColumns = false;
            this.tablaJugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaJugadores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaJugadores.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaJugadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaJugadores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaJugadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkIdJugadorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.anotacionesDataGridViewTextBoxColumn,
            this.pkIdRolDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn,
            this.pkIdEquipoDataGridViewTextBoxColumn,
            this.equipoDataGridViewTextBoxColumn,
            this.pkIdDeporteDataGridViewTextBoxColumn,
            this.deporteDataGridViewTextBoxColumn});
            this.tablaJugadores.DataSource = this.vwjugadorBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaJugadores.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaJugadores.FilterAndSortEnabled = true;
            this.tablaJugadores.Location = new System.Drawing.Point(69, 123);
            this.tablaJugadores.Name = "tablaJugadores";
            this.tablaJugadores.ReadOnly = true;
            this.tablaJugadores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablaJugadores.RowHeadersVisible = false;
            this.tablaJugadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaJugadores.Size = new System.Drawing.Size(768, 413);
            this.tablaJugadores.TabIndex = 5;
            this.tablaJugadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaJugadores_CellClick);
            // 
            // pkIdJugadorDataGridViewTextBoxColumn
            // 
            this.pkIdJugadorDataGridViewTextBoxColumn.DataPropertyName = "pkIdJugador";
            this.pkIdJugadorDataGridViewTextBoxColumn.HeaderText = "pkIdJugador";
            this.pkIdJugadorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdJugadorDataGridViewTextBoxColumn.Name = "pkIdJugadorDataGridViewTextBoxColumn";
            this.pkIdJugadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdJugadorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pkIdJugadorDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // anotacionesDataGridViewTextBoxColumn
            // 
            this.anotacionesDataGridViewTextBoxColumn.DataPropertyName = "anotaciones";
            this.anotacionesDataGridViewTextBoxColumn.HeaderText = "Anotaciones";
            this.anotacionesDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.anotacionesDataGridViewTextBoxColumn.Name = "anotacionesDataGridViewTextBoxColumn";
            this.anotacionesDataGridViewTextBoxColumn.ReadOnly = true;
            this.anotacionesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pkIdRolDataGridViewTextBoxColumn
            // 
            this.pkIdRolDataGridViewTextBoxColumn.DataPropertyName = "pkIdRol";
            this.pkIdRolDataGridViewTextBoxColumn.HeaderText = "pkIdRol";
            this.pkIdRolDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdRolDataGridViewTextBoxColumn.Name = "pkIdRolDataGridViewTextBoxColumn";
            this.pkIdRolDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdRolDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pkIdRolDataGridViewTextBoxColumn.Visible = false;
            // 
            // rolDataGridViewTextBoxColumn
            // 
            this.rolDataGridViewTextBoxColumn.DataPropertyName = "rol";
            this.rolDataGridViewTextBoxColumn.HeaderText = "Rol";
            this.rolDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            this.rolDataGridViewTextBoxColumn.ReadOnly = true;
            this.rolDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pkIdEquipoDataGridViewTextBoxColumn
            // 
            this.pkIdEquipoDataGridViewTextBoxColumn.DataPropertyName = "pkIdEquipo";
            this.pkIdEquipoDataGridViewTextBoxColumn.HeaderText = "pkIdEquipo";
            this.pkIdEquipoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdEquipoDataGridViewTextBoxColumn.Name = "pkIdEquipoDataGridViewTextBoxColumn";
            this.pkIdEquipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdEquipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pkIdEquipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipoDataGridViewTextBoxColumn
            // 
            this.equipoDataGridViewTextBoxColumn.DataPropertyName = "equipo";
            this.equipoDataGridViewTextBoxColumn.HeaderText = "Equipo";
            this.equipoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.equipoDataGridViewTextBoxColumn.Name = "equipoDataGridViewTextBoxColumn";
            this.equipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pkIdDeporteDataGridViewTextBoxColumn
            // 
            this.pkIdDeporteDataGridViewTextBoxColumn.DataPropertyName = "pkIdDeporte";
            this.pkIdDeporteDataGridViewTextBoxColumn.HeaderText = "pkIdDeporte";
            this.pkIdDeporteDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdDeporteDataGridViewTextBoxColumn.Name = "pkIdDeporteDataGridViewTextBoxColumn";
            this.pkIdDeporteDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdDeporteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pkIdDeporteDataGridViewTextBoxColumn.Visible = false;
            // 
            // deporteDataGridViewTextBoxColumn
            // 
            this.deporteDataGridViewTextBoxColumn.DataPropertyName = "deporte";
            this.deporteDataGridViewTextBoxColumn.HeaderText = "Deporte";
            this.deporteDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.deporteDataGridViewTextBoxColumn.Name = "deporteDataGridViewTextBoxColumn";
            this.deporteDataGridViewTextBoxColumn.ReadOnly = true;
            this.deporteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // vwjugadorBindingSource
            // 
            this.vwjugadorBindingSource.DataMember = "vwjugador";
            this.vwjugadorBindingSource.DataSource = this.tablaJugadores1;
            // 
            // tablaJugadores1
            // 
            this.tablaJugadores1.DataSetName = "tablaJugadores";
            this.tablaJugadores1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.MidnightBlue;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Controls.Add(this.button1);
            this.parrotGradientPanel1.Controls.Add(this.btnActualizar);
            this.parrotGradientPanel1.Controls.Add(this.panel1);
            this.parrotGradientPanel1.Controls.Add(this.panel2);
            this.parrotGradientPanel1.Controls.Add(this.btnModificarJugador);
            this.parrotGradientPanel1.Controls.Add(this.btnAgregarJugador);
            this.parrotGradientPanel1.Controls.Add(this.tablaJugadores);
            this.parrotGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(900, 595);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel1.TabIndex = 8;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.Navy;
            // 
            // btnModificarJugador
            // 
            this.btnModificarJugador.BackColor = System.Drawing.Color.White;
            this.btnModificarJugador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarJugador.FlatAppearance.BorderSize = 0;
            this.btnModificarJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarJugador.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarJugador.ForeColor = System.Drawing.Color.Black;
            this.btnModificarJugador.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarJugador.Image")));
            this.btnModificarJugador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarJugador.Location = new System.Drawing.Point(627, 71);
            this.btnModificarJugador.Name = "btnModificarJugador";
            this.btnModificarJugador.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnModificarJugador.Size = new System.Drawing.Size(210, 36);
            this.btnModificarJugador.TabIndex = 28;
            this.btnModificarJugador.Text = "    M O D I F I C A R";
            this.btnModificarJugador.UseVisualStyleBackColor = false;
            this.btnModificarJugador.Click += new System.EventHandler(this.btnModificarJugador_Click);
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.BackColor = System.Drawing.Color.White;
            this.btnAgregarJugador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarJugador.FlatAppearance.BorderSize = 0;
            this.btnAgregarJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarJugador.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarJugador.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarJugador.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarJugador.Image")));
            this.btnAgregarJugador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarJugador.Location = new System.Drawing.Point(387, 71);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAgregarJugador.Size = new System.Drawing.Size(210, 36);
            this.btnAgregarJugador.TabIndex = 27;
            this.btnAgregarJugador.Text = "     A G R E G A R";
            this.btnAgregarJugador.UseVisualStyleBackColor = false;
            this.btnAgregarJugador.Click += new System.EventHandler(this.btnAgregarJugador_Click);
            // 
            // vwjugadorTableAdapter
            // 
            this.vwjugadorTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtFiltrar);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(69, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 36);
            this.panel2.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFiltrar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrar.Location = new System.Drawing.Point(37, 9);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(252, 20);
            this.txtFiltrar.TabIndex = 1;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cboBuscar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(69, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 36);
            this.panel1.TabIndex = 31;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // cboBuscar
            // 
            this.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBuscar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "nombre",
            "anotaciones",
            "deporte",
            "rol",
            "equipo"});
            this.cboBuscar.Location = new System.Drawing.Point(36, 6);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(263, 26);
            this.cboBuscar.TabIndex = 32;
            this.cboBuscar.SelectedIndexChanged += new System.EventHandler(this.cboBuscar_SelectedIndexChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(387, 22);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnActualizar.Size = new System.Drawing.Size(210, 36);
            this.btnActualizar.TabIndex = 32;
            this.btnActualizar.Text = "      A C T U A L I Z A R";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(627, 22);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(210, 36);
            this.button1.TabIndex = 33;
            this.button1.Text = "   E L I M I N A R";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // formJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.parrotGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formJugador";
            this.Text = "formJugador";
            this.Load += new System.EventHandler(this.formJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwjugadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadores1)).EndInit();
            this.parrotGradientPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Zuby.ADGV.AdvancedDataGridView tablaJugadores;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private tablaJugadores tablaJugadores1;
        private System.Windows.Forms.BindingSource vwjugadorBindingSource;
        private tablaJugadoresTableAdapters.vwjugadorTableAdapter vwjugadorTableAdapter;
        private System.Windows.Forms.Button btnAgregarJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdJugadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anotacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdRolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdEquipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdDeporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnModificarJugador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button button1;
    }
}