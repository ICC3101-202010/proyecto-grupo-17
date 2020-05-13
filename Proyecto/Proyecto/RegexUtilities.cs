using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

public class RegexUtilities
{

    public static int index = 0;
    public static bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        try
        {
            // Normalize the domain
            email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                  RegexOptions.None, TimeSpan.FromMilliseconds(200));

            // Examines the domain part of the email and normalizes it.
            string DomainMapper(Match match)
            {
                // Use IdnMapping class to convert Unicode domain names.
                var idn = new IdnMapping();

                // Pull out and process domain name (throws ArgumentException on invalid)
                var domainName = idn.GetAscii(match.Groups[2].Value);

                return match.Groups[1].Value + domainName;
            }
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
        catch (ArgumentException)
        {
            return false;
        }

        try
        {
            return Regex.IsMatch(email,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
    }

        public static string HidePassword()
        {

            string pass = "";
            while (true)
            {

            

            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
            {
                pass += key.KeyChar;
                Console.Write("•");
            }
            else
            {
                if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    pass = pass.Substring(0, (pass.Length - 1));
                    Console.Write("\b \b");
                }

                else if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
            }


            
        }
        return pass;


        }

        public static string WriteData(string dataName)
        {

            string data = "";
            while (true)
            {


                Console.Write(dataName + data);
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    data += key.KeyChar;
                    Console.Write(key.KeyChar);
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && data.Length > 0)
                    {
                        data = data.Substring(0, (data.Length - 1));
                        Console.Write("\b \b");
                    }

                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            Console.Clear();


            }

            dataName += data;
            return data;


        }

        public static string GetMenu(List<string> items)    //usar con while
        {
            if (index > items.Count) { index = 0; }
            for (int i = 0; i < items.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine(items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == items.Count - 1)
                {
                    //index = 0; //Remove the comment to return to the topmost item in the list
                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    //index = menuItem.Count - 1; //Remove the comment to return to the item in the bottom of the list
                }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                int selected = index;
                index = 0;
                return items[selected];
                
            }
            else
            {
                Console.Clear();
                return "";
            }

            Console.Clear();
                
            return "";
        }
}


    



/*
string pass = "";
do
{
    ConsoleKeyInfo key = Console.ReadKey(true);
    // Backspace Should Not Work
    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
    {
        pass += key.KeyChar;
        Console.Write("*");
    }
    else
    {
        if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
        {
            pass = pass.Substring(0, (pass.Length - 1));
            Console.Write("\b \b");
        }
        else if(key.Key == ConsoleKey.Enter)
        {
            break;
        }
    }
} while (true);*/