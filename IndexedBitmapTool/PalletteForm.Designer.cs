﻿namespace IndexedBitmapTool {
    partial class PalletteForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.palletteListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // palletteListBox
            // 
            this.palletteListBox.FormattingEnabled = true;
            this.palletteListBox.Location = new System.Drawing.Point(12, 12);
            this.palletteListBox.Name = "palletteListBox";
            this.palletteListBox.Size = new System.Drawing.Size(332, 186);
            this.palletteListBox.TabIndex = 6;
            // 
            // PalletteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.palletteListBox);
            this.Name = "PalletteForm";
            this.Text = "PalletteForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox palletteListBox;
    }
}