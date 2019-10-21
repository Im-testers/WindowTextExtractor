﻿namespace WindowTextExtractor.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnTarget = new System.Windows.Forms.ToolStripButton();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblTotalLines = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparatorLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalChars = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparatorRight = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTarget});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(734, 25);
            this.toolStrip.TabIndex = 0;
            // 
            // btnTarget
            // 
            this.btnTarget.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTarget.Image = ((System.Drawing.Image)(resources.GetObject("btnTarget.Image")));
            this.btnTarget.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(23, 22);
            this.btnTarget.Text = "Find Text";
            this.btnTarget.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTarget_MouseDown);
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(0, 25);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(734, 487);
            this.txtContent.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotalLines,
            this.toolStripSeparatorLeft,
            this.lblTotalChars,
            this.toolStripSeparatorRight});
            this.statusStrip.Location = new System.Drawing.Point(0, 490);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(734, 22);
            this.statusStrip.TabIndex = 2;
            // 
            // lblTotalLines
            // 
            this.lblTotalLines.Name = "lblTotalLines";
            this.lblTotalLines.Size = new System.Drawing.Size(67, 17);
            this.lblTotalLines.Text = "Total Lines:";
            // 
            // toolStripSeparatorLeft
            // 
            this.toolStripSeparatorLeft.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripSeparatorLeft.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripSeparatorLeft.Name = "toolStripSeparatorLeft";
            this.toolStripSeparatorLeft.Size = new System.Drawing.Size(4, 17);
            // 
            // lblTotalChars
            // 
            this.lblTotalChars.Name = "lblTotalChars";
            this.lblTotalChars.Size = new System.Drawing.Size(70, 17);
            this.lblTotalChars.Text = "Total Chars:";
            // 
            // toolStripSeparatorRight
            // 
            this.toolStripSeparatorRight.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripSeparatorRight.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripSeparatorRight.Name = "toolStripSeparatorRight";
            this.toolStripSeparatorRight.Size = new System.Drawing.Size(4, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 512);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.toolStrip);
            this.Name = "MainForm";
            this.Text = "Window Text Extractor";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnTarget;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalLines;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSeparatorLeft;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalChars;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSeparatorRight;
    }
}

