using DailyDev.Domain.Business.Models;
using DailyDev.Domain.Data;
using DailyDev.Domain.Models;
using DailyDev.Infrastructure.Services;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SiteModel = DailyDev.Domain.Models.SiteModel;

namespace DailyDev.Desktop.ViewModels
{
    public class DashboardViewModel : MvxViewModel
    {
        private MvxCommand<Domain.Models.SiteModel> _itemSelectedCommand;

        public IMvxCommand ItemSelectedCommand => _itemSelectedCommand ?? (_itemSelectedCommand = new MvxCommand<SiteModel>(async (item) => await OnItemSelectedAsync(item)));


        private MvxCommand<Domain.Models.SiteModel> _removeSiteCommand;
        public IMvxCommand RemoveSiteCommand => _removeSiteCommand ?? (_removeSiteCommand = new MvxCommand<SiteModel>(async (item) => await OnRemoveSiteAsync(item)));

        private MvxCommand<FeedItemModel> _blogSelectedCommand;

        public IMvxCommand BlogSelectedCommand => _blogSelectedCommand ?? (_blogSelectedCommand = new MvxCommand<FeedItemModel>(OnBlogSelectAsync));

        private void OnBlogSelectAsync(FeedItemModel item)
        {
            var psi = new ProcessStartInfo
            {
                FileName = item.Link,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private async Task OnRemoveSiteAsync(SiteModel model)
        {
            using var dbContext = new DailyDevDbContext();
            dbContext.Remove(model);
            await dbContext.SaveChangesAsync();
            Sites.Remove(model);
        }

        public DashboardViewModel()
        {

            AddSiteCommand = new MvxCommand(AddSite);

            using var dbContext = new DailyDevDbContext();
            var sites = dbContext.SiteModels.ToList();
            foreach (Domain.Models.SiteModel site in sites)
            {
                Sites.Add(site);
            }
        }

        public async Task OnItemSelectedAsync(Domain.Models.SiteModel model)
        {
            if (model != null)
            {
                FeedService service = new FeedService();
                var a = await service.FetchAsync(model.Url);
                BlogTitle = a.Title;
                BlogPosts.Clear();
                foreach (FeedItemModel item in a.Items)
                {
                    BlogPosts.Add(item);
                }

            }
        }
        public IMvxCommand AddSiteCommand { get; set; }
        public IMvxCommand ItemClickedCommand { get; set; }
        public bool CanAddSite => Url?.Length > 0;

        public void AddSite()
        {
            Domain.Models.SiteModel p = new Domain.Models.SiteModel
            {
                Url = Url
            };
            Url = string.Empty;
            Sites.Add(p);

            using var dbContext = new DailyDevDbContext();
            dbContext.SiteModels.Add(p);
            dbContext.SaveChanges();
        }
        private ObservableCollection<Domain.Models.SiteModel> _sites = new ObservableCollection<Domain.Models.SiteModel>();

        public ObservableCollection<Domain.Models.SiteModel> Sites
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

        private string _blogTitle;

        public string BlogTitle
        {
            get { return _blogTitle; }
            set
            {
                SetProperty(ref _blogTitle, value);
            }
        }

        private ObservableCollection<FeedItemModel> _blogPosts = new ObservableCollection<FeedItemModel>();

        public ObservableCollection<FeedItemModel> BlogPosts
        {
            get { return _blogPosts; }
            set { SetProperty(ref _blogPosts, value); }
        }
    }
}
