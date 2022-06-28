namespace Practice1_MongoDB_With_On_WinForms.forms
{
    partial class Form_Abonent_Edit
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
            this.tb_Fio = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tb_Street = new System.Windows.Forms.TextBox();
            this.tb_Flat = new System.Windows.Forms.TextBox();
            this.tb_House = new System.Windows.Forms.TextBox();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.label_Fio = new System.Windows.Forms.Label();
            this.label_House = new System.Windows.Forms.Label();
            this.label_Street = new System.Windows.Forms.Label();
            this.label_Flat = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Fio
            // 
            this.tb_Fio.Location = new System.Drawing.Point(191, 87);
            this.tb_Fio.Name = "tb_Fio";
            this.tb_Fio.Size = new System.Drawing.Size(194, 20);
            this.tb_Fio.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(31, 301);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 35);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Save changes";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(474, 301);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(94, 35);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tb_Street
            // 
            this.tb_Street.Location = new System.Drawing.Point(191, 127);
            this.tb_Street.Name = "tb_Street";
            this.tb_Street.Size = new System.Drawing.Size(194, 20);
            this.tb_Street.TabIndex = 3;
            // 
            // tb_Flat
            // 
            this.tb_Flat.Location = new System.Drawing.Point(191, 203);
            this.tb_Flat.Name = "tb_Flat";
            this.tb_Flat.Size = new System.Drawing.Size(194, 20);
            this.tb_Flat.TabIndex = 4;
            // 
            // tb_House
            // 
            this.tb_House.Location = new System.Drawing.Point(191, 168);
            this.tb_House.Name = "tb_House";
            this.tb_House.Size = new System.Drawing.Size(194, 20);
            this.tb_House.TabIndex = 5;
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(191, 251);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(194, 20);
            this.tb_Phone.TabIndex = 6;
            // 
            // label_Fio
            // 
            this.label_Fio.AutoSize = true;
            this.label_Fio.Location = new System.Drawing.Point(137, 90);
            this.label_Fio.Name = "label_Fio";
            this.label_Fio.Size = new System.Drawing.Size(24, 13);
            this.label_Fio.TabIndex = 7;
            this.label_Fio.Text = "Fio:";
            // 
            // label_House
            // 
            this.label_House.AutoSize = true;
            this.label_House.Location = new System.Drawing.Point(137, 175);
            this.label_House.Name = "label_House";
            this.label_House.Size = new System.Drawing.Size(41, 13);
            this.label_House.TabIndex = 8;
            this.label_House.Text = "House:";
            // 
            // label_Street
            // 
            this.label_Street.AutoSize = true;
            this.label_Street.Location = new System.Drawing.Point(137, 134);
            this.label_Street.Name = "label_Street";
            this.label_Street.Size = new System.Drawing.Size(38, 13);
            this.label_Street.TabIndex = 9;
            this.label_Street.Text = "Street:";
            // 
            // label_Flat
            // 
            this.label_Flat.AutoSize = true;
            this.label_Flat.Location = new System.Drawing.Point(137, 210);
            this.label_Flat.Name = "label_Flat";
            this.label_Flat.Size = new System.Drawing.Size(27, 13);
            this.label_Flat.TabIndex = 10;
            this.label_Flat.Text = "Flat:";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(137, 254);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(41, 13);
            this.label_Phone.TabIndex = 11;
            this.label_Phone.Text = "Phone:";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(191, 52);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(194, 20);
            this.tb_ID.TabIndex = 12;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(137, 59);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(21, 13);
            this.label_ID.TabIndex = 13;
            this.label_ID.Text = "ID:";
            this.label_ID.Visible = false;
            // 
            // Form_Abonent_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 374);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.label_Flat);
            this.Controls.Add(this.label_Street);
            this.Controls.Add(this.label_House);
            this.Controls.Add(this.label_Fio);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.tb_House);
            this.Controls.Add(this.tb_Flat);
            this.Controls.Add(this.tb_Street);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Fio);
            this.Name = "Form_Abonent_Edit";
            this.Text = "Form_Abonent_Edit";
            this.Load += new System.EventHandler(this.Form_Abonent_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Fio;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox tb_Street;
        private System.Windows.Forms.TextBox tb_Flat;
        private System.Windows.Forms.TextBox tb_House;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label label_Fio;
        private System.Windows.Forms.Label label_House;
        private System.Windows.Forms.Label label_Street;
        private System.Windows.Forms.Label label_Flat;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label_ID;
    }
}