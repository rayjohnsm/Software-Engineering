using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeIn_Out_Recording
{
    class MySqlConnection
    {
        private string p;

        public MySqlConnection(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}
