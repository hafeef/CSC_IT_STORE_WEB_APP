using CSC.Core.Common.Identity;
using System;

namespace CSC.Core.Common.Contracts
{
    public interface IChangeTracker
    {
        DateTimeOffset? CreatedDateTime { get; set; }
        DateTimeOffset? ModifiedDateTime { get; set; }
        string Id { get; set; }
        ApplicationUser CreatedBy { get; set; }
    }
}
