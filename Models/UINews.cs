using DguDomain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DguSite.Models
{
    public class UINews
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Avatar { get; set; }
        public string Annotation { get; set; }
        public DateTime DateAdd { get; set; }
        public List<DataNewsTag> Tags { get; set; }
    }
}
