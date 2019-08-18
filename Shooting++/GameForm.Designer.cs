﻿namespace Shooting__
{
    partial class GameForm
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
            this.OSGPanel = new System.Windows.Forms.Panel();
            this.codeText = new System.Windows.Forms.RichTextBox();
            this.title = new System.Windows.Forms.Label();
            this.missionNote = new System.Windows.Forms.Label();
            this.back = new Shooting__.ClickableLabel();
            this.save = new Shooting__.ClickableLabel();
            this.run = new Shooting__.ClickableLabel();
            this.renderAreaa = new System.Windows.Forms.PictureBox();
            this.OSGPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.renderAreaa)).BeginInit();
            this.SuspendLayout();
            // 
            // OSGPanel
            // 
            this.OSGPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OSGPanel.Controls.Add(this.renderAreaa);
            this.OSGPanel.Location = new System.Drawing.Point(600, 150);
            this.OSGPanel.Name = "OSGPanel";
            this.OSGPanel.Size = new System.Drawing.Size(800, 600);
            this.OSGPanel.TabIndex = 0;
            // 
            // codeText
            // 
            this.codeText.DetectUrls = false;
            this.codeText.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.codeText.Location = new System.Drawing.Point(40, 150);
            this.codeText.Name = "codeText";
            this.codeText.Size = new System.Drawing.Size(520, 600);
            this.codeText.TabIndex = 1;
            this.codeText.Text = "";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(600, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(249, 35);
            this.title.TabIndex = 2;
            this.title.Text = "Mission Name:";
            // 
            // missionNote
            // 
            this.missionNote.AutoSize = true;
            this.missionNote.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missionNote.Location = new System.Drawing.Point(40, 50);
            this.missionNote.MaximumSize = new System.Drawing.Size(1360, 90);
            this.missionNote.Name = "missionNote";
            this.missionNote.Size = new System.Drawing.Size(142, 21);
            this.missionNote.TabIndex = 3;
            this.missionNote.Text = "Mission Note: ";
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(1307, 817);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(105, 35);
            this.back.TabIndex = 7;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // save
            // 
            this.save.AutoSize = true;
            this.save.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(483, 753);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(77, 26);
            this.save.TabIndex = 6;
            this.save.Text = "Save";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // run
            // 
            this.run.AutoSize = true;
            this.run.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run.Location = new System.Drawing.Point(260, 775);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(84, 39);
            this.run.TabIndex = 5;
            this.run.Text = "Run";
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // renderAreaa
            // 
            this.renderAreaa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderAreaa.Location = new System.Drawing.Point(0, 0);
            this.renderAreaa.Name = "renderAreaa";
            this.renderAreaa.Size = new System.Drawing.Size(800, 600);
            this.renderAreaa.TabIndex = 0;
            this.renderAreaa.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.ControlBox = false;
            this.Controls.Add(this.back);
            this.Controls.Add(this.save);
            this.Controls.Add(this.run);
            this.Controls.Add(this.missionNote);
            this.Controls.Add(this.title);
            this.Controls.Add(this.codeText);
            this.Controls.Add(this.OSGPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.OSGPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.renderAreaa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel OSGPanel;
        private System.Windows.Forms.RichTextBox codeText;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label missionNote;
        private ClickableLabel run;
        private ClickableLabel save;
        private ClickableLabel back;
        private System.Windows.Forms.PictureBox renderAreaa;
    }
}