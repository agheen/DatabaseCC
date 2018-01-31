using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCC
{
    public class DbCommand
    {
        public void Execute(DbConnection connection, string instruction)
        {
            DbConnection _connection = connection;

            if (string.IsNullOrWhiteSpace(instruction))
                throw new InvalidOperationException("Instruction is null or whitespace");

            _connection.Open();
            Console.WriteLine("Running Instruction: " + instruction);
            _connection.Close();
        }

    }
}
