using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitbot.Services
{
    public interface INetworkService
    {
        string Get();
        void Post(string paramaters);
    }
}
