﻿using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Build your own creature!");
      Console.WriteLine("Choose a mode: ");
      Console.WriteLine("1: Random mode");
      Console.WriteLine("2: Choose mode");
      int mode = Convert.ToInt32(Console.ReadLine());
      if (mode == 1)
      {
        BuildACreature();
      }
      else if (mode == 2)
      {
        Console.WriteLine("Choose a head: ghost, bug, or monster");
        string head1 = Console.ReadLine();
        Console.WriteLine("Choose a body: ghost, bug, or monster");
        string body1 = Console.ReadLine();
        Console.WriteLine("Choose feet: ghost, bug, or monster");
        string feet1 = Console.ReadLine();
        BuildACreature(head1, body1, feet1);
      }
      else
      {
        Console.WriteLine("Invalid mode");
      }
    }

    static void BuildACreature(string head, string body, string feet)
    {
      int headNum = TranslateToNumber(head);
      int bodyNum = TranslateToNumber(body);
      int feetNum = TranslateToNumber(feet);

      SwitchCase(headNum, bodyNum, feetNum);
    }

    static void BuildACreature()
    {
      RandomMode();
    }

    static void SwitchCase(int head, int body, int feet)
    {
      switch (head)
      {
        case 1:
          GhostHead();
          break;
        case 2:
          BugHead();
          break;
        case 3:
          MonsterHead();
          break;
        default:
          Console.WriteLine("Invalid creature part");
          break;
      }

      switch (body)
      {
        case 1:
          GhostBody();
          break;
        case 2:
          BugBody();
          break;
        case 3:
          MonsterBody();
          break;
        default:
          Console.WriteLine("Invalid creature part");
          break;
      }

      switch (feet)
      {
        case 1:
          GhostFeet();
          break;
        case 2:
          BugFeet();
          break;
        case 3:
          MonsterFeet();
          break;
        default:
          Console.WriteLine("Invalid creature part");
          break;
      }
    }

    static int TranslateToNumber(string creature)
    {
      switch (creature)
      {
        case "ghost":
          return 1;
        case "bug":
          return 2;
        case "monster":
          return 3;
        default:
          return 1;
      }
    }

    static void RandomMode()
    {
      Random randomNumber = new Random();
      int head = randomNumber.Next(1, 4);
      int body = randomNumber.Next(1, 4);
      int feet = randomNumber.Next(1, 4);

      SwitchCase(head, body, feet);
    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
