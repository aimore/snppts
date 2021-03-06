﻿using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class InSpace : IAmASnippet
    {
        public string Slug => "in-space";
        public string Title => "In Space";
        public string GithubRepoName => "sthewissen/KickassUI.InSpace";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A simple but good looking Xamarin.Forms UI screen as talked about in my blogpost on: <a href=\"https://www.thewissen.io/xamarin-forms-in-space\" target=\"_blank\">https://www.thewissen.io/xamarin-forms-in-space</a>";

        public IAmAnAuthor AuthorInfo => new StevenThewissen();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/sthewissen/KickassUI.InSpace/master/ios.png"),
            new Uri("https://raw.githubusercontent.com/sthewissen/KickassUI.InSpace/master/droid.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.CALCULATORS, Category.CARDS
        };
    }
}
