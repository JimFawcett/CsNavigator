///////////////////////////////////////////////////////////////////////
///  Navigate.cs - Navigates a Directory Subtree, displaying files  ///
///  ver 1.2       and some of their properties                     ///
///                                                                 ///
///  Language:     Visual C#                                        ///
///  Platform:     Dell Dimension 8100, Windows Pro 2000, SP2       ///
///  Application:  CSE681 Example                                   ///
///  Author:       Jim Fawcett, CST 2-187, Syracuse Univ.           ///
///                (315) 443-3948, jfawcett@twcny.rr.com            ///
///////////////////////////////////////////////////////////////////////
/*
 *  Module Operations:
 *  ==================
 *  Recursively displays the contents of a directory tree
 *  rooted at a specified path, with specified file pattern.
 *
 *  Public Interface:
 *  =================
 *  Navigate nav = new Navigate();
 *  nav.go("c:\temp","*.cs");
 * 
 *  Maintenance History:
 *  ====================
 *  ver 1.2 : 10 Sep 11
 *  - removed unnecessary SetCurrentDirectory in Navigate.go()
 *  ver 1.1 : 04 Sep 06
 *  - added file pattern as argument to member function go()
 *  ver 1.0 : 05 Sep 05
 *  - first release
 */

using System;
using System.IO;

namespace Navigate
{
  public class Navigate
  {
    public static void go(string path, string pattern)
    {
      path = Path.GetFullPath(path);
      Console.Write("\n\n  {0}",path);

      // get all files in this directory and display them

      string [] files = Directory.GetFiles(path, pattern);
      foreach(string file in files)
      {
        string name = Path.GetFileName(file);
        FileInfo fi = new FileInfo(file);
        DateTime dt = File.GetLastWriteTime(file);
        Console.Write("\n   {0,-20} {1,8} bytes  {2}",name,fi.Length,dt);
      }
      // for each subdirectory in this directory display its files
      // recursively

      string[] dirs = Directory.GetDirectories(path);
      foreach(string dir in dirs)
        go(dir, pattern);
    }
  }
}
