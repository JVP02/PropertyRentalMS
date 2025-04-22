using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRentalManagementSystem.Model
{
    internal class Connection
    {
        private string connectionString = "server=127.0.0.1; user=root; database=db_prms; password=";

        public string ConnectionString

        {
            get { return connectionString; }
            set { connectionString = value; }
        }

    }
}
