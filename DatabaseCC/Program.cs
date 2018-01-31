using System;

namespace DatabaseCC
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection1 = new SqlConnection("ZEBRA-ROAD");
            var connection2 = new OracleConnection("COBRA-ALLEY");

            var instruction = "Say Hello to the Database";

            var command = new DbCommand();
            command.Execute(connection1, instruction);
            command.Execute(connection2, instruction);
            
        }
    }
}
