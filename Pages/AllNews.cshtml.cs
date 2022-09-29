using DguDomain;
using DguSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DguSite.Pages
{
    public class AllNewsModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        protected IRepository _repository;

        CommonHelper _ch = CommonHelper.getInstance();
        public AllNewsModel(ILogger<IndexModel> logger, IRepository repository)
        {
            _repository = repository;
            _logger = logger;
        }
        public List<UINews> News { get; set; }
        public int CountPages { get; set; }
        public int CurrentPage { get; set; }

        public string SearchTag { get; set; }
        public int NType { get; set; }
        public async Task OnGet(int? pageNumber, int nt, string? tag)
        {
            //GetNews();
            if (pageNumber == null)
            {
                GetPage(1, nt, tag);
            }
            CurrentPage = pageNumber ?? 1;
            GetPage(pageNumber, nt, tag);

            string sql = String.Format(@"SELECT  count (id) as num
                            FROM            data_news
                            WHERE        (spr_news_type_id = {0})", nt);
            var newslist = await _ch.GetDBValueAsync(sql);
            //News = new List<UINews>();
            //if (newslist.Rows.Count > 0)
            //{
            //    foreach (DataRow item in newslist.Rows)
            //    { }
            //}




            CountPages = int.Parse(newslist) / 10;
            if (_repository.DataNews.Count() % 10 != 0)
            {
                CountPages++;
            }

        }
                
        List<UINews> GetPage(int? pageNumber, int nt, string? tag)
        {
                    NType = nt;
            if (News != null)
                return News;
            string sql = String.Format(@"SELECT id, title, date_add, spr_news_type_id, body
                            FROM data_news
                            WHERE (spr_news_type_id = {0})
                            ORDER BY date_add DESC
                            OFFSET {1} ROWS
                            FETCH NEXT {2} ROWS ONLY", nt, (int)(pageNumber - 1) * 10, 10);

            if (tag != null)
            {
                sql = String.Format(@"SELECT data_news.id, data_news.title, data_news.date_add, data_news.spr_news_type_id, data_news.body FROM data_news JOIN data_news_tag ON data_news_tag.news_id = data_news.id  WHERE (name = '{0}') ORDER BY date_add DESC
                            OFFSET {1} ROWS
                            FETCH NEXT {2} ROWS ONLY", tag, (int)(pageNumber - 1) * 10, 10);
                SearchTag = tag;
            }
            var newslist =  _ch.GetDataTableAsync(sql).Result;

            News = new List<UINews>();
            if (newslist.Rows.Count > 0)
            {
                foreach (DataRow item in newslist.Rows)
                {
                    try
                    {
                        var x = new UINews();
                        x.Avatar =  GetNewsImage((int)item["id"]).Result;
                        x.DateAdd = (DateTime)item["date_add"];

                        var regexpH3 = new Regex(@"<h\d[^<>]*>[^&nbsp].+?<\/h\d>", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                        var match = regexpH3.Match((string)item["body"]);
                        x.Annotation = match.Value;

                        //x.Annotation = (string)item["body"];
                        x.Title = (string)item["title"];
                        x.Id = (int)item["id"];
                        News.Add(x);
                    }
                    catch (Exception ex)
                    { 
                    
                    }
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
        public async Task<string> GetNewsImage(int id)
        {
            try
            {
                string sql = String.Format(@"SELECT         image_bytes
                            FROM            data_news
                            WHERE        (id = {0})
                            ORDER BY date_add", id);
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
    }
}
