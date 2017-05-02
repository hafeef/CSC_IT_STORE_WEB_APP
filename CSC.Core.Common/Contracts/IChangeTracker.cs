using CSC.Core.Common.Identity;
using System;

namespace CSC.Core.Common.Contracts
{
    public interface IChangeTracker
    {
        DateTime? CreatedDateTime { get; set; }
        DateTime? ModifiedDateTime { get; set; }
        string CreatedBy { get; set; }
        
    }
}
