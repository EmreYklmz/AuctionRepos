﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.Application.CategoryServices.Dtos
{
    public class UpdateCategoryViewModel
    {
        public int Id { get; set; }
        public string ModifiedById { get; set; }
        //public string Name { get; set; }
        //public string UrlName { get; set; }
        //public string CreatedById { get; set; }
    }
}