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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Form_Abonent
            // 
            this.btn_Form_Abonent.BackColor = System.Drawing.Color.Cyan;
            this.btn_Form_Abonent.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Form_Abonent.Location = new System.Drawing.Point(52, 130);
            this.btn_Form_Abonent.Name = "btn_Form_Abonent";
            this.btn_Form_Abonent.Size = new System.Drawing.Size(169, 94);
            this.btn_Form_Abonent.TabIndex = 0;
            this.btn_Form_Abonent.Text = "Abonents";
            this.btn_Form_Abonent.UseVisualStyleBackColor = false;
            this.btn_Form_Abonent.Click += new System.EventHandler(this.btn_Form_Abonent_Click);
            // 
            // btn_Form_Disrepair
            // 
            this.btn_Form_Disrepair.BackColor = System.Drawing.Color.Cyan;
            this.btn_Form_Disrepair.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Form_Disrepair.Location = new System.Drawing.Point(552, 130);
            this.btn_Form_Disrepair.Name = "btn_Form_Disrepair";
            this.btn_Form_Disrepair.Size = new System.Drawing.Size(169, 94);
            this.btn_Form_Disrepair.TabIndex = 1;
            this.btn_Form_Disrepair.Text = "Disrepairs";
            this.btn_Form_Disrepair.UseVisualStyleBackColor = false;
            this.btn_Form_Disrepair.Click += new System.EventHandler(this.btn_Form_Disrepair_Click);
            // 
            // btn_Form_Request
            // 
            this.btn_Form_Request.BackColor = System.Drawing.Color.Cyan;
            this.btn_Form_Request.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Form_Request.Location = new System.Drawing.Point(302, 130);
            this.btn_Form_Request.Name = "btn_Form_Request";
            this.btn_Form_Request.Size = new System.Drawing.Size(169, 94);
            this.btn_Form_Request.TabIndex = 2;
            this.btn_Form_Request.Text = "Requestes";
            this.btn_Form_Request.UseVisualStyleBackColor = false;
            this.btn_Form_Request.Click += new System.EventHandler(this.btn_Form_Request_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(801, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Form_Request);
            this.Controls.Add(this.btn_Form_Disrepair);
            this.Controls.Add(this.btn_Form_Abonent);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Form_Abonent;
        private System.Windows.Forms.Button btn_Form_Disrepair;
        private System.Windows.Forms.Button btn_Form_Request;
        private System.Windows.Forms.Label label1;
    }
}