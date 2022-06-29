namespace Practice1_MongoDB_With_On_WinForms.forms
{
    partial class Form_Disrepair_Edit
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
            this.label_ID = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label_Failernm = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Failernm = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(80, 86);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(21, 13);
            this.label_ID.TabIndex = 27;
            this.label_ID.Text = "ID:";
            this.label_ID.Visible = false;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(158, 79);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(194, 20);
            this.tb_ID.TabIndex = 26;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ID_KeyPress);
            this.tb_ID.Validating += new System.ComponentModel.CancelEventHandler(this.tb_ID_Validating);
            // 
            // label_Failernm
            // 
            this.label_Failernm.AutoSize = true;
            this.label_Failernm.Location = new System.Drawing.Point(80, 117);
            this.label_Failernm.Name = "label_Failernm";
            this.label_Failernm.Size = new System.Drawing.Size(72, 13);
            this.label_Failernm.TabIndex = 21;
            this.label_Failernm.Text = "FAILURENM:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(406, 202);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(94, 35);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(79, 202);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 35);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Save changes";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Failernm
            // 
            this.tb_Failernm.Location = new System.Drawing.Point(158, 114);
            this.tb_Failernm.Name = "tb_Failernm";
            this.tb_Failernm.Size = new System.Drawing.Size(194, 20);
            this.tb_Failernm.TabIndex = 14;
            this.tb_Failernm.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Failernm_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form_Disrepair_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(597, 271);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label_Failernm);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Failernm);
            this.Name = "Form_Disrepair_Edit";
            this.Text = "Form_Disrepair_Edit";
            this.Load += new System.EventHandler(this.Form_Disrepair_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label_Failernm;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Failernm;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}