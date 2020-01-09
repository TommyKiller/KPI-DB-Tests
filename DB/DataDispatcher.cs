using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class DataDispatcher
    {
        private readonly string DataFile;

        public DataDispatcher()
        {
            DataFile = Program.UsersDataFile;
        }

        public string GetData(string request)
        {
            return "";
        }
    }
}
