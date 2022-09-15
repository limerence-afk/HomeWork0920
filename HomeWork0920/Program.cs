
using System.Collections;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        var helper = new ConcatenationHelper();
        var personService = new PersonService(helper);
        var nameList = new List<Person>() {
            new Person { FirstName = "Maxim", LastName = "Bogdan", Id = 1, Age = 23 },
            new Person { FirstName = "Linus", LastName = "Torvald", Id = 2, Age = 40},
            new Person { FirstName = "Kurt", LastName = "Kobain", Id = 3, Age = 27 }
        };
        /*foreach (var n in nameList)
        {
            Console.WriteLine(personService.CheckName(n.FirstName));
            Console.WriteLine(personService.GetFullName(n));
        }*/

        int value;
        string inp = Console.ReadLine();
        if (int.TryParse(inp, out value)) ;
      


        int i = 0;
        while (i<=value)
        {
            var input = Console.ReadLine();
            Excersise7.MyTryParse(input);
            i++;
        }

  
    }

}

public class ConcatenationHelper
{
    public string MyConcatenation(string str1, string str2)
    {
        return str1 + " " + str2;
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int Id { get; set; }
}

public class PersonService
{

    private readonly ConcatenationHelper concatenationHelper;
    public PersonService(ConcatenationHelper concatenationHelper)
    {
        this.concatenationHelper = concatenationHelper;
    }



    public string GetFullName(Person person)
    {
        return concatenationHelper.MyConcatenation(person.FirstName, person.LastName);

    }

    public string GetFullNameLambda(Person person) => concatenationHelper.MyConcatenation(person.FirstName, person.LastName);

    public bool CheckName(string str)
    {
        bool isDigitPresent = str.Any(i => char.IsDigit(i));
        return !isDigitPresent;
    }
}

 public static class Excersise7
{
    public static void MyTryParse(string input)
    {
        int num;
        char ch;
        string str;
        bool bl;
        double dbl;
        if (int.TryParse(input, out num))
        {
            Console.WriteLine(num.GetType());
        }
        else if (char.TryParse(input, out ch))
        {
            Console.WriteLine(ch.GetType());
        }
        else if (bool.TryParse(input.ToUpper(), out bl))
        {
            Console.WriteLine(bl.GetType());
        }
        else if (double.TryParse(input, out dbl))
        {
            Console.WriteLine(dbl.GetType());
        }
        else
        {
            Console.WriteLine(input.GetType());
        }
    }
}


