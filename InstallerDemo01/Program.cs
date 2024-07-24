// See https://aka.ms/new-console-template for more information
string name = string.Empty;
bool isReset = true;
char userInp = '\0';
while (isReset)
{
    try
    {
        if (userInp == '\0')
        {
            Console.WriteLine("=========Enter any value======");
            name = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("=========You entered========");
            Console.WriteLine(name);
        }
        Console.WriteLine("========Want to try again, press (y for yes / n for no)======");
        userInp = Convert.ToChar(Console.ReadLine() ?? string.Empty);
        if (userInp == 'y')
        {
            userInp = '\0';
            continue;
        }
        else if (userInp == 'n')
        {
            isReset = false;
            Console.WriteLine("=======Thanks for using our application========");
            Console.ReadKey();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        continue;
    }
}
