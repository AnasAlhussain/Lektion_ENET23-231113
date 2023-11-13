namespace Lektion_ENET23_231113
{

    public interface ICal 
    {

    }
    public struct Student : ICal
    {
        private int _id;
        private string _name;
        
        public int ID { get => _id; set => _id = value; }
        public string Name { get=> _name; set => _name = value; }


        public Student(int Id, string name)
        {
            this._id = Id;
            this._name = name;
        }

        
        public void PrintData()
        {
            Console.WriteLine("ID = {0} , Name = {1}", this._id, this._name);
        }
    }

    public delegate void HeeloDelegate(string Mess);

    public delegate bool FilterDelegate(Person p);
    internal class Program
    {
        
        static void Main(string[] args)
        {

            //HeeloDelegate del = new HeeloDelegate(Hello);
            //del("Hello World form Delegate");


            Person p1 = new Person() { Name = "Reidar", Age = 65 };
            Person p2 = new Person() { Name = "Tobias", Age = 25 };
            Person p3 = new Person() { Name = "Aldor", Age = 15 };
            Person p4 = new Person() { Name = "Anas", Age = 12 };

            List<Person> people = new List<Person>() { p1,p2, p3, p4 };


            DisplayPeople("Children", people, IsChild);
            DisplayPeople("Adults", people, IsAdult);
            DisplayPeople("Senior", people, IsSenior);

            Console.ReadKey();
        }

        static void DisplayPeople(string title,List<Person> people,FilterDelegate filter)
        {
            Console.WriteLine(title);
            foreach (Person person in people)
            {
                if (filter(person))
                {
                    Console.WriteLine("{0}, {1} years old", person.Name, person.Age);
                }
            }
        }

        //Filters 
        public static bool IsChild(Person p)
        {
            return p.Age < 18;
        }
        public static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }
        public static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }




        public static void Hello(string strMessage)
        {
            Console.Write(strMessage);
        }
    }
}