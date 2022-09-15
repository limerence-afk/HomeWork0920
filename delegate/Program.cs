
/*public class Program
{
    static void Main(string[] args)
    {
        var users = new List<User>() { 
            new User() { Age = 21, Name = "Maxim", Surname = "Bogdan" },
            new User() { Age = 25, Name = "Iurie", Surname = "Cozlenco" },
            new User() { Age = 40, Name = "Ioc", Surname = "Ceban" } 
        };

        var temp = users.Select(t => new
        {
            Name = t.Name,
            Age = t.Age
        });

    }
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }



}*/



delegate void FirstDeleg(string str);

public class Program
{
    static void Main(string[] args)
    {
        var firstDeleg = delegate (string str) { return 1; };
        var strlngt = StringLength("xdddd");

        Console.WriteLine(strlngt);


    }

    static int StringLength(string str)
    {
        return str.Length;
    }

    delegate int LengthDeleg(string str);
}

