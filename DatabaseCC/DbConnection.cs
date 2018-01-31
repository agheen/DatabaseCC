using System;

namespace DatabaseCC
{
    public abstract class DbConnection
    {

        public DbConnection(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                throw new InvalidOperationException("Connection String is Null or Empty Space");

            ConnectionString = str;
            Timeout = new TimeSpan(0, 0, 15);
        }

        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public abstract void Open();
        public abstract void Close();

    }


}
