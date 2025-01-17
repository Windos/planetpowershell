using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DavidOBrien : IFilterMyBlogPosts, IAmAMicrosoftMVP
    {
        public string FirstName => "David";
        public string LastName => "O'Brien";
        public string ShortBioOrTagLine => "is a Microsoft MVP, DevOps Consultant/Engineer, do AWS and a lot of Cloud.";
        public string StateOrRegion => "Melbourne, Australia";
        public string EmailAddress => "me@david-obrien.net";
        public string TwitterHandle => "david_obrien";
        public string GravatarHash => "c93bbf72255d38bab70895eb7c0b3f99";
        public Uri WebSite => new Uri("https://david-obrien.net/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://david-obrien.net/feed.xml"); }
        }
        public string GitHubHandle => "davidobrien1985";
        public bool Filter(SyndicationItem item)
        {
            return item.Categories?.Any(c => c.Name.ToLowerInvariant().Contains("powershell")) ?? false;
        }
        public GeoPosition Position => new GeoPosition(-37.8136,144.9631);
        public string FeedLanguageCode => "en";
    }
}