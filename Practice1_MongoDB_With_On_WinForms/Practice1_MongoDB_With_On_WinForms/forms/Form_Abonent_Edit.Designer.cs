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
            this.SuspendLayout();
            // 
            // tb_Fio
            // 
            this.tb_Fio.Location = new System.Drawing.Point(166, 151);
            this.tb_Fio.Name = "tb_Fio";
            this.tb_Fio.Size = new System.Drawing.Size(194, 20);
            this.tb_Fio.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(126, 322);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 35);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Save changes";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(483, 322);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(94, 35);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tb_Street
            // 
            this.tb_Street.Location = new System.Drawing.Point(166, 203);
            this.tb_Street.Name = "tb_Street";
            this.tb_Street.Size = new System.Drawing.Size(194, 20);
            this.tb_Street.TabIndex = 3;
            // 
            // tb_Flat
            // 
            this.tb_Flat.Location = new System.Drawing.Point(166, 246);
            this.tb_Flat.Name = "tb_Flat";
            this.tb_Flat.Size = new System.Drawing.Size(194, 20);
            this.tb_Flat.TabIndex = 4;
            // 
            // tb_House
            // 
            this.tb_House.Location = new System.Drawing.Point(453, 151);
            this.tb_House.Name = "tb_House";
            this.tb_House.Size = new System.Drawing.Size(100, 20);
            this.tb_House.TabIndex = 5;
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(453, 203);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(194, 20);
            this.tb_Phone.TabIndex = 6;
            // 
            // Form_Abonent_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.tb_House);
            this.Controls.Add(this.tb_Flat);
            this.Controls.Add(this.tb_Street);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Fio);
            this.Name = "Form_Abonent_Edit";
            this.Text = "Form_Abonent_Edit";
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
    }
}