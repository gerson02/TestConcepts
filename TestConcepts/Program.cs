using System;
using System.Threading;
using System.Threading.Tasks;


namespace TestConcepts
{
    class Program
    {
        delegate int CalculateScore(int seconds, int targets);
        delegate void ShowStatus();

        static async Task Main(string[] args)
        {

            #region MultiCasting
            Scoreboard board = new Scoreboard();

            ShowStatus points = new ShowStatus(board.PointsAwarded);
            ShowStatus hit = new ShowStatus(board.TargetHit);
            ShowStatus another = new ShowStatus(board.AnotherMethodAdded);

            ShowStatus display = points;

            //Using the compound assignment operator the second delegate is added to the 
            //invocation chain so that when display is called, both of the underlying 
            //methods are executed.

            display += hit;
            display += another;
            display += () => Console.WriteLine("And this is a lamda method added to invocation chain");

            display();
            #endregion

            #region Delegate
            CalculateScore getScore;
            int time = 60;
            int targets = 20;

            // Puedo pasar al delegado el metodo en cuestion
            //getScore = new CalculateScore(CalculateAdultScore);

            // o puedo igualar el delegado a una lambda (arrow function)
            //getScore = (seconds, targets1) => { return (targets1 * 10) - (seconds * 2); };
            //Console.WriteLine("Adult score: {0}", getScore(time, targets));

            ////getScore = new CalculateScore(CalculateChildScore);

            //getScore = (seconds, targets1) => { return (targets * 15) - seconds;};
            //Console.WriteLine("Child score: {0}", getScore(time, targets));
            #endregion

            //Timer tm = new Timer(TimerCallback,null,0,3000);


            //int x = await AsyncDemo.SomeMethod(10);

            //Console.WriteLine("sync value {0}", x);



            //Console.ReadLine();





            //List<Customer> list = new List<Customer>() 
            //{
            //    new Customer {Name = "Bob", Type="Direct"},
            //    new Customer {Name = "Jhon", Type="Direct"},
            //    new Customer {Name = "Joseph", Type="Indirect"},
            //    new Customer {Name = "Mary", Type="Indirect"},

            //};

            //var filteredElement = list.RunCustomWhere(p => p.Type == "Direct").ToList();

            //filteredElement.ForEach(c => Console.WriteLine(c.Name));

            //Console.Write(filteredElement);

        }

        private static void TimerCallback(Object o)
        {
            //AsyncDemo.SomeMethod(10).ContinueWith((Task<int> value) => Console.WriteLine("ASYNC VALUE {0}", value.Result));

            Console.WriteLine("sync value {0}", 20);
            Console.WriteLine("sync value {0}", 30);
            Console.WriteLine("sync value {0}", 40);
            Console.WriteLine("sync value {0}", 50);
            Console.WriteLine("sync value {0}", 60);
            Console.WriteLine("sync value {0}", 70);
            Console.WriteLine("sync value {0}", 80);
            Console.WriteLine("sync value {0}", 90);


            GC.Collect();
        }

        // 10 points per target, -2 point per second
        public static int CalculateAdultScore(int seconds, int targets)
        {
            return (targets * 10) - (seconds * 2);
        }

        // 15 points per target, -1 point per second
        public static int CalculateChildScore(int seconds, int targets)
        {
            return (targets * 15) - seconds;
        }

       



    }
    class Customer
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
