namespace Practice1_MongoDB_With_On_WinForms.forms
{
    partial class Form_Request_Edit
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label_ID = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label_Executor = new System.Windows.Forms.Label();
            this.label_Account = new System.Windows.Forms.Label();
            this.tb_Executor = new System.Windows.Forms.TextBox();
            this.tb_Account = new System.Windows.Forms.TextBox();
            this.label_Failure = new System.Windows.Forms.Label();
            this.tb_Failure = new System.Windows.Forms.TextBox();
            this.dtp_IncomingDate = new System.Windows.Forms.DateTimePicker();
            this.label_ExecutionDate = new System.Windows.Forms.Label();
            this.label_IncomingDate = new System.Windows.Forms.Label();
            this.dtp_ExecutionDate = new System.Windows.Forms.DateTimePicker();
            this.cb_isExecuted = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(517, 313);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(94, 35);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(74, 313);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 35);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save changes";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(167, 35);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(21, 13);
            this.label_ID.TabIndex = 15;
            this.label_ID.Text = "ID:";
            this.label_ID.Visible = false;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(251, 28);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(200, 20);
            this.tb_ID.TabIndex = 14;
            // 
            // label_Executor
            // 
            this.label_Executor.AutoSize = true;
            this.label_Executor.Location = new System.Drawing.Point(167, 117);
            this.label_Executor.Name = "label_Executor";
            this.label_Executor.Size = new System.Drawing.Size(52, 13);
            this.label_Executor.TabIndex = 19;
            this.label_Executor.Text = "Executor:";
            // 
            // label_Account
            // 
            this.label_Account.AutoSize = true;
            this.label_Account.Location = new System.Drawing.Point(167, 73);
            this.label_Account.Name = "label_Account";
            this.label_Account.Size = new System.Drawing.Size(50, 13);
            this.label_Account.TabIndex = 18;
            this.label_Account.Text = "Account:";
            // 
            // tb_Executor
            // 
            this.tb_Executor.Location = new System.Drawing.Point(251, 110);
            this.tb_Executor.Name = "tb_Executor";
            this.tb_Executor.Size = new System.Drawing.Size(200, 20);
            this.tb_Executor.TabIndex = 17;
            // 
            // tb_Account
            // 
            this.tb_Account.Location = new System.Drawing.Point(251, 70);
            this.tb_Account.Name = "tb_Account";
            this.tb_Account.Size = new System.Drawing.Size(200, 20);
            this.tb_Account.TabIndex = 16;
            // 
            // label_Failure
            // 
            this.label_Failure.AutoSize = true;
            this.label_Failure.Location = new System.Drawing.Point(167, 156);
            this.label_Failure.Name = "label_Failure";
            this.label_Failure.Size = new System.Drawing.Size(41, 13);
            this.label_Failure.TabIndex = 21;
            this.label_Failure.Text = "Failure:";
            // 
            // tb_Failure
            // 
            this.tb_Failure.Location = new System.Drawing.Point(251, 149);
            this.tb_Failure.Name = "tb_Failure";
            this.tb_Failure.Size = new System.Drawing.Size(200, 20);
            this.tb_Failure.TabIndex = 20;
            // 
            // dtp_IncomingDate
            // 
            this.dtp_IncomingDate.Location = new System.Drawing.Point(251, 190);
            this.dtp_IncomingDate.Name = "dtp_IncomingDate";
            this.dtp_IncomingDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_IncomingDate.TabIndex = 22;
            // 
            // label_ExecutionDate
            // 
            this.label_ExecutionDate.AutoSize = true;
            this.label_ExecutionDate.Location = new System.Drawing.Point(167, 235);
            this.label_ExecutionDate.Name = "label_ExecutionDate";
            this.label_ExecutionDate.Size = new System.Drawing.Size(80, 13);
            this.label_ExecutionDate.TabIndex = 24;
            this.label_ExecutionDate.Text = "ExecutionDate:";
            // 
            // label_IncomingDate
            // 
            this.label_IncomingDate.AutoSize = true;
            this.label_IncomingDate.Location = new System.Drawing.Point(167, 196);
            this.label_IncomingDate.Name = "label_IncomingDate";
            this.label_IncomingDate.Size = new System.Drawing.Size(79, 13);
            this.label_IncomingDate.TabIndex = 23;
            this.label_IncomingDate.Text = "Incoming Date:";
            // 
            // dtp_ExecutionDate
            // 
            this.dtp_ExecutionDate.Location = new System.Drawing.Point(251, 235);
            this.dtp_ExecutionDate.Name = "dtp_ExecutionDate";
            this.dtp_ExecutionDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_ExecutionDate.TabIndex = 25;
            // 
            // cb_isExecuted
            // 
            this.cb_isExecuted.AutoSize = true;
            this.cb_isExecuted.Location = new System.Drawing.Point(251, 274);
            this.cb_isExecuted.Name = "cb_isExecuted";
            this.cb_isExecuted.Size = new System.Drawing.Size(86, 17);
            this.cb_isExecuted.TabIndex = 26;
            this.cb_isExecuted.Text = "is executed?";
            this.cb_isExecuted.UseVisualStyleBackColor = true;
            // 
            // Form_Request_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 389);
            this.Controls.Add(this.cb_isExecuted);
            this.Controls.Add(this.dtp_ExecutionDate);
            this.Controls.Add(this.label_ExecutionDate);
            this.Controls.Add(this.label_IncomingDate);
            this.Controls.Add(this.dtp_IncomingDate);
            this.Controls.Add(this.label_Failure);
            this.Controls.Add(this.tb_Failure);
            this.Controls.Add(this.label_Executor);
            this.Controls.Add(this.label_Account);
            this.Controls.Add(this.tb_Executor);
            this.Controls.Add(this.tb_Account);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Name = "Form_Request_Edit";
            this.Text = "Form_Request_Edit";
            this.Load += new System.EventHandler(this.Form_Request_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label_Executor;
        private System.Windows.Forms.Label label_Account;
        private System.Windows.Forms.TextBox tb_Executor;
        private System.Windows.Forms.TextBox tb_Account;
        private System.Windows.Forms.Label label_Failure;
        private System.Windows.Forms.TextBox tb_Failure;
        private System.Windows.Forms.DateTimePicker dtp_IncomingDate;
        private System.Windows.Forms.Label label_ExecutionDate;
        private System.Windows.Forms.Label label_IncomingDate;
        private System.Windows.Forms.DateTimePicker dtp_ExecutionDate;
        private System.Windows.Forms.CheckBox cb_isExecuted;
    }
}