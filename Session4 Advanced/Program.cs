namespace Session4_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary
            //dictionary : key value pairs
            //keys must be unique -> GetHashCode
            KeyValuePair<string, int>[] keyvaluepair = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("Ahmed",20),
                new KeyValuePair<string, int>("Mohamed",30),
                new KeyValuePair<string, int>("Malek",40)
            };

            Dictionary<string, int> note = new Dictionary<string, int>(keyvaluepair);
            //{
            //    {"Ahmed",1 },
            //    {"Omar",2 },
            //    {"Ali",3 }
            //};
            ////
            if (!note.ContainsKey("Amir"))
                note.Add("Amir", 4);
            else Console.WriteLine("Amir already found");
            /////
            bool res1 = note.TryAdd("Amir", 4);
            /////
            if (note.ContainsKey("AmirAli"))
                Console.WriteLine(note["AmirAli"]);
            /////
            bool res2 = note.TryGetValue("Amir", out int value);
            Console.WriteLine($"Try Result : {res2}, Retreived Value : {value}");
            /////
            foreach(var item in note)
            {
                Console.WriteLine($"Key : {item.Key}, Value : {item.Value}");
            }
            Console.WriteLine();
            foreach(var item in note.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach(var item in note.Values)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region HashSet
            HashSet<int> set = new HashSet<int>();
            set.Add(1); //1
            set.Add(2); //2
            set.Add(3); //3
            set.Add(4); //4
            set.Add(4); //4 wasnt added
            foreach(var item in set)
            {
                Console.WriteLine(item);
            }
            ///////
            HashSet<Movie> movies = new HashSet<Movie>()
            {
                new Movie(1,"hhh",30),
                new Movie(2,"ggg",40),
                new Movie(3,"aaa",50)
            };
            movies.Add(new Movie(2, "ggg", 40));
            foreach (var item in movies)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
