using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DguDomain;
using DguSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DguSite.Pages
{
    public class InfoDetailModel : PageModel
    {
        protected IRepository _repository;
        CommonHelper _ch = CommonHelper.getInstance();
        public InfoDetailModel(IRepository repository)
        {
            _repository = repository;
        }
        public DataInfo DataInfoDetail { get; set; }
        public List<DataInfo> FamiliarNews { get; set; }
        public bool isForeign { get; set; }
        //public List<DataInfoFile> DataInfoFiles { get; set; }
        public async Task OnGet(int infoId)
        {
            DataInfoDetail = _repository.DataInfo.FirstOrDefault(x => x.Id == infoId);
            if (DataInfoDetail.SprDataInfoTypeId >= 10)
            {
                isForeign = true;
            } 
            else
            {
                isForeign = false;
            }
            //DataInfoFiles = _repository.DataInfoFile.Where(x => x.DataInfoId == infoId).ToList();
            //FamiliarNews = GetFamiliarNews(infoId);
            
            
        }

        //List<DataInfo> GetFamiliarNews(int? infoId)
        //{
        //    if (FamiliarNews != null)
        //        return FamiliarNews;

        //    if (infoId != null)
        //    {
        //        var tags = _repository.DataNewsTag.Where(x => x.NewsId == infoId);
        //        if (tags != null)
        //        {
        //            FamiliarNews = new List<DataInfo>();
        //            foreach (var tag in tags)
        //            {
        //                //string sqlTags = String.Format(@"SELECT news_id
        //                //                                    FROM data_news_tag
        //                //                                    WHERE (name = '{0}') AND (news_id != {1})", tag.Name, tag.NewsId);
        //                string sqlTags = String.Format(@"SELECT data_info.id, data_info.text, data_info.title FROM data_info JOIN data_news_tag ON data_news_tag.news_id = data_info.id  WHERE (name = '{0}') AND (news_id != {1})", tag.Name, infoId);
        //                var newsFamiliar = _ch.GetDataTableAsync(sqlTags).Result;

        //                if (newsFamiliar.Rows.Count > 0)
        //                {
        //                    foreach (DataRow item in newsFamiliar.Rows)
        //                    {
        //                        var x = new DataInfo();
        //                        x.Title = (string)item["title"];
        //                        x.Text = (string)item["text"];
        //                        x.Id = (int)item["id"];
        //                        FamiliarNews.Add(x);
        //                        //FamiliarNews.Add(new DataInfo { Id = (int)item["id"], Title = (string)item["title"], Text = (string)item["text"] });
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return FamiliarNews;
        //}
    }
}
