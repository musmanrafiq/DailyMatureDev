﻿using DailyDev.Desktop.Views;
using DailyDev.Domain.Business.Models;
using DailyDev.Domain.Data;
using DailyDev.Domain.Models;
using DailyDev.Infrastructure.Services;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using SiteModel = DailyDev.Domain.Models.SiteModel;

namespace DailyDev.Desktop.ViewModels
{
    public class DashboardViewModel : MvxViewModel
    {
        #region private properties

        private List<FeedItemModel> _postsToPublish;

        #endregion
        #region private commands
        private MvxCommand<SiteModel> _itemSelectedCommand;
        private MvxCommand<SiteModel> _removeSiteCommand;
        private MvxCommand<FeedItemModel> _blogSelectedCommand;
        private MvxCommand _publishCommand;
        private MvxCommand<FeedItemModel> _addToPublishCommand;
        private MvxCommand<FeedItemModel> _removeFromPublishCommand;
        #endregion

        #region public commands for bindings
        public IMvxCommand ItemSelectedCommand => _itemSelectedCommand ?? (_itemSelectedCommand = new MvxCommand<SiteModel>(async (item) => await OnItemSelectedAsync(item)));
        public IMvxCommand RemoveSiteCommand => _removeSiteCommand ?? (_removeSiteCommand = new MvxCommand<SiteModel>(async (item) => await OnRemoveSiteAsync(item)));
        public IMvxCommand BlogSelectedCommand => _blogSelectedCommand ?? (_blogSelectedCommand = new MvxCommand<FeedItemModel>(OnBlogSelectAsync));
        public IMvxCommand PublishCommand => _publishCommand ?? (_publishCommand = new MvxCommand(async () => await OnPublish()));
        public IMvxCommand AddToPublishCommand => _addToPublishCommand ?? (_addToPublishCommand = new MvxCommand<FeedItemModel>(OnAddToPublish));
        public IMvxCommand RemoveFromPublishCommand => _removeFromPublishCommand ?? (_removeFromPublishCommand = new MvxCommand<FeedItemModel>(OnRemoveFromPublish));
        #endregion

        private void OnRemoveFromPublish(FeedItemModel blogPost)
        {
            using var dbContext = new DailyDevDbContext();
            var existingEntry = dbContext.TempLinks.Where(x => x.FeedPostId == blogPost.Id).FirstOrDefault();
            if (existingEntry != null)
            {
                dbContext.TempLinks.Remove(existingEntry);
                dbContext.SaveChanges();
            }
        }

        private void OnAddToPublish(FeedItemModel blogPost)
        {
            using var dbContext = new DailyDevDbContext();
            var hasEixtingEntry = dbContext.TempLinks.Any(x => x.FeedPostId == blogPost.Id);

            if (!hasEixtingEntry)
            {
                dbContext.TempLinks.Add(new TempLink { FeedPostId = blogPost.Id, Author = blogPost.Author, Title = blogPost.Title, Url = blogPost.Link });
                dbContext.SaveChanges();
            }
        }



        private async Task OnPublish()
        {
            PostView p = new PostView();
            p.ShowDialog();

            /*using var dbContext = new DailyDevDbContext();
            var links = dbContext.TempLinks.ToList();
            if (links.Any())
            {
                var htmlHelper = new HtmlHelper();
                htmlHelper.PrepareHtml("h2", "Information");

                foreach (var item in links)
                {
                    htmlHelper.PrepareHtml("div", $"- <a href='{item.Url}'>{item.Title}</a> by {item.Author}");
                }
                var htmlBody = htmlHelper.GetHtml();
                var smtpService = new SmtpService();
                var prepareTitle = await PrepareTitleForMyBlogPostAsync();
                smtpService.SendEmail(prepareTitle, htmlBody);
        }*/
    }

    private async Task<string> PrepareTitleForMyBlogPostAsync()
    {

        FeedService service = new FeedService();
        var (feedItemModel, error) = await service.FetchLatestPost("https://www.usmanrafiq.com/feeds/posts/default");
        if (feedItemModel != null)
        {
            var postNumber = int.Parse(feedItemModel.Title.Split('#')[1]);
            return $"The Morning Mash # {postNumber + 1}";
        }
        return $"The Morning Mash # {DateTime.Now.ToString("ddmmyyyy")}";
    }

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
        TotalBlogsCount = Sites.Count();
    }

