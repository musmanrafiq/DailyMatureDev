namespace DailyDev.CodeWiki.Desktop
{
    partial class CodeWikiDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputSnippet = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bothOption = new System.Windows.Forms.RadioButton();
            this.codeDirectoryOption = new System.Windows.Forms.RadioButton();
            this.snippetsOption = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(12, 172);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(1247, 27);
            this.searchBox.TabIndex = 3;
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDownEventHandler);
            // 
            // matchedItems
            // 
            this.matchedItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchedItems.Location = new System.Drawing.Point(12, 264);
            this.matchedItems.Name = "matchedItems";
            this.matchedItems.Size = new System.Drawing.Size(1247, 193);
            this.matchedItems.TabIndex = 7;
            this.matchedItems.UseCompatibleStateImageBehavior = false;
            this.matchedItems.View = System.Windows.Forms.View.List;
            this.matchedItems.SelectedIndexChanged += new System.EventHandler(this.matched_Item_ClickedAsync);
            // 
            // selectedItem
            // 
            this.selectedItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedItem.Location = new System.Drawing.Point(12, 485);
            this.selectedItem.Name = "selectedItem";
            this.selectedItem.Size = new System.Drawing.Size(1247, 539);
            this.selectedItem.TabIndex = 9;
            this.selectedItem.Text = "";
            // 
            // searchProgress
            // 
            this.searchProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchProgress.Location = new System.Drawing.Point(12, 463);
            this.searchProgress.Name = "searchProgress";
            this.searchProgress.Size = new System.Drawing.Size(1247, 16);
            this.searchProgress.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsMenuItem.Text = "Settings";
            // 
            // inputSnippet
            // 
            this.inputSnippet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSnippet.Location = new System.Drawing.Point(12, 46);
            this.inputSnippet.Name = "inputSnippet";
            this.inputSnippet.Size = new System.Drawing.Size(1247, 80);
            this.inputSnippet.TabIndex = 1;
            this.inputSnippet.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1165, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bothOption);
            this.groupBox1.Controls.Add(this.codeDirectoryOption);
            this.groupBox1.Controls.Add(this.snippetsOption);
            this.groupBox1.Location = new System.Drawing.Point(12, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1247, 51);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria";
            // 
            // bothOption
            // 
            this.bothOption.AutoSize = true;
            this.bothOption.Location = new System.Drawing.Point(1005, 21);
            this.bothOption.Name = "bothOption";
            this.bothOption.Size = new System.Drawing.Size(61, 24);
            this.bothOption.TabIndex = 6;
            this.bothOption.Text = "Both";
            this.bothOption.UseVisualStyleBackColor = true;
            // 
            // codeDirectoryOption
            // 
            this.codeDirectoryOption.AutoSize = true;
            this.codeDirectoryOption.Checked = true;
            this.codeDirectoryOption.Location = new System.Drawing.Point(658, 21);
            this.codeDirectoryOption.Name = "codeDirectoryOption";
            this.codeDirectoryOption.Size = new System.Drawing.Size(130, 24);
            this.codeDirectoryOption.TabIndex = 5;
            this.codeDirectoryOption.TabStop = true;
            this.codeDirectoryOption.Text = "Code Directory";
            this.codeDirectoryOption.UseVisualStyleBackColor = true;
            // 
            // snippetsOption
            // 
            this.snippetsOption.AutoSize = true;
            this.snippetsOption.Location = new System.Drawing.Point(296, 21);
            this.snippetsOption.Name = "snippetsOption";
            this.snippetsOption.Size = new System.Drawing.Size(87, 24);
            this.snippetsOption.TabIndex = 4;
            this.snippetsOption.Text = "Snippets";
            this.snippetsOption.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 1036);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputSnippet);
            this.Controls.Add(this.searchProgress);
            this.Controls.Add(this.selectedItem);
            this.Controls.Add(this.matchedItems);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox searchBox;
        private ListView matchedItems;
        private RichTextBox selectedItem;
        private ProgressBar searchProgress;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsMenuItem;
        private RichTextBox inputSnippet;
        private Button button1;
        private GroupBox groupBox1;
        private RadioButton bothOption;
        private RadioButton codeDirectoryOption;
        private RadioButton snippetsOption;
    }
}