namespace Customer_Maintenance
{
    partial class JobDetails
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblJobDetail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbCarNo = new System.Windows.Forms.TextBox();
            this.txtbWorkerID = new System.Windows.Forms.TextBox();
            this.lblWorkerID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lblJobDetail
            // 
            this.lblJobDetail.AutoSize = true;
            this.lblJobDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblJobDetail.Location = new System.Drawing.Point(89, 144);
            this.lblJobDetail.Name = "lblJobDetail";
            this.lblJobDetail.Size = new System.Drawing.Size(61, 17);
            this.lblJobDetail.TabIndex = 1;
            this.lblJobDetail.Text = "JobDate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(89, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "CarNo";
            // 
            // txtbCarNo
            // 
            this.txtbCarNo.Location = new System.Drawing.Point(176, 65);
            this.txtbCarNo.Name = "txtbCarNo";
            this.txtbCarNo.Size = new System.Drawing.Size(200, 20);
            this.txtbCarNo.TabIndex = 3;
            this.txtbCarNo.Leave += new System.EventHandler(this.txtbCarNo_Leave);
            // 
            // txtbWorkerID
            // 
            this.txtbWorkerID.Location = new System.Drawing.Point(176, 100);
            this.txtbWorkerID.Name = "txtbWorkerID";
            this.txtbWorkerID.Size = new System.Drawing.Size(200, 20);
            this.txtbWorkerID.TabIndex = 4;
            // 
            // lblWorkerID
            // 
            this.lblWorkerID.AutoSize = true;
            this.lblWorkerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblWorkerID.Location = new System.Drawing.Point(89, 103);
            this.lblWorkerID.Name = "lblWorkerID";
            this.lblWorkerID.Size = new System.Drawing.Size(67, 17);
            this.lblWorkerID.TabIndex = 5;
            this.lblWorkerID.Text = "WorkerID";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(69, 292);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(243, 292);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // JobDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 374);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblWorkerID);
            this.Controls.Add(this.txtbWorkerID);
            this.Controls.Add(this.txtbCarNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJobDetail);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "JobDetails";
            this.Text = "JobDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblJobDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbCarNo;
        private System.Windows.Forms.TextBox txtbWorkerID;
        private System.Windows.Forms.Label lblWorkerID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
    }
}