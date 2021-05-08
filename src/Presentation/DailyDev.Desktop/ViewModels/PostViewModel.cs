using DailyDev.Domain.Data;
using DailyDev.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace DailyDev.Desktop.ViewModels
{
    public class PostViewModel : ViewModelBase
    {

        #region private fields

        private List<TempLink> _tempLinks;
        private string _summary;

        #endregion

        #region public fields

        public List<TempLink> TempLinks
        {
            get => _tempLinks;
            set => SetProperty(ref _tempLinks, value);
        }

        public string Summary
        {
            get => _summary;
            set => SetProperty(ref _summary, value);
        }

        #endregion

        public PostViewModel()
        {
            using var dbContext = new DailyDevDbContext();
            TempLinks = dbContext.TempLinks.ToList();
        }
    }
}
