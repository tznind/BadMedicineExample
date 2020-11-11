using System;
using BadMedicine;
using BadMedicine.Datasets;
using System.Text;
using System.IO;

namespace BadMedicineExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var rand = new Random(500/*seed*/);

            var pc = new PersonCollection();
            
            // Generate 100 people
            pc.GeneratePeople(100,rand);

            // Generate a Biochemistry record
            var biochemRecord = new BiochemistryRecord(rand);

            //Get a random person from the collection
            var person = pc.People[rand.Next(pc.People.Length)];

            // Output some custom Xml format
            using(var writer = new StreamWriter("out.xml"))
            {
                writer.WriteLine("<Record>");
                
                writer.WriteLine($"<Date>{person.GetRandomDateDuringLifetime(rand)}</Date>");
                writer.WriteLine($"<SampleType>{biochemRecord.SampleType}</SampleType>");
                writer.WriteLine($"<TestCode>{biochemRecord.TestCode}</TestCode>");
                writer.WriteLine($"<Result>{biochemRecord.Result}</Result>");
                writer.WriteLine($"<Identifier>{biochemRecord.LabNumber}</Identifier>");
                writer.WriteLine($"<ReadCode>{biochemRecord.ReadCodeValue}</ReadCode>");
                
                writer.WriteLine("</Record>");

            }
        }
    }
}
