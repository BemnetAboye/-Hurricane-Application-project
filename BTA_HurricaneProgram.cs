using System;
using static System.Console;
namespace Hurricane;

/*A program that determines a hurricane’s category based on the wind speed provided by the user.
 * 
 * Author:Bemnet Aboye
 * Date:9/14/2024
 */


public class Hurricane
{
    const int CATEGORY5HURRICAN = 157;
    const int CATEGORY4HURRICAN = 130;
    const int CATEGORY3HURRICAN = 111;
    const int CATEGORY2HURRICAN = 96;
    const int CATEGORY1HURRICAN = 74;

    public static void Main()
    {
        Write("Please input the hurricane’s wind speed: ");

        if (!int.TryParse(ReadLine(), out int speed))
        {
            WriteLine("Error: An invalid Number/Character has been entered.");
            return;
        }

        string resutl = ReturnHurricanCategory(speed);
        WriteLine($"A wind of speed {speed} mph is a {resutl}");

    }

    public static string ReturnHurricanCategory(int speed)
    {
        string result;

        if (speed >= CATEGORY5HURRICAN)
        {
            result = "Category 5 Hurrican";
        }
        else if (speed >= CATEGORY4HURRICAN)
        {
            result = "Category 4 Hurrican";
        }
        else if (speed >= CATEGORY3HURRICAN)
        {
            result = "Category 3 Hurrican";
        }
        else if (speed >= CATEGORY2HURRICAN)
        {
            result = "Category 2 Hurrican";
        }
        else if (speed >= CATEGORY1HURRICAN)
        {
            result = "Category 1 Hurrican";
        }
        else
        {
            result = "Not a Hurrican";
        }

        return result;
    }
}