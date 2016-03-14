namespace Nonograms
{
    partial class form_Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Create));
            this.dgv_JC = new System.Windows.Forms.DataGridView();
            this.jcnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nDBDataSet = new Nonograms.NDBDataSet();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_Create_Cross = new System.Windows.Forms.Button();
            this.btn_Back_To_Menu = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pn_Menu = new System.Windows.Forms.Panel();
            this.jcTableAdapter = new Nonograms.NDBDataSetTableAdapters.jcTableAdapter();
            this.pn_Size = new System.Windows.Forms.Panel();
            this.btn_Size_Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Size_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_Width = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_Height = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_JC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDBDataSet)).BeginInit();
            this.pn_Menu.SuspendLayout();
            this.pn_Size.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Height)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_JC
            // 
            this.dgv_JC.AllowUserToDeleteRows = false;
            this.dgv_JC.AutoGenerateColumns = false;
            this.dgv_JC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_JC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jcnameDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.topDataGridViewTextBoxColumn,
            this.leftDataGridViewTextBoxColumn});
            this.dgv_JC.DataSource = this.jcBindingSource;
            this.dgv_JC.Location = new System.Drawing.Point(65, 98);
            this.dgv_JC.Name = "dgv_JC";
            this.dgv_JC.ReadOnly = true;
            this.dgv_JC.Size = new System.Drawing.Size(10, 10);
            this.dgv_JC.TabIndex = 2;
            // 
            // jcnameDataGridViewTextBoxColumn
            // 
            this.jcnameDataGridViewTextBoxColumn.DataPropertyName = "jc_name";
            this.jcnameDataGridViewTextBoxColumn.HeaderText = "jc_name";
            this.jcnameDataGridViewTextBoxColumn.Name = "jcnameDataGridViewTextBoxColumn";
            this.jcnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // topDataGridViewTextBoxColumn
            // 
            this.topDataGridViewTextBoxColumn.DataPropertyName = "top";
            this.topDataGridViewTextBoxColumn.HeaderText = "top";
            this.topDataGridViewTextBoxColumn.Name = "topDataGridViewTextBoxColumn";
            this.topDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leftDataGridViewTextBoxColumn
            // 
            this.leftDataGridViewTextBoxColumn.DataPropertyName = "left";
            this.leftDataGridViewTextBoxColumn.HeaderText = "left";
            this.leftDataGridViewTextBoxColumn.Name = "leftDataGridViewTextBoxColumn";
            this.leftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jcBindingSource
            // 
            this.jcBindingSource.DataMember = "jc";
            this.jcBindingSource.DataSource = this.nDBDataSet;
            // 
            // nDBDataSet
            // 
            this.nDBDataSet.DataSetName = "NDBDataSet";
            this.nDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Name.Location = new System.Drawing.Point(3, 3);
            this.tb_Name.MaxLength = 30;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(139, 22);
            this.tb_Name.TabIndex = 3;
            this.tb_Name.Text = "Введите название";
            // 
            // btn_Create_Cross
            // 
            this.btn_Create_Cross.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Create_Cross.Location = new System.Drawing.Point(3, 31);
            this.btn_Create_Cross.Name = "btn_Create_Cross";
            this.btn_Create_Cross.Size = new System.Drawing.Size(139, 23);
            this.btn_Create_Cross.TabIndex = 4;
            this.btn_Create_Cross.Text = "Сохранить кроссворд";
            this.btn_Create_Cross.UseVisualStyleBackColor = true;
            this.btn_Create_Cross.Click += new System.EventHandler(this.btn_Create_Cross_Click);
            // 
            // btn_Back_To_Menu
            // 
            this.btn_Back_To_Menu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Back_To_Menu.Location = new System.Drawing.Point(3, 60);
            this.btn_Back_To_Menu.Name = "btn_Back_To_Menu";
            this.btn_Back_To_Menu.Size = new System.Drawing.Size(139, 23);
            this.btn_Back_To_Menu.TabIndex = 5;
            this.btn_Back_To_Menu.Text = "Вернуться в меню";
            this.btn_Back_To_Menu.UseVisualStyleBackColor = true;
            this.btn_Back_To_Menu.Click += new System.EventHandler(this.btn_Back_To_Menu_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Exit.Location = new System.Drawing.Point(3, 89);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(139, 23);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Выход";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pn_Menu
            // 
            this.pn_Menu.Controls.Add(this.tb_Name);
            this.pn_Menu.Controls.Add(this.btn_Exit);
            this.pn_Menu.Controls.Add(this.btn_Create_Cross);
            this.pn_Menu.Controls.Add(this.dgv_JC);
            this.pn_Menu.Controls.Add(this.btn_Back_To_Menu);
            this.pn_Menu.Location = new System.Drawing.Point(361, 239);
            this.pn_Menu.Name = "pn_Menu";
            this.pn_Menu.Size = new System.Drawing.Size(147, 120);
            this.pn_Menu.TabIndex = 7;
            this.pn_Menu.Visible = false;
            // 
            // jcTableAdapter
            // 
            this.jcTableAdapter.ClearBeforeFill = true;
            // 
            // pn_Size
            // 
            this.pn_Size.Controls.Add(this.btn_Size_Cancel);
            this.pn_Size.Controls.Add(this.label3);
            this.pn_Size.Controls.Add(this.btn_Size_Ok);
            this.pn_Size.Controls.Add(this.label1);
            this.pn_Size.Controls.Add(this.nud_Width);
            this.pn_Size.Controls.Add(this.label2);
            this.pn_Size.Controls.Add(this.nud_Height);
            this.pn_Size.Location = new System.Drawing.Point(12, 12);
            this.pn_Size.Name = "pn_Size";
            this.pn_Size.Size = new System.Drawing.Size(274, 148);
            this.pn_Size.TabIndex = 0;
            // 
            // btn_Size_Cancel
            // 
            this.btn_Size_Cancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Size_Cancel.Location = new System.Drawing.Point(140, 102);
            this.btn_Size_Cancel.Name = "btn_Size_Cancel";
            this.btn_Size_Cancel.Size = new System.Drawing.Size(122, 23);
            this.btn_Size_Cancel.TabIndex = 5;
            this.btn_Size_Cancel.Text = "Отмена";
            this.btn_Size_Cancel.UseVisualStyleBackColor = true;
            this.btn_Size_Cancel.Click += new System.EventHandler(this.btn_Size_Cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(75, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Высота";
            // 
            // btn_Size_Ok
            // 
            this.btn_Size_Ok.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Size_Ok.Location = new System.Drawing.Point(7, 102);
            this.btn_Size_Ok.Name = "btn_Size_Ok";
            this.btn_Size_Ok.Size = new System.Drawing.Size(127, 23);
            this.btn_Size_Ok.TabIndex = 4;
            this.btn_Size_Ok.Text = "Создать поле";
            this.btn_Size_Ok.UseVisualStyleBackColor = true;
            this.btn_Size_Ok.Click += new System.EventHandler(this.btn_Size_Ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задайте размер вашего кроссворда";
            // 
            // nud_Width
            // 
            this.nud_Width.Location = new System.Drawing.Point(147, 42);
            this.nud_Width.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_Width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Width.Name = "nud_Width";
            this.nud_Width.Size = new System.Drawing.Size(46, 20);
            this.nud_Width.TabIndex = 1;
            this.nud_Width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(75, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ширина";
            // 
            // nud_Height
            // 
            this.nud_Height.Location = new System.Drawing.Point(147, 68);
            this.nud_Height.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_Height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Height.Name = "nud_Height";
            this.nud_Height.Size = new System.Drawing.Size(46, 20);
            this.nud_Height.TabIndex = 3;
            this.nud_Height.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // form_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(294, 172);
            this.Controls.Add(this.pn_Menu);
            this.Controls.Add(this.pn_Size);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_Create";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.Text = "Создать кроссворд";
            this.Load += new System.EventHandler(this.form_Create_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_JC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDBDataSet)).EndInit();
            this.pn_Menu.ResumeLayout(false);
            this.pn_Menu.PerformLayout();
            this.pn_Size.ResumeLayout(false);
            this.pn_Size.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Height)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_JC;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Create_Cross;
        private System.Windows.Forms.Button btn_Back_To_Menu;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel pn_Menu;
        private NDBDataSet nDBDataSet;
        private System.Windows.Forms.BindingSource jcBindingSource;
        private NDBDataSetTableAdapters.jcTableAdapter jcTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jcnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn winDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Panel pn_Size;
        private System.Windows.Forms.Button btn_Size_Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Size_Ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_Width;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_Height;
    }
}