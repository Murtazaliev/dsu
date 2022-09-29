using DguDomain;
using DguSite.Models;
using FluentFTP;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DguSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        protected IRepository _repository;
        CommonHelper _ch = CommonHelper.getInstance();
        public IndexModel(ILogger<IndexModel> logger, IRepository repository)
        {
            _repository = repository;
            _logger = logger;
        }
        private List<UINews> News { get; set; }

        async Task<List<UINews>> GetNews()
        {

            if (News != null)
                return News;
            string sql = @"SELECT        TOP (6) id, title, avatar, date_add, spr_news_type_id, body
                            FROM            data_news
                            WHERE        (spr_news_type_id = 1) AND (GETDATE() >= CONVERT(datetime, date_add, 120))
                            ORDER BY date_add DESC";
            var newslist = await _ch.GetDataTableAsync(sql);
            
            News = new List<UINews>();
            if (newslist.Rows.Count > 0)
            {
                foreach (DataRow item in newslist.Rows)
                {
                    var x = new UINews();
                    x.Avatar = await GetNewsImage((int)item["id"]);
                    x.DateAdd = (DateTime)item["date_add"];

                    //var regexpH3 = new Regex(@"<h3[^<>]*>[^<]*<\/h3>", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                    var regexpH3 = new Regex(@"<h\d[^<>]*>[^&nbsp].+?<\/h\d>", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                    var match = regexpH3.Match((string)item["body"]);
                    x.Annotation = match.Value;

                    x.Title = (string)item["title"];
                    x.Id = (int)item["id"];
                    News.Add(x);
                }
            }
            return GetTagsForNews(News);

        }

        List<UINews> GetTagsForNews(List<UINews> dataNews)
        {
            foreach (var item in dataNews)
            {
                item.Tags = _repository.DataNewsTag.Where(p => p.NewsId == item.Id).ToList();
            }
            return dataNews;
        }
        void test()
        {


        }
        async Task<List<UINews>> GetSlider()
        {
            if (News != null)
                return News;
            string sql = @"SELECT         id, title, avatar, date_add, spr_news_type_id
                            FROM            data_news
                            WHERE        (spr_news_type_id = 1 AND is_in_slider = 1)
                            ORDER BY date_add";
            var newslist = await _ch.GetDataTableAsync(sql);
            News = new List<UINews>();
            if (newslist.Rows.Count > 0)
            {
                foreach (DataRow item in newslist.Rows)
                {
                    var x = new UINews();
                    x.Avatar = await GetNewsImage((int)item["id"]);
                    x.DateAdd = (DateTime)item["date_add"];
                    x.Title = (string)item["title"];
                    x.Id = (int)item["id"];
                    News.Add(x);
                }
            }
            return News;
        }
        public void OnGet()
        {

        }

        //public IEnumerable<FacultyNews> FacultyNews => _repository.FacMenu.Join
        //    (_repository.FacNews,
        //    m => m.Menuid,
        //    n => n.Menuid, (m, n) => new FacultyNews { faculty = m.Text, id = m.Menuid, title = n.Title, url = m.Url, dateAdd = n.Data }).OrderByDescending(x => x.dateAdd).Take(6);
        public IEnumerable<Faculty> Faculty => _repository.FacFaculty.Join
            (_repository.FacMenu,
            f => f.Fid,
            m => m.Menuid, (f, m) => new Faculty { title = f.Name, url = m.Url });

        public async Task<IActionResult> OnGetMainMews()
        {
            return Partial("_MainNewsList", await Task.Run(() => GetNews()));
        }
        public async Task<IActionResult> OnGetSlider()
        {
            var x = Partial("_Slider", await GetSlider());
            return x;
        }
        public IActionResult OnGetMainADS()
        {
            var model = _repository.SprNewsType.Include(x => x.DataNews.OrderByDescending(x => x.DateAdd).Take(3)).Where(x => x.Id != 1).OrderBy(o => o.Id).ToList();
            return Partial("_MainAdsList", model);
        }






        public async Task<string> GetNewsImage(int id)
        {
            try
            {
                string sql = String.Format(@"SELECT         image_bytes
                            FROM            data_news
                            WHERE        (id = {0})", id);
                var dataNews = await _ch.GetDataTableAsync(sql);

                foreach (DataRow item in dataNews.Rows)
                {
                    string s = Convert.ToBase64String((byte[])item["image_bytes"]);
                    var imgSrc = String.Format("data:image/gif;base64,{0}", s);
                    return imgSrc;
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public async Task<string> GetSliderImage(int id)
        {

            string sql = String.Format(@"SELECT         image_bytes
                            FROM            data_news_slider
                            WHERE        (id = {0})", id);
            var dataNews = await _ch.GetDataTableAsync(sql);
            foreach (DataRow item in dataNews.Rows)
            {
                string s = Convert.ToBase64String((byte[])item["image_bytes"]);
                var imgSrc = String.Format("data:image/gif;base64,{0}", s);
                return imgSrc;
            }
            return null;
        }
        //public FileContentResult OnGetGetNewsImage(int id)
        //{
        //    var dataNews =  _repository.DataNews.FirstOrDefault(f => f.Id == id);



        //    FtpSettings ftpSettings = new FtpSettings();
        //    FtpClient client = new FtpClient(ftpSettings.Server)
        //    {
        //        Credentials = new NetworkCredential(ftpSettings.User, ftpSettings.Password)
        //    };
        //    client.Connect();
        //    new FileExtensionContentTypeProvider().TryGetContentType($"{dataNews.Avatar}", out string contentType);
        //    var file = client.DownloadAsync($"/{ftpSettings.Folder}/{dataNews.Avatar}").Result;
        //    client.Disconnect();
        //    client.Dispose();
        //    var result =  File(file, $"image/{dataNews.AvatarExtension}");
        //    return result;
        //}
        //public FileContentResult OnGetGetSliderImage(int id)
        //{
        //    DataNewsSlider dataDocumentFile =  _repository.DataNewsSlider.FirstOrDefault(f => f.Id == id);



        //    FtpSettings ftpSettings = new FtpSettings();
        //    FtpClient client = new FtpClient(ftpSettings.Server)
        //    {
        //        Credentials = new NetworkCredential(ftpSettings.User, ftpSettings.Password)
        //    };
        //    client.Connect();
        //    new FileExtensionContentTypeProvider().TryGetContentType($"{dataDocumentFile.Image}", out string contentType);
        //    var file = client.DownloadAsync($"/{ftpSettings.Folder}/{dataDocumentFile.Image}").Result;
        //    client.Disconnect();
        //    client.Dispose();
        //    return File(file, $"image/{dataDocumentFile.ImageExtension}");
        //}




    }
}
