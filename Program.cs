// See https://aka.ms/new-console-template for more information
using System;

namespace DateTimeClass{
  class Time{
    static void Main(string[] args){
      DateTime Hello = DateTime.Now;
      Console.WriteLine(Hello.ToString("dddd,MMMM"));
    }
  }
}
