using DailyDev.Domain.Models;
using MvvmCross.ViewModels;
using System.Collections.ObjectModel;

namespace DailyDev.Desktop.ViewModels
{
    public class SiteViewModel : MvxViewModel
    {
        private ObservableCollection<SiteModel> _sites = new ObservableCollection<SiteModel>();

        public ObservableCollection<SiteModel> Sites
        {
            get { return _sites; }
            set { SetProperty(ref _sites, value); }
        }

        private string _url;

        public string Url
        {
            get { return _url; }
            set { SetProperty(ref _url, value); }
        }

    }
}
