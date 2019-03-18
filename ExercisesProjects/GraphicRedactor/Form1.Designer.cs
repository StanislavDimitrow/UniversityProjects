namespace GraphicRedactor
{
    partial class formMain
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
            this.frmPanel = new System.Windows.Forms.Panel();
            this.frmPicture = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnStickman = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelBackColor = new System.Windows.Forms.Panel();
            this.panelConturColor = new System.Windows.Forms.Panel();
            this.tracker1 = new System.Windows.Forms.TrackBar();
            this.btnText = new System.Windows.Forms.Button();
            this.btnFreeHandTool = new System.Windows.Forms.Button();
            this.btnTextFont = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnErase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.frmPicture)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracker1)).BeginInit();
            this.SuspendLayout();
            // 
            // frmPanel
            // 
            this.frmPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.frmPanel.Location = new System.Drawing.Point(255, 0);
            this.frmPanel.Name = "frmPanel";
            this.frmPanel.Size = new System.Drawing.Size(448, 435);
            this.frmPanel.TabIndex = 0;
            this.frmPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPanel_MouseDown);
            this.frmPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPanel_MouseMove);
            this.frmPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmPanel_MouseUp);
            // 
            // frmPicture
            // 
            this.frmPicture.Location = new System.Drawing.Point(0, 3);
            this.frmPicture.Name = "frmPicture";
            this.frmPicture.Size = new System.Drawing.Size(254, 433);
            this.frmPicture.TabIndex = 1;
            this.frmPicture.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(701, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(4, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(4, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(4, 17);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(36, 12);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(70, 57);
            this.btnEllipse.TabIndex = 3;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(139, 12);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(75, 53);
            this.btnRectangle.TabIndex = 4;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(36, 75);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(70, 55);
            this.btnLine.TabIndex = 5;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnStickman
            // 
            this.btnStickman.Location = new System.Drawing.Point(139, 75);
            this.btnStickman.Name = "btnStickman";
            this.btnStickman.Size = new System.Drawing.Size(75, 55);
            this.btnStickman.TabIndex = 6;
            this.btnStickman.Text = "Stickman";
            this.btnStickman.UseVisualStyleBackColor = true;
            this.btnStickman.Click += new System.EventHandler(this.btnStickman_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(98, 366);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelBackColor
            // 
            this.panelBackColor.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelBackColor.Location = new System.Drawing.Point(76, 218);
            this.panelBackColor.Name = "panelBackColor";
            this.panelBackColor.Size = new System.Drawing.Size(69, 65);
            this.panelBackColor.TabIndex = 0;
            this.panelBackColor.DoubleClick += new System.EventHandler(this.panelBackColor_DoubleClick);
            // 
            // panelConturColor
            // 
            this.panelConturColor.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelConturColor.Location = new System.Drawing.Point(108, 228);
            this.panelConturColor.Name = "panelConturColor";
            this.panelConturColor.Size = new System.Drawing.Size(92, 77);
            this.panelConturColor.TabIndex = 0;
            this.panelConturColor.DoubleClick += new System.EventHandler(this.panelConturColor_DoubleClick);
            // 
            // tracker1
            // 
            this.tracker1.Location = new System.Drawing.Point(68, 321);
            this.tracker1.Name = "tracker1";
            this.tracker1.Size = new System.Drawing.Size(132, 45);
            this.tracker1.TabIndex = 10;
            this.tracker1.Scroll += new System.EventHandler(this.tracker1_Scroll);
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(36, 136);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(70, 41);
            this.btnText.TabIndex = 11;
            this.btnText.Text = "Text";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            this.btnText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnText_KeyPress);
            // 
            // btnFreeHandTool
            // 
            this.btnFreeHandTool.Location = new System.Drawing.Point(139, 136);
            this.btnFreeHandTool.Name = "btnFreeHandTool";
            this.btnFreeHandTool.Size = new System.Drawing.Size(75, 41);
            this.btnFreeHandTool.TabIndex = 0;
            this.btnFreeHandTool.Text = "FreeHand Tool";
            this.btnFreeHandTool.UseVisualStyleBackColor = true;
            this.btnFreeHandTool.Click += new System.EventHandler(this.btnFreeHandTool_Click);
            // 
            // btnTextFont
            // 
            this.btnTextFont.Location = new System.Drawing.Point(22, 372);
            this.btnTextFont.Name = "btnTextFont";
            this.btnTextFont.Size = new System.Drawing.Size(70, 30);
            this.btnTextFont.TabIndex = 0;
            this.btnTextFont.Text = "Text font";
            this.btnTextFont.UseVisualStyleBackColor = true;
            this.btnTextFont.Click += new System.EventHandler(this.btnTextFont_Click);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(179, 372);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(70, 23);
            this.btnErase.TabIndex = 0;
            this.btnErase.Text = "Eraser";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(701, 433);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnTextFont);
            this.Controls.Add(this.btnFreeHandTool);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.tracker1);
            this.Controls.Add(this.panelBackColor);
            this.Controls.Add(this.panelConturColor);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStickman);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnEllipse);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.frmPicture);
            this.Controls.Add(this.frmPanel);
            this.Name = "formMain";
            this.Text = "Графичен редактор";
            ((System.ComponentModel.ISupportInitialize)(this.frmPicture)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracker1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel frmPanel;
        private System.Windows.Forms.PictureBox frmPicture;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnStickman;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panelBackColor;
        private System.Windows.Forms.Panel panelConturColor;
        private System.Windows.Forms.TrackBar tracker1;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnFreeHandTool;
        private System.Windows.Forms.Button btnTextFont;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnErase;
    }
}

