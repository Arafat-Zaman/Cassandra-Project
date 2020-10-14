using System;
using Cassandra;

namespace Cassandraproject
{
    class Program
    {
        static void Main(string[] args)
        {
            var cluster = Cluster.Builder()
                .AddContactPoint("127.0.0.1")
                .Build();

            var session = cluster.Connect("test_keyspace");

            session.Execute("INSERT INTO test_table(id, first_name, last_name) VALUES (uuid(),'Jim','kary')");

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
