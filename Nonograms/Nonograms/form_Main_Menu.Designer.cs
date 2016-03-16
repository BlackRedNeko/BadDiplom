namespace Nonograms
{
    partial class form_Main_Menu
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Main_Menu));
            this.dgv_Nonograms = new System.Windows.Forms.DataGridView();
            this.jcnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nDBDataSet = new Nonograms.NDBDataSet();
            this.cb_Chosen_Cross = new System.Windows.Forms.ComboBox();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Tutorial = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.nDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jcTableAdapter = new Nonograms.NDBDataSetTableAdapters.jcTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nonograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Nonograms
            // 
            this.dgv_Nonograms.AllowUserToAddRows = false;
            this.dgv_Nonograms.AllowUserToDeleteRows = false;
            this.dgv_Nonograms.AutoGenerateColumns = false;
            this.dgv_Nonograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Nonograms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jcnameDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.topDataGridViewTextBoxColumn,
            this.leftDataGridViewTextBoxColumn});
            this.dgv_Nonograms.DataSource = this.jcBindingSource;
            this.dgv_Nonograms.Location = new System.Drawing.Point(267, 490);
            this.dgv_Nonograms.Name = "dgv_Nonograms";
            this.dgv_Nonograms.ReadOnly = true;
            this.dgv_Nonograms.Size = new System.Drawing.Size(10, 10);
            this.dgv_Nonograms.TabIndex = 0;
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
            // cb_Chosen_Cross
            // 
            this.cb_Chosen_Cross.DropDownHeight = 150;
            this.cb_Chosen_Cross.FormattingEnabled = true;
            this.cb_Chosen_Cross.IntegralHeight = false;
            this.cb_Chosen_Cross.Location = new System.Drawing.Point(12, 294);
            this.cb_Chosen_Cross.Name = "cb_Chosen_Cross";
            this.cb_Chosen_Cross.Size = new System.Drawing.Size(279, 21);
            this.cb_Chosen_Cross.TabIndex = 1;
            this.cb_Chosen_Cross.Text = "Выбрать кроссворд";
            // 
            // btn_Play
            // 
            this.btn_Play.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Play.Location = new System.Drawing.Point(297, 288);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(75, 29);
            this.btn_Play.TabIndex = 2;
            this.btn_Play.Text = "Начать";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Create.Location = new System.Drawing.Point(12, 475);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(360, 35);
            this.btn_Create.TabIndex = 3;
            this.btn_Create.Text = "Создать кроссворд";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Tutorial
            // 
            this.btn_Tutorial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Tutorial.Location = new System.Drawing.Point(12, 516);
            this.btn_Tutorial.Name = "btn_Tutorial";
            this.btn_Tutorial.Size = new System.Drawing.Size(186, 34);
            this.btn_Tutorial.TabIndex = 4;
            this.btn_Tutorial.Text = "Как играть";
            this.btn_Tutorial.UseVisualStyleBackColor = true;
            this.btn_Tutorial.Click += new System.EventHandler(this.btn_Tutorial_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Exit.Location = new System.Drawing.Point(204, 516);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(168, 34);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Выход";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // nDBDataSetBindingSource
            // 
            this.nDBDataSetBindingSource.DataSource = this.nDBDataSet;
            this.nDBDataSetBindingSource.Position = 0;
            // 
            // jcTableAdapter
            // 
            this.jcTableAdapter.ClearBeforeFill = true;
            // 
            // form_Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nonograms.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(384, 562);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Tutorial);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.cb_Chosen_Cross);
            this.Controls.Add(this.dgv_Nonograms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 568);
            this.Name = "form_Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nonograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Nonograms;
        private System.Windows.Forms.ComboBox cb_Chosen_Cross;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Tutorial;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn winDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource jcrossBindingSource;
        private System.Windows.Forms.BindingSource nDBDataSetBindingSource;
        private NDBDataSet nDBDataSet;
        private System.Windows.Forms.BindingSource jcBindingSource;
        private NDBDataSetTableAdapters.jcTableAdapter jcTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jcnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}

