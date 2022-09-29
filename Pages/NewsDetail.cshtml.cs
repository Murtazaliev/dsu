using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DguDomain;
using DguSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DguSite.Pages
{
    public class NewsDetailModel : PageModel
    {
        protected IRepository _repository;
        CommonHelper _ch = CommonHelper.getInstance();
        public NewsDetailModel(IRepository repository)
        {
            _repository = repository;
        }
        public DataNews DataNewsDetail { get; set; }
        public List<DataNewsTag> Tags { get; set; }
        public async Task OnGet(int newsId)
        {
            DataNewsDetail = _repository.DataNews.Include(s => s.DataNewsSliders).FirstOrDefault(x => x.Id == newsId);
            string sql = String.Format(@"SELECT         title, image_bytes, date_add, spr_news_type_id, body
                            FROM            data_news
                            WHERE        (id = {0})", newsId);
            var newslist = await _ch.GetDataTableAsync(sql);
            if (newslist.Rows.Count > 0)
            {
                foreach (DataRow item in newslist.Rows)
                {
                    if (DataNewsDetail.ImageBytes != null)
                    {
                        string s1 = Convert.ToBase64String((byte[])item["image_bytes"]);
                        DataNewsDetail.Avatar = String.Format("data:image/gif;base64,{0}", s1);
                        DataNewsDetail.Body = (string)item["body"];
                        DataNewsDetail.DateAdd = (DateTime)item["date_add"];
                        DataNewsDetail.Title = (string)item["title"];
                    }
                }



                string sqlSlider = String.Format(@"SELECT *
                                                        FROM data_news_slider
                                                        WHERE (data_news_id = {0})", newsId);
                var newsSliderlist = await _ch.GetDataTableAsync(sql);
                if (newsSliderlist.Rows.Count > 0)
                {
                    DataNewsDetail.DataNewsSliders = new List<DataNewsSlider>();
                    foreach (DataRow item in newsSliderlist.Rows)
                    {
                        string s2 = Convert.ToBase64String((byte[])item["image_bytes"]);
                        DataNewsDetail.DataNewsSliders.Add(new DataNewsSlider { Image = String.Format("data:image/gif;base64,{0}", s2) });
                    }
                }
            }

            Tags = _repository.DataNewsTag.Where(p => p.NewsId == newsId).ToList();           
        }

        //List<UINews> GetFamiliarNews(int? newsId)
        //{
        //    if (newsId != null)
        //    {
        //        var tags = _repository.DataNewsTag.Where(x => x.NewsId == newsId);

        //        if (tags != null)
        //        {
        //            FamiliarNews = new List<UINews>();
        //            foreach (var tag in tags)         
        //            {
        //                //string sqlTags = String.Format(@"SELECT news_id
        //                //                                    FROM data_news_tag
        //                //                                    WHERE (name = '{0}') AND (news_id != {1})", tag.Name, tag.NewsId);
        //                string sqlNews = String.Format(@"SELECT data_news.id, data_news.title, data_news.date_add, data_news.spr_news_type_id, data_news.body FROM data_news JOIN data_news_tag ON data_news_tag.news_id = data_news.id  WHERE (name = '{0}') AND (news_id != {1})", tag.Name, newsId);
        //                var newsFamiliar = _ch.GetDataTableAsync(sqlNews).Result;

        //                if (newsFamiliar.Rows.Count > 0)
        //                {
        //                    foreach (DataRow item in newsFamiliar.Rows)
        //                    {
        //                        List<UINews> news = FamiliarNews.FindAll(p => p.Id == (int)item["id"]);
        //                        if (news.Count > 0)
        //                            continue;

        //                        var x = new UINews();
        //                        x.Avatar = GetNewsImage((int)item["id"]).Result;
        //                        x.DateAdd = (DateTime)item["date_add"];

        //                        var regexpH3 = new Regex(@"<h\d[^<>]*>[^&nbsp].+?<\/h\d>", RegexOptions.IgnoreCase | RegexOptions.Multiline);
        //                        var match = regexpH3.Match((string)item["body"]);
        //                        x.Annotation = match.Value;

        //                        //x.Annotation = (string)item["body"];
        //                        x.Title = (string)item["title"];
        //                        x.Id = (int)item["id"];                                
        //                        FamiliarNews.Add(x);
        //                    }
        //                }                  
        //            }

        //        }
        //    }                   
        //    return GetTagsForNews(FamiliarNews);
        //}

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
