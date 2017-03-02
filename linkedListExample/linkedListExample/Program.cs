using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedListExample {
  class Program {
    static void Main(string[] args) {
      // create a linked list 
      string[] words = { "the", "fox", "jumped", "over", "the", "dog" };
      LinkedList<string> sentense = new LinkedList<string>(words);
      Display(sentense, "The linked list values: ");
      Console.WriteLine("sentence.Contains(\"jumped\") = {0}\n", sentense.Contains("jumped"));

      // add to the beginning 
      sentense.AddFirst("Today");
      Display(sentense, "Test 1: Add 'today' to beginning of the list: ");

      // Move the first node to be the last node 
      LinkedListNode<string> mark1 = sentense.First;
      sentense.RemoveFirst();
      sentense.AddLast(mark1);
      Display(sentense, "Test 2: Move first node to be last node:");

      // Change the last node to yesterday
      sentense.RemoveLast();
      sentense.AddLast("yesterday");
      Display(sentense, "Test 3: Change the last node to 'yesterday':");

      // Move the last node to the fist node
      mark1 = sentense.Last;
      sentense.RemoveLast();
      sentense.AddFirst(mark1);
      Display(sentense, "Test 4: Move last node to be first node:");

      //indicate the last appearence of "the"
      sentense.RemoveFirst();
      LinkedListNode<string> current = sentense.FindLast("the");
      IndicateNode(current, "Test 5: Indicate last occurence of 'the':");

      // Add 'lazy' and 'old' after 'the' 
      sentense.AddAfter(current, "old");
      sentense.AddAfter(current, "lazy");
      IndicateNode(current, "Test 6: Add 'lazy' and 'old' after 'the':");

      // indicat fox 
      current = sentense.Find("fox");
      IndicateNode(current, "Test 7: Indicate the 'fox' node: ");












    }// end main 

    public static void IndicateNode(LinkedListNode<string> node, string test) {
      Console.WriteLine(test);
      if(node.List == null) {
        Console.WriteLine("Node '{0}' is not in the list.\n",
            node.Value);
        return;
      }

      StringBuilder result = new StringBuilder("(" + node.Value + ")");
      LinkedListNode<string> nodeP = node.Previous;

      while(nodeP != null) {
        result.Insert(0, nodeP.Value + " ");
        nodeP = nodeP.Previous;
      }

      node = node.Next;
      while(node != null) {
        result.Append(" " + node.Value);
        node = node.Next;
      }

      Console.WriteLine(result);
      Console.WriteLine();
    }


    // Display list 
    public static void Display(LinkedList<string> words, string test) {
      Console.WriteLine(test);
      foreach(string word in words) {
        Console.Write(word + " ");
      }
      Console.WriteLine();
      Console.WriteLine();
    }

  }// end Program
}// end namespace
