using baitapso3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace baitapso3.ViewModels
{
    public class FollowingViewModel
    {
        public IEnumerable<ApplicationUser> Followings { get; set; }
        public bool ShowAction { get; set; }
    }
}