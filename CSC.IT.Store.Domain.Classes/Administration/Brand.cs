using CSC.Core.Common.Contracts;
using System;

namespace CSC.IT.Store.Domain.Classes.Administration
{
    public sealed partial class Brand : IChangeTracker
    {
        public Guid BrandId { get; set; }
        public string BrandName { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string CreatedBy { get; set; }
    }
}
