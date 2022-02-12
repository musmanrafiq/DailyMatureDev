namespace DailyDev.CodeWiki.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                    string directoryPath = @"C:\Development";

                    var directoryInfo = new DirectoryInfo(directoryPath);
                    var files = directoryInfo.GetFilesByExtensions(".cs", ".java", ".js").ToList();

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
    }
}