using System;

class Program
{
    static void Main()
    {
      

        /*int value;
        string inp = Console.ReadLine();
        if (int.TryParse(inp, out value)) ;



        int i = 0;*/
        while (true)
        {
            var input = Console.ReadLine();
            if(input == "")
            {
                break;
            }
            Excersise7.MyTryParse(input);
            
        }


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
