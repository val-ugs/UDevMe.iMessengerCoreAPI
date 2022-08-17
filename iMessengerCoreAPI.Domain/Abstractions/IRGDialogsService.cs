using iMessengerCoreAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMessengerCoreAPI.Domain.Abstractions
{
    public interface IRGDialogsService
    {
        Guid TryFindCommonDialog(List<RGDialogsClients> clients);
    }
}
