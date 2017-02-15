﻿using System;
using Weapsy.Infrastructure.Queries;

namespace Weapsy.Reporting.Languages.Queries
{
    public class GetForAdmin : IQuery
    {
        public Guid SiteId { get; set; }
        public Guid Id { get; set; }
    }
}
