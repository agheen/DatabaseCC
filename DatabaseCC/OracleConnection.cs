using System;


namespace DatabaseCC
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string str) : base(str)
        {

        }

        public override void Open()
        {
            Console.WriteLine("Oracle: Opening Connection to " + ConnectionString);
        }

        public override void Close()
        {
            Console.WriteLine("Oracle: Closing Connection to " + ConnectionString);
        }
    }
}
