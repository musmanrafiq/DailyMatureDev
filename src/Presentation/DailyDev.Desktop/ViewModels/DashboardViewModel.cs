using DailyDev.Domain.Data;
using DailyDev.Domain.Models;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Collections.ObjectModel;
using System.Linq;

namespace DailyDev.Desktop.ViewModels
{
    public class DashboardViewModel : MvxViewModel
    {
        public DashboardViewModel()
        {

            AddSiteCommand = new MvxCommand(AddSite);
            ItemClickedCommand = new MvxCommand(ItemClicked);

            using var dbContext = new DailyDevDbContext();
            var sites = dbContext.SiteModels.ToList();
            foreach (SiteModel site in sites)
            {
                Sites.Add(site);
            }
        }

        public void ItemClicked()
        {
        }
        public IMvxCommand AddSiteCommand { get; set; }
        public IMvxCommand ItemClickedCommand { get; set; }
        public bool CanAddSite => Url?.Length > 0;

        public void AddSite()
        {
            SiteModel p = new SiteModel
            {
                Url = Url
            };
            Url = string.Empty;
            Sites.Add(p);

            using var dbContext = new DailyDevDbContext();
            dbContext.SiteModels.Add(p);
            dbContext.SaveChanges();
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
