﻿namespace DailyDev.CodeWiki.Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchBox = new System.Windows.Forms.TextBox();
            this.matchedItems = new System.Windows.Forms.ListView();
            this.selectedItem = new System.Windows.Forms.RichTextBox();
            this.searchProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(12, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(1247, 27);
            this.searchBox.TabIndex = 0;
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDownEventHandler);
            // 
            // matchedItems
            // 
            this.matchedItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchedItems.Location = new System.Drawing.Point(12, 81);
            this.matchedItems.Name = "matchedItems";
            this.matchedItems.Size = new System.Drawing.Size(1247, 223);
            this.matchedItems.TabIndex = 1;
            this.matchedItems.UseCompatibleStateImageBehavior = false;
            this.matchedItems.View = System.Windows.Forms.View.List;
            this.matchedItems.SelectedIndexChanged += new System.EventHandler(this.matched_Item_ClickedAsync);
            // 
            // selectedItem
            // 
            this.selectedItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedItem.Location = new System.Drawing.Point(12, 348);
            this.selectedItem.Name = "selectedItem";
            this.selectedItem.Size = new System.Drawing.Size(1247, 499);
            this.selectedItem.TabIndex = 2;
            this.selectedItem.Text = "";
            // 
            // searchProgress
            // 
            this.searchProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchProgress.Location = new System.Drawing.Point(12, 312);
            this.searchProgress.Name = "searchProgress";
            this.searchProgress.Size = new System.Drawing.Size(1247, 29);
            this.searchProgress.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 859);
            this.Controls.Add(this.searchProgress);
            this.Controls.Add(this.selectedItem);
            this.Controls.Add(this.matchedItems);
            this.Controls.Add(this.searchBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox searchBox;
        private ListView matchedItems;
        private RichTextBox selectedItem;
        private ProgressBar searchProgress;
    }
}