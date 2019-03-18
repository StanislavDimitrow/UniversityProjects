namespace KZ_hill_row
{
    partial class Form1
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
            this.btnCrypt = new System.Windows.Forms.Button();
            this.lPlaintext = new System.Windows.Forms.Label();
            this.lKey = new System.Windows.Forms.Label();
            this.tbPlaintext = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.lMsgResultHill = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Label();
            this.lResult = new System.Windows.Forms.Label();
            this.lHillRowtransp = new System.Windows.Forms.Label();
            this.lResult2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrypt
            // 
            this.btnCrypt.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCrypt.Location = new System.Drawing.Point(34, 220);
            this.btnCrypt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(188, 39);
            this.btnCrypt.TabIndex = 0;
            this.btnCrypt.Text = "Crypt";
            this.btnCrypt.UseVisualStyleBackColor = true;
            this.btnCrypt.Click += new System.EventHandler(this.btnCrypt_Click);
            // 
            // lPlaintext
            // 
            this.lPlaintext.AutoSize = true;
            this.lPlaintext.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.lPlaintext.Location = new System.Drawing.Point(30, 27);
            this.lPlaintext.Name = "lPlaintext";
            this.lPlaintext.Size = new System.Drawing.Size(92, 24);
            this.lPlaintext.TabIndex = 1;
            this.lPlaintext.Text = "Plaintext";
            // 
            // lKey
            // 
            this.lKey.AutoSize = true;
            this.lKey.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.lKey.Location = new System.Drawing.Point(30, 66);
            this.lKey.Name = "lKey";
            this.lKey.Size = new System.Drawing.Size(93, 24);
            this.lKey.TabIndex = 2;
            this.lKey.Text = "Keyword";
            // 
            // tbPlaintext
            // 
            this.tbPlaintext.Location = new System.Drawing.Point(145, 27);
            this.tbPlaintext.Multiline = true;
            this.tbPlaintext.Name = "tbPlaintext";
            this.tbPlaintext.Size = new System.Drawing.Size(281, 24);
            this.tbPlaintext.TabIndex = 3;
            this.tbPlaintext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPlaintext_KeyPress);
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(145, 67);
            this.tbKey.Multiline = true;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(281, 24);
            this.tbKey.TabIndex = 4;
            this.tbKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKey_KeyPress);
            // 
            // lMsgResultHill
            // 
            this.lMsgResultHill.AutoSize = true;
            this.lMsgResultHill.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.lMsgResultHill.Location = new System.Drawing.Point(30, 120);
            this.lMsgResultHill.Name = "lMsgResultHill";
            this.lMsgResultHill.Size = new System.Drawing.Size(170, 24);
            this.lMsgResultHill.TabIndex = 5;
            this.lMsgResultHill.Text = "Hill Ciphertext : ";
            this.lMsgResultHill.Visible = false;
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(151, 124);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(0, 21);
            this.res.TabIndex = 6;
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(234, 124);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(46, 21);
            this.lResult.TabIndex = 7;
            this.lResult.Text = "error";
            this.lResult.Visible = false;
            // 
            // lHillRowtransp
            // 
            this.lHillRowtransp.AutoSize = true;
            this.lHillRowtransp.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.lHillRowtransp.Location = new System.Drawing.Point(30, 175);
            this.lHillRowtransp.Name = "lHillRowtransp";
            this.lHillRowtransp.Size = new System.Drawing.Size(209, 24);
            this.lHillRowtransp.TabIndex = 8;
            this.lHillRowtransp.Text = "Hll + Row Transp. : ";
            this.lHillRowtransp.Visible = false;
            // 
            // lResult2
            // 
            this.lResult2.AutoSize = true;
            this.lResult2.Location = new System.Drawing.Point(234, 179);
            this.lResult2.Name = "lResult2";
            this.lResult2.Size = new System.Drawing.Size(46, 21);
            this.lResult2.TabIndex = 9;
            this.lResult2.Text = "error";
            this.lResult2.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(270, 220);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(188, 39);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 273);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lResult2);
            this.Controls.Add(this.lHillRowtransp);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.res);
            this.Controls.Add(this.lMsgResultHill);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.tbPlaintext);
            this.Controls.Add(this.lKey);
            this.Controls.Add(this.lPlaintext);
            this.Controls.Add(this.btnCrypt);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Hill and Row Transponition Cyphers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrypt;
        private System.Windows.Forms.Label lPlaintext;
        private System.Windows.Forms.Label lKey;
        private System.Windows.Forms.TextBox tbPlaintext;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label lMsgResultHill;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label lHillRowtransp;
        private System.Windows.Forms.Label lResult2;
        private System.Windows.Forms.Button btnClear;
    }
}
