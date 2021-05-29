using DailyDev.Desktop.Core.Commands;
using DailyDev.Domain.Data;
using DailyDev.Domain.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace DailyDev.Desktop.ViewModels
{
    public class PostViewModel : ViewModelBase
    {

        #region private fields

        private string _summary;

        private readonly DelegateCommand _remotePostItem;

        #endregion

        #region public fields

        public ObservableCollection<TempLink> TempLinks { get; set; }

        public string Summary
        {
            get => _summary;
            set => SetProperty(ref _summary, value);
        }

        public ICommand RemovePostItem => _remotePostItem;

        #endregion

        #region constructors
        public PostViewModel()
        {
            TempLinks = new ObservableCollection<TempLink>();
            using var dbContext = new DailyDevDbContext();
            var list = dbContext.TempLinks.ToList();
            foreach (var item in list)
            {
                TempLinks.Add(item);
            }

            _remotePostItem = new DelegateCommand(OnRemoveItem, (commandParameter) => { return true; });
        }

        private void OnRemoveItem(object commandParameter)
        {
            TempLink tempLink = (TempLink)commandParameter;
            using var dbContext = new DailyDevDbContext();
            var a = dbContext.TempLinks.Remove(tempLink);
            dbContext.SaveChanges();
            TempLinks.Remove(tempLink);
        }

        #endregion

    }
}
