using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class RequestManager
    {
        private readonly string _data;

        public RequestManager(string request)
        {
            request = Parse(request);
            Verify(request);
            _data = Ask(request);
        }

        public string Data => _data;

        private string Ask(string request)
        {
            DataDispatcher dd = new DataDispatcher();
            return dd.GetData(request);
        }

        private string Parse(string request)
        {
            return "";
        }

        private void Verify(string request)
        {

        }
    }
}
