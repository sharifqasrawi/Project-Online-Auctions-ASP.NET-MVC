﻿using OnlineAuctionProject.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineAuctionProject.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public Auction Auction { get; set; }

        [Display(Name = "Bidder", ResourceType = typeof(Resource))]
        public ApplicationUser Bidder { get; set; }

        [Display(Name = "BidValue", ResourceType = typeof(Resource))]
        public double BidValue { get; set; }

        [Display(Name = "BidDateTime", ResourceType = typeof(Resource))]
        public DateTime? BidDateTime { get; set; }
    }
}