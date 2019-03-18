namespace CourseWorkSequenceDiagram
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.btnTextFont = new System.Windows.Forms.Button();
            this.btnDashLine = new System.Windows.Forms.Button();
            this.btnNewRect = new System.Windows.Forms.Button();
            this.btnArc = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.tracker1 = new System.Windows.Forms.TrackBar();
            this.btnActor = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.btnFreehand = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.objectMove = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.newToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.saveAsToolStripMenuItem.Text = "Save As..";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.GhostWhite;
            this.panel.Controls.Add(this.objectMove);
            this.panel.Controls.Add(this.btnTextFont);
            this.panel.Controls.Add(this.btnDashLine);
            this.panel.Controls.Add(this.btnNewRect);
            this.panel.Controls.Add(this.btnArc);
            this.panel.Controls.Add(this.btnRectangle);
            this.panel.Controls.Add(this.btnLine);
            this.panel.Controls.Add(this.tracker1);
            this.panel.Controls.Add(this.btnActor);
            this.panel.Controls.Add(this.btnText);
            this.panel.Controls.Add(this.btnFreehand);
            this.panel.Location = new System.Drawing.Point(0, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(247, 469);
            this.panel.TabIndex = 1;
            // 
            // btnTextFont
            // 
            this.btnTextFont.Location = new System.Drawing.Point(134, 339);
            this.btnTextFont.Name = "btnTextFont";
            this.btnTextFont.Size = new System.Drawing.Size(75, 23);
            this.btnTextFont.TabIndex = 10;
            this.btnTextFont.Text = "TextFont";
            this.btnTextFont.UseVisualStyleBackColor = true;
            this.btnTextFont.Click += new System.EventHandler(this.btnTextFont_Click);
            // 
            // btnDashLine
            // 
            this.btnDashLine.Image = global::CourseWorkSequenceDiagram.Properties.Resources.dashLine;
            this.btnDashLine.Location = new System.Drawing.Point(26, 220);
            this.btnDashLine.Name = "btnDashLine";
            this.btnDashLine.Size = new System.Drawing.Size(75, 23);
            this.btnDashLine.TabIndex = 9;
            this.btnDashLine.UseVisualStyleBackColor = true;
            this.btnDashLine.Click += new System.EventHandler(this.btnDashLine_Click);
            // 
            // btnNewRect
            // 
            this.btnNewRect.Image = global::CourseWorkSequenceDiagram.Properties.Resources.new_rects;
            this.btnNewRect.Location = new System.Drawing.Point(165, 179);
            this.btnNewRect.Name = "btnNewRect";
            this.btnNewRect.Size = new System.Drawing.Size(44, 64);
            this.btnNewRect.TabIndex = 8;
            this.btnNewRect.UseVisualStyleBackColor = true;
            this.btnNewRect.Click += new System.EventHandler(this.btnNewRect_Click);
            // 
            // btnArc
            // 
            this.btnArc.Image = global::CourseWorkSequenceDiagram.Properties.Resources.line1;
            this.btnArc.Location = new System.Drawing.Point(133, 41);
            this.btnArc.Name = "btnArc";
            this.btnArc.Size = new System.Drawing.Size(76, 36);
            this.btnArc.TabIndex = 7;
            this.btnArc.UseVisualStyleBackColor = true;
            this.btnArc.Click += new System.EventHandler(this.btnArc_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Image = global::CourseWorkSequenceDiagram.Properties.Resources.rectangles;
            this.btnRectangle.Location = new System.Drawing.Point(133, 113);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(76, 37);
            this.btnRectangle.TabIndex = 6;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.Image = global::CourseWorkSequenceDiagram.Properties.Resources.line;
            this.btnLine.Location = new System.Drawing.Point(25, 179);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(76, 21);
            this.btnLine.TabIndex = 5;
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // tracker1
            // 
            this.tracker1.Location = new System.Drawing.Point(24, 339);
            this.tracker1.Name = "tracker1";
            this.tracker1.Size = new System.Drawing.Size(104, 45);
            this.tracker1.TabIndex = 4;
            this.tracker1.Scroll += new System.EventHandler(this.tracker1_Scroll);
            // 
            // btnActor
            // 
            this.btnActor.BackgroundImage = global::CourseWorkSequenceDiagram.Properties.Resources.ddddd;
            this.btnActor.Location = new System.Drawing.Point(24, 41);
            this.btnActor.Name = "btnActor";
            this.btnActor.Size = new System.Drawing.Size(62, 109);
            this.btnActor.TabIndex = 3;
            this.btnActor.UseVisualStyleBackColor = true;
            this.btnActor.Click += new System.EventHandler(this.btnActor_Click);
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(26, 275);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(75, 23);
            this.btnText.TabIndex = 1;
            this.btnText.Text = "Text";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            this.btnText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnText_KeyPress);
            // 
            // btnFreehand
            // 
            this.btnFreehand.Location = new System.Drawing.Point(134, 275);
            this.btnFreehand.Name = "btnFreehand";
            this.btnFreehand.Size = new System.Drawing.Size(75, 23);
            this.btnFreehand.TabIndex = 0;
            this.btnFreehand.Text = "Freehand";
            this.btnFreehand.UseVisualStyleBackColor = true;
            this.btnFreehand.Click += new System.EventHandler(this.btnFreehand_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.Location = new System.Drawing.Point(247, 27);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(571, 469);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // objectMove
            // 
            this.objectMove.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.objectMove.Location = new System.Drawing.Point(247, 0);
            this.objectMove.Name = "objectMove";
            this.objectMove.Size = new System.Drawing.Size(70, 38);
            this.objectMove.TabIndex = 3;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 497);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "SequenceDiagram";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnFreehand;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnActor;
        private System.Windows.Forms.TrackBar tracker1;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnArc;
        private System.Windows.Forms.Button btnNewRect;
        private System.Windows.Forms.Button btnDashLine;
        private System.Windows.Forms.Button btnTextFont;
        private System.Windows.Forms.Panel objectMove;
    }
}

