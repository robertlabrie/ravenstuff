using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raven.Client;
using Raven.Client.Connection;
using Raven.Client.Document;
namespace raven0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //connect to the datastore
            var documentStore = new DocumentStore { Url = "http://localhost:8080" };
            documentStore.Initialize();

            //connect to DB
            var session = documentStore.OpenSession("somedata");

            session.Store(new User { Id="users/bozo", Name="Bozo the clown"});
            session.SaveChanges();
        }
    }
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
