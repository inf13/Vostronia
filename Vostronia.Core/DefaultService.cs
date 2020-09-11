using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Vostronia.Core
{
    public class DefaultService : IDefaultService
    {
        public async Task<Service> GetDefaultService()
        {
            var service = new Service() { Name = "Test service" };

            return await Task.FromResult(service);
        }
    }
}
