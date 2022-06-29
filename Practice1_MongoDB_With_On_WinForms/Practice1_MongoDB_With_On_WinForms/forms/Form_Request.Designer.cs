namespace Practice1_MongoDB_With_On_WinForms.forms
{
    partial class Form_Request
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_SelectFilter = new System.Windows.Forms.Label();
            this.label_Filter = new System.Windows.Forms.Label();
            this.tb_FilterValue = new System.Windows.Forms.TextBox();
            this.cb_Filters = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Enter filter value";
            // 
            // label_SelectFilter
            // 
            this.label_SelectFilter.AutoSize = true;
            this.label_SelectFilter.Location = new System.Drawing.Point(500, 263);
            this.label_SelectFilter.Name = "label_SelectFilter";
            this.label_SelectFilter.Size = new System.Drawing.Size(59, 13);
            this.label_SelectFilter.TabIndex = 16;
            this.label_SelectFilter.Text = "Select filter";
            // 
            // label_Filter
            // 
            this.label_Filter.AutoSize = true;
            this.label_Filter.Location = new System.Drawing.Point(434, 303);
            this.label_Filter.Name = "label_Filter";
            this.label_Filter.Size = new System.Drawing.Size(32, 13);
            this.label_Filter.TabIndex = 15;
            this.label_Filter.Text = "Filter:";
            // 
            // tb_FilterValue
            // 
            this.tb_FilterValue.Location = new System.Drawing.Point(648, 296);
            this.tb_FilterValue.Name = "tb_FilterValue";
            this.tb_FilterValue.Size = new System.Drawing.Size(100, 20);
            this.tb_FilterValue.TabIndex = 14;
            this.tb_FilterValue.TextChanged += new System.EventHandler(this.tb_FilterValue_TextChanged);
            // 
            // cb_Filters
            // 
            this.cb_Filters.FormattingEnabled = true;
            this.cb_Filters.Location = new System.Drawing.Point(503, 295);
            this.cb_Filters.Name = "cb_Filters";
            this.cb_Filters.Size = new System.Drawing.Size(121, 21);
            this.cb_Filters.TabIndex = 13;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(22, 397);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(107, 34);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "Delete request";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(22, 282);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(107, 34);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Add new request";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(22, 341);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(107, 34);
            this.btn_Edit.TabIndex = 10;
            this.btn_Edit.Text = "Edit request";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(800, 230);
            this.dataGridView.TabIndex = 9;
            // 
            // Form_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_SelectFilter);
            this.Controls.Add(this.label_Filter);
            this.Controls.Add(this.tb_FilterValue);
            this.Controls.Add(this.cb_Filters);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form_Request";
            this.Text = "Form_Request";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_SelectFilter;
        private System.Windows.Forms.Label label_Filter;
        private System.Windows.Forms.TextBox tb_FilterValue;
        private System.Windows.Forms.ComboBox cb_Filters;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}