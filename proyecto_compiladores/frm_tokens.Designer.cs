namespace proyecto_compiladores
{
    partial class frm_tokens
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
            this.dataGridView_tokens = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_tokens_error = new System.Windows.Forms.DataGridView();
            this.dataGridView_tokens_validado = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_input = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.idTokenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lexemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoLexemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTokenErrorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lexemaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTokenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokenerrorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTokenDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lexemaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoLexemaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tokens)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tokens_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tokens_validado)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tokenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenerrorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_tokens
            // 
            this.dataGridView_tokens.AllowUserToAddRows = false;
            this.dataGridView_tokens.AllowUserToDeleteRows = false;
            this.dataGridView_tokens.AutoGenerateColumns = false;
            this.dataGridView_tokens.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_tokens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_tokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTokenDataGridViewTextBoxColumn,
            this.lexemaDataGridViewTextBoxColumn,
            this.tipoLexemaDataGridViewTextBoxColumn});
            this.dataGridView_tokens.DataSource = this.tokenBindingSource;
            this.dataGridView_tokens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_tokens.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_tokens.Name = "dataGridView_tokens";
            this.dataGridView_tokens.ReadOnly = true;
            this.dataGridView_tokens.Size = new System.Drawing.Size(542, 377);
            this.dataGridView_tokens.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1114, 570);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView_tokens_validado, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 37);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1108, 530);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridView_tokens, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView_tokens_error, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.14815F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.85185F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(548, 524);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dataGridView_tokens_error
            // 
            this.dataGridView_tokens_error.AllowUserToAddRows = false;
            this.dataGridView_tokens_error.AllowUserToDeleteRows = false;
            this.dataGridView_tokens_error.AutoGenerateColumns = false;
            this.dataGridView_tokens_error.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_tokens_error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_tokens_error.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tokens_error.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTokenErrorDataGridViewTextBoxColumn,
            this.lexemaDataGridViewTextBoxColumn1,
            this.errorDataGridViewTextBoxColumn,
            this.idTokenDataGridViewTextBoxColumn1});
            this.dataGridView_tokens_error.DataSource = this.tokenerrorBindingSource;
            this.dataGridView_tokens_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_tokens_error.Location = new System.Drawing.Point(3, 386);
            this.dataGridView_tokens_error.Name = "dataGridView_tokens_error";
            this.dataGridView_tokens_error.ReadOnly = true;
            this.dataGridView_tokens_error.Size = new System.Drawing.Size(542, 135);
            this.dataGridView_tokens_error.TabIndex = 1;
            // 
            // dataGridView_tokens_validado
            // 
            this.dataGridView_tokens_validado.AllowUserToAddRows = false;
            this.dataGridView_tokens_validado.AllowUserToDeleteRows = false;
            this.dataGridView_tokens_validado.AutoGenerateColumns = false;
            this.dataGridView_tokens_validado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_tokens_validado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_tokens_validado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tokens_validado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTokenDataGridViewTextBoxColumn2,
            this.lexemaDataGridViewTextBoxColumn2,
            this.tipoLexemaDataGridViewTextBoxColumn1});
            this.dataGridView_tokens_validado.DataSource = this.tokenBindingSource1;
            this.dataGridView_tokens_validado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_tokens_validado.Location = new System.Drawing.Point(557, 3);
            this.dataGridView_tokens_validado.Name = "dataGridView_tokens_validado";
            this.dataGridView_tokens_validado.ReadOnly = true;
            this.dataGridView_tokens_validado.Size = new System.Drawing.Size(548, 524);
            this.dataGridView_tokens_validado.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_input, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1108, 28);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(557, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "TOKENS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_input
            // 
            this.lbl_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_input.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_input.Location = new System.Drawing.Point(3, 0);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(548, 21);
            this.lbl_input.TabIndex = 3;
            this.lbl_input.Text = "RESULTADO DEL ANÁLISIS";
            this.lbl_input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.15385F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.846154F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1120, 632);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // idTokenDataGridViewTextBoxColumn
            // 
            this.idTokenDataGridViewTextBoxColumn.DataPropertyName = "Id_Token";
            this.idTokenDataGridViewTextBoxColumn.HeaderText = "Id_Token";
            this.idTokenDataGridViewTextBoxColumn.Name = "idTokenDataGridViewTextBoxColumn";
            this.idTokenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lexemaDataGridViewTextBoxColumn
            // 
            this.lexemaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lexemaDataGridViewTextBoxColumn.DataPropertyName = "Lexema";
            this.lexemaDataGridViewTextBoxColumn.HeaderText = "Lexema";
            this.lexemaDataGridViewTextBoxColumn.Name = "lexemaDataGridViewTextBoxColumn";
            this.lexemaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoLexemaDataGridViewTextBoxColumn
            // 
            this.tipoLexemaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoLexemaDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Lexema";
            this.tipoLexemaDataGridViewTextBoxColumn.HeaderText = "Tipo_Lexema";
            this.tipoLexemaDataGridViewTextBoxColumn.Name = "tipoLexemaDataGridViewTextBoxColumn";
            this.tipoLexemaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tokenBindingSource
            // 
            this.tokenBindingSource.DataSource = typeof(proyecto_compiladores.token);
            // 
            // idTokenErrorDataGridViewTextBoxColumn
            // 
            this.idTokenErrorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idTokenErrorDataGridViewTextBoxColumn.DataPropertyName = "Id_Token_Error";
            this.idTokenErrorDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idTokenErrorDataGridViewTextBoxColumn.Name = "idTokenErrorDataGridViewTextBoxColumn";
            this.idTokenErrorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTokenErrorDataGridViewTextBoxColumn.Width = 43;
            // 
            // lexemaDataGridViewTextBoxColumn1
            // 
            this.lexemaDataGridViewTextBoxColumn1.DataPropertyName = "Lexema";
            this.lexemaDataGridViewTextBoxColumn1.HeaderText = "Lexema";
            this.lexemaDataGridViewTextBoxColumn1.Name = "lexemaDataGridViewTextBoxColumn1";
            this.lexemaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lexemaDataGridViewTextBoxColumn1.Width = 105;
            // 
            // errorDataGridViewTextBoxColumn
            // 
            this.errorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.errorDataGridViewTextBoxColumn.DataPropertyName = "Error";
            this.errorDataGridViewTextBoxColumn.HeaderText = "Error";
            this.errorDataGridViewTextBoxColumn.Name = "errorDataGridViewTextBoxColumn";
            this.errorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idTokenDataGridViewTextBoxColumn1
            // 
            this.idTokenDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idTokenDataGridViewTextBoxColumn1.DataPropertyName = "Id_Token";
            this.idTokenDataGridViewTextBoxColumn1.HeaderText = "ID Token";
            this.idTokenDataGridViewTextBoxColumn1.Name = "idTokenDataGridViewTextBoxColumn1";
            this.idTokenDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idTokenDataGridViewTextBoxColumn1.Width = 77;
            // 
            // tokenerrorBindingSource
            // 
            this.tokenerrorBindingSource.DataSource = typeof(proyecto_compiladores.token_error);
            // 
            // idTokenDataGridViewTextBoxColumn2
            // 
            this.idTokenDataGridViewTextBoxColumn2.DataPropertyName = "Id_Token";
            this.idTokenDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.idTokenDataGridViewTextBoxColumn2.Name = "idTokenDataGridViewTextBoxColumn2";
            this.idTokenDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lexemaDataGridViewTextBoxColumn2
            // 
            this.lexemaDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lexemaDataGridViewTextBoxColumn2.DataPropertyName = "Lexema";
            this.lexemaDataGridViewTextBoxColumn2.HeaderText = "Lexema";
            this.lexemaDataGridViewTextBoxColumn2.Name = "lexemaDataGridViewTextBoxColumn2";
            this.lexemaDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tipoLexemaDataGridViewTextBoxColumn1
            // 
            this.tipoLexemaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoLexemaDataGridViewTextBoxColumn1.DataPropertyName = "Tipo_Lexema";
            this.tipoLexemaDataGridViewTextBoxColumn1.HeaderText = "Tipo Lexema";
            this.tipoLexemaDataGridViewTextBoxColumn1.Name = "tipoLexemaDataGridViewTextBoxColumn1";
            this.tipoLexemaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tokenBindingSource1
            // 
            this.tokenBindingSource1.DataSource = typeof(proyecto_compiladores.token);
            // 
            // frm_tokens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1120, 632);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "frm_tokens";
            this.Text = "[TOKENS] - Análisis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tokens)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tokens_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tokens_validado)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tokenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenerrorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_tokens;
        private System.Windows.Forms.BindingSource tokenBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTokenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lexemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoLexemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridView_tokens_error;
        private System.Windows.Forms.DataGridView dataGridView_tokens_validado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.BindingSource tokenerrorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaErrorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaErrorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTokenDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lexemaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoLexemaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource tokenBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTokenErrorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lexemaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTokenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}