    public DashboardViewModel()
    {
        //initialize 
        _postsToPublish = new List<FeedItemModel>();

        ButtonText = "Add Site";
        AddSiteCommand = new MvxCommand(AddSite);

        using var dbContext = new DailyDevDbContext();
        var sites = dbContext.SiteModels.ToList();
        foreach (SiteModel site in sites)
        {
            Sites.Add(site);
        }
        TotalBlogsCount = Sites.Count();
    }

    public async Task OnItemSelectedAsync(SiteModel model)
    {
        if (model != null)
        {
            BlogPosts.Clear();
            ButtonText = "Update Site";
            Url = model.Url;
            Name = model.Name;
            Id = model.Id;

            FeedService service = new FeedService();
            var (feedModel, error) = await service.FetchAsync(model.Url);
            if (feedModel != null)
            {
                BlogTitle = feedModel.Title;
                BlogPosts.Clear();
                foreach (FeedItemModel item in feedModel.Items)
                {
                    BlogPosts.Add(item);
                }
            }
            else
            {
                var psi = new ProcessStartInfo
                {
                    FileName = model.Url,
                    UseShellExecute = true
                };
                Process.Start(psi);

                NotificationBackground = Brushes.Red;
                NotificationText = error;
                ShowNotification = Visibility.Visible;



                await Task.Factory.StartNew(
async () =>
{
    await Task.Delay(2000);

    NotificationBackground = Brushes.Green;
    NotificationText = string.Empty;
    ShowNotification = Visibility.Collapsed;
}
);

            }
        }
    }


    public IMvxCommand AddSiteCommand { get; set; }
    public IMvxCommand ItemClickedCommand { get; set; }
    public bool CanAddSite => Url?.Length > 0 && Name?.Length > 0;
    public int TotalBlogsCount { get; set; } = 0;
    public void AddSite()
    {

        SiteModel site = new SiteModel
        {
            Id = Id,
            Url = Url,
            Name = Name
        };
        //Url = string.Empty;

        using var dbContext = new DailyDevDbContext();
        if (Id > 0)
        {
            dbContext.Update(site);
        }
        else
        {
            dbContext.SiteModels.Add(site);

        }
        dbContext.SaveChanges();

        if (Id > 0)
        {
            var existingRecord = Sites.FirstOrDefault(x => x.Id == Id);
            Sites.Remove(existingRecord);
        }

        Sites.Add(site);

        Id = 0;
        Url = string.Empty;
        Name = string.Empty;
        ButtonText = "Add Site";

        TotalBlogsCount = Sites.Count();
    }
    private ObservableCollection<Domain.Models.SiteModel> _sites = new ObservableCollection<Domain.Models.SiteModel>();

    public ObservableCollection<Domain.Models.SiteModel> Sites
    {
        get { return _sites; }
        set { SetProperty(ref _sites, value); }
    }

    private int _id;
    public int Id
    {
        get { return _id; }
        set
        {
            SetProperty(ref _id, value);
        }
    }

    private string _buttonText;

    public string ButtonText
    {
        get { return _buttonText; }
        set
        {
            SetProperty(ref _buttonText, value);
        }
    }

    private string _name;

    public string Name
    {
        get { return _name; }
        set
        {
            SetProperty(ref _name, value);
            RaisePropertyChanged(() => CanAddSite);
        }
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

    private Visibility _showNotification;
    public Visibility ShowNotification
    {
        get { return _showNotification; }
        set
        {
            SetProperty(ref _showNotification, value);
        }
    }

    private Brush _notificationBackground;
    public Brush NotificationBackground
    {
        get { return _notificationBackground; }
        set
        {
            SetProperty(ref _notificationBackground, value);
        }
    }

    private string _notificationText;
    public string NotificationText
    {
        get { return _notificationText; }
        set
        {
            SetProperty(ref _notificationText, value);
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