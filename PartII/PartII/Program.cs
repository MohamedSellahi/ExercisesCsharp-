using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartII {
  class Program {
    static void Main(string[] args) {

      // the params modifier 
      double average;
      average = calculateAverage(4.0, 3.2, 5.7);
      Console.WriteLine("Average of data = {0}", average);

      double[] arr = { 4.0, 3.2, 5.7 };
      average = calculateAverage(4.0, 3.2, 5.7);
      Console.WriteLine("Average of data = {0}", average);

      // optional mthod arguments
      EnterLogData("Only message");
      EnterLogData("Message + Owner", "CFO");

      // named arguments 
      DisplayFancyMessage(message: "Wow very fancy indeed! ", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);
      DisplayFancyMessage(message: "hello");

      // 



    }// end of main

    static double calculateAverage(params double[] values) {
      Console.WriteLine("You sent me {0} doubles", values.Length);
      double sum = 0;
      if(values.Length == 0) {
        return 0;
      }

      for(int i = 0; i < values.Length; i++) {
        sum += values[i];
      }
      return (sum / values.Length); 
    }

    static void EnterLogData(string message, string owner = "Programmer") {
      Console.Beep();
      Console.WriteLine("Error: {0}", message);
      Console.WriteLine("Owner of Error: {0}", owner);
    }

    static void DisplayFancyMessage(ConsoleColor textColor = ConsoleColor.Blue, ConsoleColor backgroundColor = ConsoleColor.White, string message = "Test Message") {
      //store old colors
      ConsoleColor oldTextColor = Console.ForegroundColor;
      ConsoleColor oldBackgroundColor = Console.BackgroundColor;

      // set new color
      Console.ForegroundColor = textColor;
      Console.BackgroundColor = backgroundColor;

      // write message

      Console.WriteLine(message);

      // restore colors 
      Console.ForegroundColor = oldTextColor;
      Console.BackgroundColor = oldBackgroundColor;

    }

  }// end of class 
}// en of namespace
