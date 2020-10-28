using DailyDev.Domain.Models;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Collections.ObjectModel;

namespace DailyDev.Desktop.ViewModels
{
    public class DashboardViewModel : MvxViewModel
    {
        public DashboardViewModel()
        {
            AddSiteCommand = new MvxCommand(AddSite);
            Sites.Add(new SiteModel { Url = "abc" });
            Sites.Add(new SiteModel { Url = "abc" });
        }

        public IMvxCommand AddSiteCommand { get; set; }
        public bool CanAddSite => Url?.Length > 0;

        public void AddSite()
        {
            SiteModel p = new SiteModel
            {
                Url = Url
            };
            Url = string.Empty;
            Sites.Add(p);
        }
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
            set
            {
                SetProperty(ref _url, value);
                RaisePropertyChanged(() => CanAddSite);
            }
        }

    }
}
