using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Vostronia.Core
{
    public interface IDefaultService
    {
        Task<Service> GetDefaultService();
    }
}
