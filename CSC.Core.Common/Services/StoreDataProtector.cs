using Microsoft.Owin.Security.DataProtection;
using System.Web.Security;

namespace CSC.Core.Common.Services
{
    public class StoreDataProtector : IDataProtector
    {
        public byte[] Protect(byte[] userData)
        {
            return MachineKey.Protect(userData);
        }

        public byte[] Unprotect(byte[] protectedData)
        {
            return MachineKey.Unprotect(protectedData);
        }
    }
}
