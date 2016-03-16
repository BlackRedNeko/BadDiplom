namespace Nonograms
{
    partial class form_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Game));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jcnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nDBDataSet = new Nonograms.NDBDataSet();
            this.btn_Check_Cross = new System.Windows.Forms.Button();
            this.lbl_Help = new System.Windows.Forms.Label();
            this.btn_Help = new System.Windows.Forms.Button();
            this.lbl_Cross_Name = new System.Windows.Forms.Label();
            this.btn_Main_Menu = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pn_Menu = new System.Windows.Forms.Panel();
            this.pn_Start = new System.Windows.Forms.Panel();
            this.pb_Load = new System.Windows.Forms.ProgressBar();
            this.jcTableAdapter = new Nonograms.NDBDataSetTableAdapters.jcTableAdapter();
            this.pn_Right = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDBDataSet)).BeginInit();
            this.pn_Menu.SuspendLayout();
            this.pn_Start.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jcnameDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.topDataGridViewTextBoxColumn,
            this.leftDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jcBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(228, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 0;
            // 
            // jcnameDataGridViewTextBoxColumn
            // 
            this.jcnameDataGridViewTextBoxColumn.DataPropertyName = "jc_name";
            this.jcnameDataGridViewTextBoxColumn.HeaderText = "jc_name";
            this.jcnameDataGridViewTextBoxColumn.Name = "jcnameDataGridViewTextBoxColumn";
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // topDataGridViewTextBoxColumn
            // 
            this.topDataGridViewTextBoxColumn.DataPropertyName = "top";
            this.topDataGridViewTextBoxColumn.HeaderText = "top";
            this.topDataGridViewTextBoxColumn.Name = "topDataGridViewTextBoxColumn";
            // 
            // leftDataGridViewTextBoxColumn
            // 
            this.leftDataGridViewTextBoxColumn.DataPropertyName = "left";
            this.leftDataGridViewTextBoxColumn.HeaderText = "left";
            this.leftDataGridViewTextBoxColumn.Name = "leftDataGridViewTextBoxColumn";
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
            // btn_Check_Cross
            // 
            this.btn_Check_Cross.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Check_Cross.Location = new System.Drawing.Point(3, 3);
            this.btn_Check_Cross.Name = "btn_Check_Cross";
            this.btn_Check_Cross.Size = new System.Drawing.Size(150, 31);
            this.btn_Check_Cross.TabIndex = 1;
            this.btn_Check_Cross.Text = "Проверить / Готово";
            this.btn_Check_Cross.UseVisualStyleBackColor = true;
            this.btn_Check_Cross.Click += new System.EventHandler(this.btn_Check_Cross_Click);
            // 
            // lbl_Help
            // 
            this.lbl_Help.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Help.Location = new System.Drawing.Point(51, 13);
            this.lbl_Help.Name = "lbl_Help";
            this.lbl_Help.Size = new System.Drawing.Size(10, 10);
            this.lbl_Help.TabIndex = 2;
            this.lbl_Help.Visible = false;
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(382, 14);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(10, 10);
            this.btn_Help.TabIndex = 3;
            this.btn_Help.Text = "button1";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // lbl_Cross_Name
            // 
            this.lbl_Cross_Name.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Cross_Name.Location = new System.Drawing.Point(12, 9);
            this.lbl_Cross_Name.Name = "lbl_Cross_Name";
            this.lbl_Cross_Name.Size = new System.Drawing.Size(600, 50);
            this.lbl_Cross_Name.TabIndex = 4;
            // 
            // btn_Main_Menu
            // 
            this.btn_Main_Menu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Main_Menu.Location = new System.Drawing.Point(159, 3);
            this.btn_Main_Menu.Name = "btn_Main_Menu";
            this.btn_Main_Menu.Size = new System.Drawing.Size(150, 31);
            this.btn_Main_Menu.TabIndex = 5;
            this.btn_Main_Menu.Text = "Главное Меню";
            this.btn_Main_Menu.UseVisualStyleBackColor = true;
            this.btn_Main_Menu.Click += new System.EventHandler(this.btn_Main_Menu_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Exit.Location = new System.Drawing.Point(315, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(150, 31);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Выход";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pn_Menu
            // 
            this.pn_Menu.Controls.Add(this.btn_Check_Cross);
            this.pn_Menu.Controls.Add(this.btn_Exit);
            this.pn_Menu.Controls.Add(this.btn_Main_Menu);
            this.pn_Menu.Controls.Add(this.lbl_Help);
            this.pn_Menu.Controls.Add(this.btn_Help);
            this.pn_Menu.Controls.Add(this.dataGridView1);
            this.pn_Menu.Location = new System.Drawing.Point(12, 309);
            this.pn_Menu.Name = "pn_Menu";
            this.pn_Menu.Size = new System.Drawing.Size(469, 39);
            this.pn_Menu.TabIndex = 7;
            // 
            // pn_Start
            // 
            this.pn_Start.Controls.Add(this.pb_Load);
            this.pn_Start.Location = new System.Drawing.Point(12, 12);
            this.pn_Start.Name = "pn_Start";
            this.pn_Start.Size = new System.Drawing.Size(150, 50);
            this.pn_Start.TabIndex = 8;
            // 
            // pb_Load
            // 
            this.pb_Load.Location = new System.Drawing.Point(27, 12);
            this.pb_Load.Name = "pb_Load";
            this.pb_Load.Size = new System.Drawing.Size(100, 23);
            this.pb_Load.TabIndex = 9;
            // 
            // jcTableAdapter
            // 
            this.jcTableAdapter.ClearBeforeFill = true;
            // 
            // pn_Right
            // 
            this.pn_Right.Location = new System.Drawing.Point(338, 141);
            this.pn_Right.Name = "pn_Right";
            this.pn_Right.Size = new System.Drawing.Size(1, 1);
            this.pn_Right.TabIndex = 9;
            // 
            // form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(174, 72);
            this.Controls.Add(this.pn_Right);
            this.Controls.Add(this.pn_Start);
            this.Controls.Add(this.pn_Menu);
            this.Controls.Add(this.lbl_Cross_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_Game";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.Text = "Игра";
            this.Load += new System.EventHandler(this.form_Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDBDataSet)).EndInit();
            this.pn_Menu.ResumeLayout(false);
            this.pn_Start.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn winDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btn_Check_Cross;
        public System.Windows.Forms.Label lbl_Help;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Label lbl_Cross_Name;
        private System.Windows.Forms.Button btn_Main_Menu;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel pn_Menu;
        private System.Windows.Forms.Panel pn_Start;
        private System.Windows.Forms.ProgressBar pb_Load;
        private NDBDataSet nDBDataSet;
        private System.Windows.Forms.BindingSource jcBindingSource;
        private NDBDataSetTableAdapters.jcTableAdapter jcTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jcnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Panel pn_Right;
    }
}