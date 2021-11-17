using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace ExpenseReportV2.Ministries
{
    public class MinistryDto : AuditedEntityDto<Guid>
    {

        public string Name { get; set; }

        public string Signature { get; set; }

        public int MinistryNumber { get; set; }


    }
}
