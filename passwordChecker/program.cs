/*
  Password Checker
  This program checks the strength of a password based on the following criteria:
  - A minimum length of 8 characters
  - Contains uppercase letters
  - Contains lowercase letters
  - Contains digits
  - Contains special characters
  The program will then output the strength of the password based on the number of criteria met.
*/

using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "!@#$%^&*()";

      Console.WriteLine("Please enter a password: ");
      string password = Console.ReadLine();

      int score = 0;

      if (password.Length >= minLength)
      {
        score++;
      }

      if (Tools.Contains(password, uppercase))
      {
        score++;
      }

      if (Tools.Contains(password, lowercase))
      {
        score++;
      }

      if (Tools.Contains(password, digits))
      {
        score++;
      }

      if (Tools.Contains(password, specialChars))
      {
        score++;
      }

      switch (score)
      {
        case 5:
        case 4:
          Console.WriteLine("The password is extremely strong.");
          break;
        case 3:
          Console.WriteLine("The password is strong.");
          break;
        case 2:
          Console.WriteLine("The password is medium.");
          break;
        case 1:
          Console.WriteLine("The password is weak.");
          break;
        default:
          Console.WriteLine("The password is extremely weak.");
          break;
      }
    }
  }
}