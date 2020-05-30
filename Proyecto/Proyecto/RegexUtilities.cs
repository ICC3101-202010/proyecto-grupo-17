using System;
using System.Globalization;
using System.Text.RegularExpressions;

public class RegexUtilities
{
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
        catch (RegexMatchTimeoutException e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
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