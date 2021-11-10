﻿using ExpenseReportV2.Teams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace ExpenseReportV2.Ministries
{
    public class Ministry : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public string Signature { get; set; }

        public int MinistryNumber { get; set; }

        public ICollection<Team> Teams { get; set; }
    }
}
