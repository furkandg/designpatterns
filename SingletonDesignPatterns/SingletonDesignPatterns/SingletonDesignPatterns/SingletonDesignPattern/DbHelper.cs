using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPatterns.SingletonDesignPattern
{
   public class DbHelper
    {
        public string ConnectionString { get; set; }
        private DbHelper(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private static DbHelper _helper;

        public static DbHelper CreateDbHelper(string connectionString)
        {

            if (_helper==null)
            {
                _helper = new DbHelper(connectionString);
            }
            return _helper;

        }

        public string StateMessage { get; set; }
    }
}
