using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = new string[]
      {
        "C# is a statically typed language (true/false)",
        "C# is an object-oriented language (true/false)",
        "C# supports multiple inheritance (true/false)"
      };
      bool[] answers = new bool[] {true, true, false};
      bool[] responses = new bool[questions.Length];
      if (questions.Length != answers.Length)
      {
        Console.WriteLine("The number of questions and answers do not match.");
      }
        int askingIndex = 0;
        foreach (string question in questions)
        {
          string input;
          bool isBool;
          bool inputBool;
          Console.WriteLine(question);
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
          while (!isBool)
          {
            Console.WriteLine("Please respond with 'true' or 'false'.");
            input = Console.ReadLine();
            isBool = Boolean.TryParse(input, out inputBool);
          }
          responses[askingIndex] = inputBool;
          askingIndex++;
        }
        int scoringIndex = 0;
        int score = 0;

        foreach (bool answer in answers)
        {
          bool response = responses[scoringIndex];
          Console.WriteLine($"Input: {response} | Answer: {answer}");
          if (response == answer)
          {
            score++;
          }
          scoringIndex++;
        }
        Console.WriteLine($"You got {score} out of {questions.Length} correct!");

    }
  }
}
