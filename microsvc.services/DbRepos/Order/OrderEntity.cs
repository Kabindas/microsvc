using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace microsvc.services.DbRepos.Order
{
    public partial class OrderEntity
    {
        public int Id { get; set; }
        public decimal? TotalSpent { get; set; }
        public int? UserId { get; set; }
    }
}
