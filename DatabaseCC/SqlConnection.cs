using System;

namespace DatabaseCC
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string str) : base(str)
        {

        }

        public override void Open()
        {
            Console.WriteLine("SQL: Opening Connection to " + ConnectionString);
        }

        public override void Close()
        {
            Console.WriteLine("SQL: Closing Connection to " + ConnectionString);
        }
    }
}
