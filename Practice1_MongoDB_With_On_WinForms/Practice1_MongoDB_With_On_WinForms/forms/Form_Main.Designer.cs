namespace Practice1_MongoDB_With_On_WinForms.forms
{
    partial class Form_Main
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
            this.btn_Form_Abonent = new System.Windows.Forms.Button();
            this.btn_Form_Disrepair = new System.Windows.Forms.Button();
            this.btn_Form_Request = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Form_Abonent
            // 
            this.btn_Form_Abonent.Location = new System.Drawing.Point(218, 119);
            this.btn_Form_Abonent.Name = "btn_Form_Abonent";
            this.btn_Form_Abonent.Size = new System.Drawing.Size(120, 45);
            this.btn_Form_Abonent.TabIndex = 0;
            this.btn_Form_Abonent.Text = "btn_Form_Abonent";
            this.btn_Form_Abonent.UseVisualStyleBackColor = true;
            this.btn_Form_Abonent.Click += new System.EventHandler(this.btn_Form_Abonent_Click);
            // 
            // btn_Form_Disrepair
            // 
            this.btn_Form_Disrepair.Location = new System.Drawing.Point(439, 119);
            this.btn_Form_Disrepair.Name = "btn_Form_Disrepair";
            this.btn_Form_Disrepair.Size = new System.Drawing.Size(120, 45);
            this.btn_Form_Disrepair.TabIndex = 1;
            this.btn_Form_Disrepair.Text = "btn_Form_Disrepair";
            this.btn_Form_Disrepair.UseVisualStyleBackColor = true;
            this.btn_Form_Disrepair.Click += new System.EventHandler(this.btn_Form_Disrepair_Click);
            // 
            // btn_Form_Request
            // 
            this.btn_Form_Request.Location = new System.Drawing.Point(335, 231);
            this.btn_Form_Request.Name = "btn_Form_Request";
            this.btn_Form_Request.Size = new System.Drawing.Size(120, 45);
            this.btn_Form_Request.TabIndex = 2;
            this.btn_Form_Request.Text = "btn_Form_Request";
            this.btn_Form_Request.UseVisualStyleBackColor = true;
            this.btn_Form_Request.Click += new System.EventHandler(this.btn_Form_Request_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Form_Request);
            this.Controls.Add(this.btn_Form_Disrepair);
            this.Controls.Add(this.btn_Form_Abonent);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Form_Abonent;
        private System.Windows.Forms.Button btn_Form_Disrepair;
        private System.Windows.Forms.Button btn_Form_Request;
    }
}