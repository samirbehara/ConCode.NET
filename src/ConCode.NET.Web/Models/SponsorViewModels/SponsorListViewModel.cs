﻿using ConCode.NET.Core.Domain;
using System.Collections.Generic;

namespace ConCode.NET.Web.Models.SponsorViewModels
{
    public class SponsorListViewModel
    {
        public IEnumerable<Sponsor> SponsorList { get; set; }
    }
}
