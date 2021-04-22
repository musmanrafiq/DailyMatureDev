using System.Text;

namespace DailyDev.Desktop.Helpers
{
    public class HtmlHelper
    {
        private StringBuilder builder;

        public HtmlHelper()
        {
            builder = new StringBuilder();
        }

        public void PrepareHtml(string tagType, string content)
        {
            builder.Append($"<{tagType}>{content}</{tagType}>");
            builder.Append("<br />");
        }

        public string GetHtml()
        {
            return builder.ToString();
        }
    }
}
