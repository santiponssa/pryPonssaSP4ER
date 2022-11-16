namespace pryPonssaSP4ER
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabVentanas = new System.Windows.Forms.TabControl();
            this.tabValidarDatos = new System.Windows.Forms.TabPage();
            this.btnLimpiar1 = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.ColumnaMozo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaComidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaBSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaBCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPostres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnValidar = new System.Windows.Forms.Button();
            this.tabTotales = new System.Windows.Forms.TabPage();
            this.mrcMozoDia = new System.Windows.Forms.GroupBox();
            this.cmdMostrar2 = new System.Windows.Forms.Button();
            this.lblTotalDia = new System.Windows.Forms.Label();
            this.lblMozoDia = new System.Windows.Forms.Label();
            this.mrcTotalMozos = new System.Windows.Forms.GroupBox();
            this.cmdLimpiar2 = new System.Windows.Forms.Button();
            this.lblTotalGeneralMostrar = new System.Windows.Forms.Label();
            this.lblPostreMostrar = new System.Windows.Forms.Label();
            this.lblComidasMostrar = new System.Windows.Forms.Label();
            this.lblCAMostrar = new System.Windows.Forms.Label();
            this.lblSAMostrar = new System.Windows.Forms.Label();
            this.lblTotalGeneral = new System.Windows.Forms.Label();
            this.lblPostres = new System.Windows.Forms.Label();
            this.lblComidas = new System.Windows.Forms.Label();
            this.lblBebidasCA = new System.Windows.Forms.Label();
            this.lblBebidasSA = new System.Windows.Forms.Label();
            this.cmdCalcular2 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabVentanas.SuspendLayout();
            this.tabValidarDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.tabTotales.SuspendLayout();
            this.mrcMozoDia.SuspendLayout();
            this.mrcTotalMozos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabVentanas
            // 
            this.tabVentanas.Controls.Add(this.tabValidarDatos);
            this.tabVentanas.Controls.Add(this.tabTotales);
            this.tabVentanas.Location = new System.Drawing.Point(13, 14);
            this.tabVentanas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabVentanas.Name = "tabVentanas";
            this.tabVentanas.SelectedIndex = 0;
            this.tabVentanas.Size = new System.Drawing.Size(789, 411);
            this.tabVentanas.TabIndex = 11;
            // 
            // tabValidarDatos
            // 
            this.tabValidarDatos.Controls.Add(this.btnLimpiar1);
            this.tabValidarDatos.Controls.Add(this.dgvVentas);
            this.tabValidarDatos.Controls.Add(this.btnValidar);
            this.tabValidarDatos.Location = new System.Drawing.Point(4, 29);
            this.tabValidarDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabValidarDatos.Name = "tabValidarDatos";
            this.tabValidarDatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabValidarDatos.Size = new System.Drawing.Size(781, 378);
            this.tabValidarDatos.TabIndex = 0;
            this.tabValidarDatos.Text = "Validar datos";
            this.tabValidarDatos.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar1
            // 
            this.btnLimpiar1.BackColor = System.Drawing.Color.White;
            this.btnLimpiar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar1.Location = new System.Drawing.Point(460, 292);
            this.btnLimpiar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar1.Name = "btnLimpiar1";
            this.btnLimpiar1.Size = new System.Drawing.Size(123, 51);
            this.btnLimpiar1.TabIndex = 3;
            this.btnLimpiar1.Text = "Limpiar";
            this.btnLimpiar1.UseVisualStyleBackColor = false;
            this.btnLimpiar1.Click += new System.EventHandler(this.btnLimpiar1_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToResizeColumns = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaMozo,
            this.ColumnaComidas,
            this.ColumnaBSA,
            this.ColumnaBCA,
            this.ColumnaPostres});
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.Location = new System.Drawing.Point(10, 22);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.RowHeadersWidth = 62;
            this.dgvVentas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvVentas.Size = new System.Drawing.Size(753, 243);
            this.dgvVentas.TabIndex = 0;
            // 
            // ColumnaMozo
            // 
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Menu;
            this.ColumnaMozo.DefaultCellStyle = dataGridViewCellStyle38;
            this.ColumnaMozo.HeaderText = "Mozo";
            this.ColumnaMozo.MinimumWidth = 8;
            this.ColumnaMozo.Name = "ColumnaMozo";
            this.ColumnaMozo.Width = 150;
            // 
            // ColumnaComidas
            // 
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle39.Format = "N2";
            dataGridViewCellStyle39.NullValue = null;
            this.ColumnaComidas.DefaultCellStyle = dataGridViewCellStyle39;
            this.ColumnaComidas.HeaderText = "Comidas";
            this.ColumnaComidas.MinimumWidth = 8;
            this.ColumnaComidas.Name = "ColumnaComidas";
            this.ColumnaComidas.Width = 150;
            // 
            // ColumnaBSA
            // 
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle40.Format = "N2";
            dataGridViewCellStyle40.NullValue = null;
            this.ColumnaBSA.DefaultCellStyle = dataGridViewCellStyle40;
            this.ColumnaBSA.HeaderText = "Bebidas sin alcohol";
            this.ColumnaBSA.MinimumWidth = 8;
            this.ColumnaBSA.Name = "ColumnaBSA";
            this.ColumnaBSA.Width = 150;
            // 
            // ColumnaBCA
            // 
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle41.Format = "N2";
            dataGridViewCellStyle41.NullValue = null;
            this.ColumnaBCA.DefaultCellStyle = dataGridViewCellStyle41;
            this.ColumnaBCA.HeaderText = "Bebidas con alcohol";
            this.ColumnaBCA.MinimumWidth = 8;
            this.ColumnaBCA.Name = "ColumnaBCA";
            this.ColumnaBCA.Width = 150;
            // 
            // ColumnaPostres
            // 
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle42.Format = "N2";
            dataGridViewCellStyle42.NullValue = null;
            this.ColumnaPostres.DefaultCellStyle = dataGridViewCellStyle42;
            this.ColumnaPostres.HeaderText = "Postres";
            this.ColumnaPostres.MinimumWidth = 8;
            this.ColumnaPostres.Name = "ColumnaPostres";
            this.ColumnaPostres.Width = 150;
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.White;
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(640, 292);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(123, 51);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "Validar ";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // tabTotales
            // 
            this.tabTotales.Controls.Add(this.mrcMozoDia);
            this.tabTotales.Controls.Add(this.mrcTotalMozos);
            this.tabTotales.Location = new System.Drawing.Point(4, 29);
            this.tabTotales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTotales.Name = "tabTotales";
            this.tabTotales.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTotales.Size = new System.Drawing.Size(781, 378);
            this.tabTotales.TabIndex = 3;
            this.tabTotales.Text = "Totales ";
            this.tabTotales.UseVisualStyleBackColor = true;
            // 
            // mrcMozoDia
            // 
            this.mrcMozoDia.Controls.Add(this.cmdMostrar2);
            this.mrcMozoDia.Controls.Add(this.lblTotalDia);
            this.mrcMozoDia.Controls.Add(this.lblMozoDia);
            this.mrcMozoDia.Location = new System.Drawing.Point(430, 20);
            this.mrcMozoDia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcMozoDia.Name = "mrcMozoDia";
            this.mrcMozoDia.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcMozoDia.Size = new System.Drawing.Size(318, 311);
            this.mrcMozoDia.TabIndex = 9;
            this.mrcMozoDia.TabStop = false;
            this.mrcMozoDia.Text = "Mozo del día";
            // 
            // cmdMostrar2
            // 
            this.cmdMostrar2.BackColor = System.Drawing.Color.White;
            this.cmdMostrar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMostrar2.Location = new System.Drawing.Point(154, 252);
            this.cmdMostrar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdMostrar2.Name = "cmdMostrar2";
            this.cmdMostrar2.Size = new System.Drawing.Size(123, 49);
            this.cmdMostrar2.TabIndex = 10;
            this.cmdMostrar2.Text = "Mostrar";
            this.cmdMostrar2.UseVisualStyleBackColor = false;
            this.cmdMostrar2.Click += new System.EventHandler(this.cmdMostrar2_Click);
            // 
            // lblTotalDia
            // 
            this.lblTotalDia.AutoSize = true;
            this.lblTotalDia.Location = new System.Drawing.Point(34, 149);
            this.lblTotalDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDia.Name = "lblTotalDia";
            this.lblTotalDia.Size = new System.Drawing.Size(0, 20);
            this.lblTotalDia.TabIndex = 1;
            // 
            // lblMozoDia
            // 
            this.lblMozoDia.AutoSize = true;
            this.lblMozoDia.Location = new System.Drawing.Point(34, 72);
            this.lblMozoDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMozoDia.Name = "lblMozoDia";
            this.lblMozoDia.Size = new System.Drawing.Size(0, 20);
            this.lblMozoDia.TabIndex = 0;
            // 
            // mrcTotalMozos
            // 
            this.mrcTotalMozos.Controls.Add(this.cmdLimpiar2);
            this.mrcTotalMozos.Controls.Add(this.lblTotalGeneralMostrar);
            this.mrcTotalMozos.Controls.Add(this.lblPostreMostrar);
            this.mrcTotalMozos.Controls.Add(this.lblComidasMostrar);
            this.mrcTotalMozos.Controls.Add(this.lblCAMostrar);
            this.mrcTotalMozos.Controls.Add(this.lblSAMostrar);
            this.mrcTotalMozos.Controls.Add(this.lblTotalGeneral);
            this.mrcTotalMozos.Controls.Add(this.lblPostres);
            this.mrcTotalMozos.Controls.Add(this.lblComidas);
            this.mrcTotalMozos.Controls.Add(this.lblBebidasCA);
            this.mrcTotalMozos.Controls.Add(this.lblBebidasSA);
            this.mrcTotalMozos.Controls.Add(this.cmdCalcular2);
            this.mrcTotalMozos.Location = new System.Drawing.Point(27, 20);
            this.mrcTotalMozos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcTotalMozos.Name = "mrcTotalMozos";
            this.mrcTotalMozos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcTotalMozos.Size = new System.Drawing.Size(394, 311);
            this.mrcTotalMozos.TabIndex = 0;
            this.mrcTotalMozos.TabStop = false;
            this.mrcTotalMozos.Text = "Total por mozo";
            // 
            // cmdLimpiar2
            // 
            this.cmdLimpiar2.BackColor = System.Drawing.Color.White;
            this.cmdLimpiar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar2.Location = new System.Drawing.Point(57, 254);
            this.cmdLimpiar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdLimpiar2.Name = "cmdLimpiar2";
            this.cmdLimpiar2.Size = new System.Drawing.Size(123, 48);
            this.cmdLimpiar2.TabIndex = 9;
            this.cmdLimpiar2.Text = "Limpiar";
            this.cmdLimpiar2.UseVisualStyleBackColor = false;
            // 
            // lblTotalGeneralMostrar
            // 
            this.lblTotalGeneralMostrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalGeneralMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalGeneralMostrar.Location = new System.Drawing.Point(207, 205);
            this.lblTotalGeneralMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalGeneralMostrar.Name = "lblTotalGeneralMostrar";
            this.lblTotalGeneralMostrar.Size = new System.Drawing.Size(123, 34);
            this.lblTotalGeneralMostrar.TabIndex = 11;
            // 
            // lblPostreMostrar
            // 
            this.lblPostreMostrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPostreMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPostreMostrar.Location = new System.Drawing.Point(207, 165);
            this.lblPostreMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPostreMostrar.Name = "lblPostreMostrar";
            this.lblPostreMostrar.Size = new System.Drawing.Size(123, 34);
            this.lblPostreMostrar.TabIndex = 10;
            // 
            // lblComidasMostrar
            // 
            this.lblComidasMostrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblComidasMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComidasMostrar.Location = new System.Drawing.Point(207, 45);
            this.lblComidasMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComidasMostrar.Name = "lblComidasMostrar";
            this.lblComidasMostrar.Size = new System.Drawing.Size(123, 34);
            this.lblComidasMostrar.TabIndex = 9;
            // 
            // lblCAMostrar
            // 
            this.lblCAMostrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCAMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCAMostrar.Location = new System.Drawing.Point(207, 125);
            this.lblCAMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCAMostrar.Name = "lblCAMostrar";
            this.lblCAMostrar.Size = new System.Drawing.Size(123, 34);
            this.lblCAMostrar.TabIndex = 8;
            // 
            // lblSAMostrar
            // 
            this.lblSAMostrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSAMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSAMostrar.Location = new System.Drawing.Point(207, 85);
            this.lblSAMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSAMostrar.Name = "lblSAMostrar";
            this.lblSAMostrar.Size = new System.Drawing.Size(123, 34);
            this.lblSAMostrar.TabIndex = 7;
            // 
            // lblTotalGeneral
            // 
            this.lblTotalGeneral.AutoSize = true;
            this.lblTotalGeneral.Location = new System.Drawing.Point(28, 206);
            this.lblTotalGeneral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalGeneral.Name = "lblTotalGeneral";
            this.lblTotalGeneral.Size = new System.Drawing.Size(109, 20);
            this.lblTotalGeneral.TabIndex = 6;
            this.lblTotalGeneral.Text = "Total General:";
            // 
            // lblPostres
            // 
            this.lblPostres.AutoSize = true;
            this.lblPostres.Location = new System.Drawing.Point(28, 166);
            this.lblPostres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPostres.Name = "lblPostres";
            this.lblPostres.Size = new System.Drawing.Size(67, 20);
            this.lblPostres.TabIndex = 5;
            this.lblPostres.Text = "Postres:";
            // 
            // lblComidas
            // 
            this.lblComidas.AutoSize = true;
            this.lblComidas.Location = new System.Drawing.Point(28, 46);
            this.lblComidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComidas.Name = "lblComidas";
            this.lblComidas.Size = new System.Drawing.Size(75, 20);
            this.lblComidas.TabIndex = 4;
            this.lblComidas.Text = "Comidas:";
            // 
            // lblBebidasCA
            // 
            this.lblBebidasCA.AutoSize = true;
            this.lblBebidasCA.Location = new System.Drawing.Point(28, 126);
            this.lblBebidasCA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBebidasCA.Name = "lblBebidasCA";
            this.lblBebidasCA.Size = new System.Drawing.Size(155, 20);
            this.lblBebidasCA.TabIndex = 3;
            this.lblBebidasCA.Text = "Bebidas con alcohol:";
            // 
            // lblBebidasSA
            // 
            this.lblBebidasSA.AutoSize = true;
            this.lblBebidasSA.Location = new System.Drawing.Point(28, 86);
            this.lblBebidasSA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBebidasSA.Name = "lblBebidasSA";
            this.lblBebidasSA.Size = new System.Drawing.Size(149, 20);
            this.lblBebidasSA.TabIndex = 2;
            this.lblBebidasSA.Text = "Bebidas sin alcohol:";
            // 
            // cmdCalcular2
            // 
            this.cmdCalcular2.BackColor = System.Drawing.Color.White;
            this.cmdCalcular2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalcular2.Location = new System.Drawing.Point(190, 254);
            this.cmdCalcular2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdCalcular2.Name = "cmdCalcular2";
            this.cmdCalcular2.Size = new System.Drawing.Size(123, 48);
            this.cmdCalcular2.TabIndex = 1;
            this.cmdCalcular2.Text = "Calcular";
            this.cmdCalcular2.UseVisualStyleBackColor = false;
            this.cmdCalcular2.Click += new System.EventHandler(this.cmdCalcular2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(648, 435);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 42);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 492);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tabVentanas);
            this.Name = "frmMain";
            this.Text = "Bar La Milanga";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabVentanas.ResumeLayout(false);
            this.tabValidarDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.tabTotales.ResumeLayout(false);
            this.mrcMozoDia.ResumeLayout(false);
            this.mrcMozoDia.PerformLayout();
            this.mrcTotalMozos.ResumeLayout(false);
            this.mrcTotalMozos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabVentanas;
        private System.Windows.Forms.TabPage tabValidarDatos;
        private System.Windows.Forms.Button btnLimpiar1;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaMozo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaComidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaBSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaBCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPostres;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.TabPage tabTotales;
        private System.Windows.Forms.GroupBox mrcMozoDia;
        private System.Windows.Forms.Button cmdMostrar2;
        private System.Windows.Forms.Label lblTotalDia;
        private System.Windows.Forms.Label lblMozoDia;
        private System.Windows.Forms.GroupBox mrcTotalMozos;
        private System.Windows.Forms.Button cmdLimpiar2;
        private System.Windows.Forms.Label lblTotalGeneralMostrar;
        private System.Windows.Forms.Label lblPostreMostrar;
        private System.Windows.Forms.Label lblComidasMostrar;
        private System.Windows.Forms.Label lblCAMostrar;
        private System.Windows.Forms.Label lblSAMostrar;
        private System.Windows.Forms.Label lblTotalGeneral;
        private System.Windows.Forms.Label lblPostres;
        private System.Windows.Forms.Label lblComidas;
        private System.Windows.Forms.Label lblBebidasCA;
        private System.Windows.Forms.Label lblBebidasSA;
        private System.Windows.Forms.Button cmdCalcular2;
        private System.Windows.Forms.Button btnSalir;
    }
}

