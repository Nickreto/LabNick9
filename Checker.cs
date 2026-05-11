using WpfApp1;


namespace nickenv
{
    class Checker
    {
    public static double EnterDouble(String str)
    {
        double enteredDouble;
        Console.Write("Введите число:");
        if (double.TryParse(str, out enteredDouble))
            {
                return enteredDouble;
            }
        else
            {
                return 0;
            }
    }

    public static int EnterInt()
    {
        int enteredInt;
        Console.Write("Введите число:");
        while(!int.TryParse(Console.ReadLine(), out enteredInt))
        {
            Console.Write("Ввод некорректен, повторите ввод: ");
        }        
        Console.WriteLine(enteredInt);
        return enteredInt; 
    }

    public static char EnterChar()
    {
        char enteredChar;
        Console.Write("Введите число:");
        while(!char.TryParse(Console.ReadLine(), out enteredChar))
        {
            Console.Write("Ввод некорректен, повторите ввод: ");
        }        
        Console.WriteLine(enteredChar);
        return enteredChar; 
    }

    }
}