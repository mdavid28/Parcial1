namespace proyecto_compiladores
{
    partial class frm_mantenimiento
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_ingresar = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ingresar_mantenimiento = new System.Windows.Forms.Button();
            this.txt_ingresar_mantenimiento = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_actualizar_palabra_reservada = new System.Windows.Forms.Button();
            this.cbx_estado_actualizar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_palabra_reservada_actualizar = new System.Windows.Forms.TextBox();
            this.txt_id_palabra_reservada_actualizar = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_baja_eliminar = new System.Windows.Forms.Button();
            this.btn_eliminar_registro = new System.Windows.Forms.Button();
            this.cbx_estado_eliminar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_palabra_reservada_eliminar = new System.Windows.Forms.TextBox();
            this.txt_id_palabra_reservada_eliminar = new System.Windows.Forms.TextBox();
            this.dataGridViewPalabrasReservadas = new System.Windows.Forms.DataGridView();
            this.idPalabraReservadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palabraReservadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palabrasreservadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.constructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tab_ingresar.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPalabrasReservadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palabrasreservadasBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.constructorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_ingresar);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 97);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_ingresar
            // 
            this.tab_ingresar.Controls.Add(this.label1);
            this.tab_ingresar.Controls.Add(this.btn_ingresar_mantenimiento);
            this.tab_ingresar.Controls.Add(this.txt_ingresar_mantenimiento);
            this.tab_ingresar.Location = new System.Drawing.Point(4, 22);
            this.tab_ingresar.Name = "tab_ingresar";
            this.tab_ingresar.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ingresar.Size = new System.Drawing.Size(765, 71);
            this.tab_ingresar.TabIndex = 0;
            this.tab_ingresar.Text = "Ingresar";
            this.tab_ingresar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese una palabra reservada";
            // 
            // btn_ingresar_mantenimiento
            // 
            this.btn_ingresar_mantenimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ingresar_mantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar_mantenimiento.Location = new System.Drawing.Point(494, 6);
            this.btn_ingresar_mantenimiento.Name = "btn_ingresar_mantenimiento";
            this.btn_ingresar_mantenimiento.Size = new System.Drawing.Size(263, 56);
            this.btn_ingresar_mantenimiento.TabIndex = 1;
            this.btn_ingresar_mantenimiento.Text = "Ingresar Palabra Reservada";
            this.btn_ingresar_mantenimiento.UseVisualStyleBackColor = true;
            this.btn_ingresar_mantenimiento.Click += new System.EventHandler(this.btn_ingresar_mantenimiento_Click);
            // 
            // txt_ingresar_mantenimiento
            // 
            this.txt_ingresar_mantenimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ingresar_mantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ingresar_mantenimiento.Location = new System.Drawing.Point(12, 30);
            this.txt_ingresar_mantenimiento.Name = "txt_ingresar_mantenimiento";
            this.txt_ingresar_mantenimiento.Size = new System.Drawing.Size(476, 29);
            this.txt_ingresar_mantenimiento.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_actualizar_palabra_reservada);
            this.tabPage2.Controls.Add(this.cbx_estado_actualizar);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_palabra_reservada_actualizar);
            this.tabPage2.Controls.Add(this.txt_id_palabra_reservada_actualizar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(765, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actualizar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_actualizar_palabra_reservada
            // 
            this.btn_actualizar_palabra_reservada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_actualizar_palabra_reservada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar_palabra_reservada.Location = new System.Drawing.Point(568, 9);
            this.btn_actualizar_palabra_reservada.Name = "btn_actualizar_palabra_reservada";
            this.btn_actualizar_palabra_reservada.Size = new System.Drawing.Size(189, 56);
            this.btn_actualizar_palabra_reservada.TabIndex = 8;
            this.btn_actualizar_palabra_reservada.Text = "Actualizar Datos";
            this.btn_actualizar_palabra_reservada.UseVisualStyleBackColor = true;
            this.btn_actualizar_palabra_reservada.Click += new System.EventHandler(this.btn_actualizar_palabra_reservada_Click);
            // 
            // cbx_estado_actualizar
            // 
            this.cbx_estado_actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_estado_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_estado_actualizar.FormattingEnabled = true;
            this.cbx_estado_actualizar.Items.AddRange(new object[] {
            "Activo",
            "Baja"});
            this.cbx_estado_actualizar.Location = new System.Drawing.Point(441, 36);
            this.cbx_estado_actualizar.Name = "cbx_estado_actualizar";
            this.cbx_estado_actualizar.Size = new System.Drawing.Size(121, 28);
            this.cbx_estado_actualizar.TabIndex = 7;
            this.cbx_estado_actualizar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(437, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Palabra Reservada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // txt_palabra_reservada_actualizar
            // 
            this.txt_palabra_reservada_actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_palabra_reservada_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_palabra_reservada_actualizar.Location = new System.Drawing.Point(83, 36);
            this.txt_palabra_reservada_actualizar.Name = "txt_palabra_reservada_actualizar";
            this.txt_palabra_reservada_actualizar.Size = new System.Drawing.Size(352, 29);
            this.txt_palabra_reservada_actualizar.TabIndex = 2;
            // 
            // txt_id_palabra_reservada_actualizar
            // 
            this.txt_id_palabra_reservada_actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_id_palabra_reservada_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_palabra_reservada_actualizar.Location = new System.Drawing.Point(8, 36);
            this.txt_id_palabra_reservada_actualizar.Name = "txt_id_palabra_reservada_actualizar";
            this.txt_id_palabra_reservada_actualizar.Size = new System.Drawing.Size(69, 29);
            this.txt_id_palabra_reservada_actualizar.TabIndex = 1;
            this.txt_id_palabra_reservada_actualizar.TextChanged += new System.EventHandler(this.txt_id_palabra_reservada_actualizar_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_baja_eliminar);
            this.tabPage3.Controls.Add(this.btn_eliminar_registro);
            this.tabPage3.Controls.Add(this.cbx_estado_eliminar);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txt_palabra_reservada_eliminar);
            this.tabPage3.Controls.Add(this.txt_id_palabra_reservada_eliminar);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(765, 71);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_baja_eliminar
            // 
            this.btn_baja_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_baja_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baja_eliminar.Location = new System.Drawing.Point(470, 7);
            this.btn_baja_eliminar.Name = "btn_baja_eliminar";
            this.btn_baja_eliminar.Size = new System.Drawing.Size(118, 56);
            this.btn_baja_eliminar.TabIndex = 16;
            this.btn_baja_eliminar.Text = "Dar de Baja";
            this.btn_baja_eliminar.UseVisualStyleBackColor = true;
            this.btn_baja_eliminar.Click += new System.EventHandler(this.btn_baja_eliminar_Click);
            // 
            // btn_eliminar_registro
            // 
            this.btn_eliminar_registro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar_registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_registro.Location = new System.Drawing.Point(594, 7);
            this.btn_eliminar_registro.Name = "btn_eliminar_registro";
            this.btn_eliminar_registro.Size = new System.Drawing.Size(163, 56);
            this.btn_eliminar_registro.TabIndex = 15;
            this.btn_eliminar_registro.Text = "Eliminar Registro";
            this.btn_eliminar_registro.UseVisualStyleBackColor = true;
            this.btn_eliminar_registro.Click += new System.EventHandler(this.btn_eliminar_registro_Click);
            // 
            // cbx_estado_eliminar
            // 
            this.cbx_estado_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_estado_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_estado_eliminar.FormattingEnabled = true;
            this.cbx_estado_eliminar.Items.AddRange(new object[] {
            "Activo",
            "Baja"});
            this.cbx_estado_eliminar.Location = new System.Drawing.Point(342, 34);
            this.cbx_estado_eliminar.Name = "cbx_estado_eliminar";
            this.cbx_estado_eliminar.Size = new System.Drawing.Size(121, 28);
            this.cbx_estado_eliminar.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Palabra Reservada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "ID";
            // 
            // txt_palabra_reservada_eliminar
            // 
            this.txt_palabra_reservada_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_palabra_reservada_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_palabra_reservada_eliminar.Location = new System.Drawing.Point(83, 34);
            this.txt_palabra_reservada_eliminar.Name = "txt_palabra_reservada_eliminar";
            this.txt_palabra_reservada_eliminar.Size = new System.Drawing.Size(253, 29);
            this.txt_palabra_reservada_eliminar.TabIndex = 10;
            // 
            // txt_id_palabra_reservada_eliminar
            // 
            this.txt_id_palabra_reservada_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_id_palabra_reservada_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_palabra_reservada_eliminar.Location = new System.Drawing.Point(8, 34);
            this.txt_id_palabra_reservada_eliminar.Name = "txt_id_palabra_reservada_eliminar";
            this.txt_id_palabra_reservada_eliminar.Size = new System.Drawing.Size(69, 29);
            this.txt_id_palabra_reservada_eliminar.TabIndex = 9;
            this.txt_id_palabra_reservada_eliminar.TextChanged += new System.EventHandler(this.txt_id_palabra_reservada_eliminar_TextChanged);
            // 
            // dataGridViewPalabrasReservadas
            // 
            this.dataGridViewPalabrasReservadas.AllowUserToAddRows = false;
            this.dataGridViewPalabrasReservadas.AllowUserToDeleteRows = false;
            this.dataGridViewPalabrasReservadas.AutoGenerateColumns = false;
            this.dataGridViewPalabrasReservadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPalabrasReservadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPalabraReservadaDataGridViewTextBoxColumn,
            this.palabraReservadaDataGridViewTextBoxColumn,
            this.estadoRegistroDataGridViewTextBoxColumn});
            this.dataGridViewPalabrasReservadas.DataSource = this.palabrasreservadasBindingSource;
            this.dataGridViewPalabrasReservadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPalabrasReservadas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPalabrasReservadas.Name = "dataGridViewPalabrasReservadas";
            this.dataGridViewPalabrasReservadas.ReadOnly = true;
            this.dataGridViewPalabrasReservadas.Size = new System.Drawing.Size(773, 375);
            this.dataGridViewPalabrasReservadas.TabIndex = 0;
            // 
            // idPalabraReservadaDataGridViewTextBoxColumn
            // 
            this.idPalabraReservadaDataGridViewTextBoxColumn.DataPropertyName = "Id_Palabra_Reservada";
            this.idPalabraReservadaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idPalabraReservadaDataGridViewTextBoxColumn.Name = "idPalabraReservadaDataGridViewTextBoxColumn";
            this.idPalabraReservadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // palabraReservadaDataGridViewTextBoxColumn
            // 
            this.palabraReservadaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.palabraReservadaDataGridViewTextBoxColumn.DataPropertyName = "Palabra_Reservada";
            this.palabraReservadaDataGridViewTextBoxColumn.HeaderText = "Palabra Reservada";
            this.palabraReservadaDataGridViewTextBoxColumn.Name = "palabraReservadaDataGridViewTextBoxColumn";
            this.palabraReservadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoRegistroDataGridViewTextBoxColumn
            // 
            this.estadoRegistroDataGridViewTextBoxColumn.DataPropertyName = "Estado_Registro";
            this.estadoRegistroDataGridViewTextBoxColumn.HeaderText = "Estado Registro";
            this.estadoRegistroDataGridViewTextBoxColumn.Name = "estadoRegistroDataGridViewTextBoxColumn";
            this.estadoRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoRegistroDataGridViewTextBoxColumn.Width = 120;
            // 
            // palabrasreservadasBindingSource
            // 
            this.palabrasreservadasBindingSource.DataSource = typeof(proyecto_compiladores.palabras_reservadas);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 97);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewPalabrasReservadas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 375);
            this.panel2.TabIndex = 3;
            // 
            // constructorBindingSource
            // 
            this.constructorBindingSource.DataSource = typeof(proyecto_compiladores.constructor);
            // 
            // frm_mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(773, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_mantenimiento";
            this.Text = "Mantenimiento - Palabras Reservadas";
            this.tabControl1.ResumeLayout(false);
            this.tab_ingresar.ResumeLayout(false);
            this.tab_ingresar.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPalabrasReservadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palabrasreservadasBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.constructorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_ingresar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewPalabrasReservadas;
        private System.Windows.Forms.BindingSource constructorBindingSource;
        private System.Windows.Forms.BindingSource palabrasreservadasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPalabraReservadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn palabraReservadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_ingresar_mantenimiento;
        private System.Windows.Forms.TextBox txt_ingresar_mantenimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbx_estado_actualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_palabra_reservada_actualizar;
        private System.Windows.Forms.TextBox txt_id_palabra_reservada_actualizar;
        private System.Windows.Forms.Button btn_actualizar_palabra_reservada;
        private System.Windows.Forms.Button btn_baja_eliminar;
        private System.Windows.Forms.Button btn_eliminar_registro;
        private System.Windows.Forms.ComboBox cbx_estado_eliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_palabra_reservada_eliminar;
        private System.Windows.Forms.TextBox txt_id_palabra_reservada_eliminar;
    }
}