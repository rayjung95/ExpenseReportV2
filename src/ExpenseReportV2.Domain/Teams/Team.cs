using ExpenseReportV2.Ministries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace ExpenseReportV2.Teams
{
    public class Team : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public int TeamNumber { get; set; }

        public Ministry Ministry { get; set; }

    }
}
