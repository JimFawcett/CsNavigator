///////////////////////////////////////////////////////////////////////
///  Test.cs    -  Demonstrates use of System.IO classes            ///
///  ver 1.0                                                        ///
///                                                                 ///
///  Language:     Visual C#                                        ///
///  Platform:     Dell Dimension 8100, Windows Pro 2000, SP2       ///
///  Application:  CSE681 Example                                   ///
///  Author:       Jim Fawcett, CST 2-187, Syracuse Univ.           ///
///                (315) 443-3948, jfawcett@twcny.rr.com            ///
///////////////////////////////////////////////////////////////////////
//
//  Operations:
// =============
//  This is a test driver for Navigate.  It simply extracts a path
//  from the command line and calls Navigate.go(path).

using System;
using System.IO;

namespace Navigate
{
  class Test
  {
    [STAThread]
    static void Main(string[] args)
    {
      Console.Write("\n  Demonstrate System.IO Classes ");
      Console.Write("\n ===============================");

      string path;
      if(args.Length > 0)
        path = args[0];
      else
        path = Directory.GetCurrentDirectory();
      Navigate.go(path, "*.*");

      Console.Write("\n\n");
    }
  }
}
