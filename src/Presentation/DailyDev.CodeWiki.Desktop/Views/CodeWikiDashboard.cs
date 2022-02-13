using DailyDev.CodeWiki.Desktop.Models;
using Microsoft.Extensions.Configuration;

namespace DailyDev.CodeWiki.Desktop
{
    public partial class CodeWikiDashboard : Form
    {
        private Settings settings;

        public CodeWikiDashboard()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            settings = Program.Configuration.GetSection("Settings").Get<Settings>();

        }

            private async void onKeyDownEventHandler(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                // dispable sound on enter press
                e.Handled = e.SuppressKeyPress = true;

                await Task.Run(() =>
                {
                    searchProgress.Value = 0;
                    matchedItems.Clear();

                    var directories = new List<string>();
                    if (snippetsOption.Checked)
                    {
                        directories.Add(settings.SnippetsDirectory);
                    }
                    else if (codeDirectoryOption.Checked)
                    {
                        directories.Add(settings.DevelopmentDirectory);
                    }
                    else if (bothOption.Checked)
                    {
                        directories.Add(settings.DevelopmentDirectory);
                        directories.Add(settings.SnippetsDirectory);
                    }

                    List<FileInfo> files = new List<FileInfo>();

                    foreach(var dir in directories)
                    {
                        var directoryInfo = new DirectoryInfo(dir);
                        var tempFiles = directoryInfo.GetFilesByExtensions(".cs", ".java", ".js", ".txt");
                        files.AddRange(tempFiles);
                    }


                    for (int iteration = 0; iteration < files.Count; iteration ++)
                    {
                        searchProgress.Value = GetPercentageValue(iteration, files.Count);
                        var tempFilePath = files[iteration].FullName;
                        var hasFound = File.ReadAllText(tempFilePath).Contains(searchBox.Text);
                        if (hasFound)
                        {
                            matchedItems.Items.Add(tempFilePath);
                        }
                    }
                    searchProgress.Value = 0;
                });
            }
        }

        private  void matched_Item_ClickedAsync(object sender, EventArgs e)
        {
            var selectedItems = matchedItems.SelectedItems;
            if (selectedItems.Count > 0)
            {
                var firstSelectedItem = selectedItems[0];
                var fileContent = File.ReadAllText(firstSelectedItem.Text);
                selectedItem.Text = fileContent;
            }
        }

        private int GetPercentageValue(double currentValue, double total)
        {
            var percentage = currentValue / total * 100;
            if(percentage < 0)
            {
                percentage = 10;
            }
            return Convert.ToInt32(percentage);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var newSnippet = inputSnippet.Text;
            if (!string.IsNullOrEmpty(newSnippet))
            {
                var guid = Guid.NewGuid();
                var fileName = guid.ToString()+"_"+DateTime.Now.Ticks.ToString()+".txt";
                var snippetDirectory = @$"F:\SyncDrives\Dropbox\CodeWiki\{fileName}";
                await File.WriteAllTextAsync(snippetDirectory, newSnippet);

            }
        }
    }
}