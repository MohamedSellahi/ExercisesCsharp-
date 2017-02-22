using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo9p9 {
  class Program {
    static void Main(string[] args) {

      int sizeAlphabet = 26;
      char[,] alphabetTable = new char[sizeAlphabet, sizeAlphabet];

      /* génération des alphabets */
      int i = 0;
      int j = 0;
      char startChar = 'A', curChar = startChar;

      for(i = 0; i < sizeAlphabet; i++) {
        for(j = 0; j < sizeAlphabet; j++) {
          curChar = (char)(startChar + j);
          if(curChar > 90) {
            curChar = (char)(curChar - 26);
          }
          alphabetTable[i, j] = curChar;
        }
        startChar = (char)(startChar + 1);
      }

      /* imprimer alphabet is besoin */
      
      for(i = 0; i < 26; i++) {
        for(j = 0; j < 26; j++) {
          Console.Write(alphabetTable[i,j]);
        }
        Console.WriteLine();
      }
      

      Console.Write("Entrer message a crypter: ");
      string message = Console.ReadLine();  // message d'origin
      char[] msgChar = new char[message.Length]; // tableau des characters du message 
      

      /* recuperation des characters de message sous forme de tableau */
      for(i = 0; i< message.Length; i++) {
        msgChar[i] = toUpperChar(message[i]);
      }

      Console.WriteLine(msgChar);

      /* recuperation de la clef */
      Console.Write("Entrer la clef utilsée pour le cryptage: ");
      string strClef = Console.ReadLine();
      char[] charClef = new char[strClef.Length];
      for(i = 0; i < strClef.Length; i++) {
        charClef[i] = toUpperChar(strClef[i]);
      }

      Console.WriteLine(charClef);


      /*  */

      int posCharMessage = 0;      // position de la lettre dans le message 
      int posCharClef = 0;  // position dans la clef: ça sert à recuperer l'alphabet à utilisé
      int posAlphabet = 0;  // index de l'alphabet à utiliser dans le tableaux des alphabets  

      for(i = 0; i < message.Length; i++){

        posCharMessage = msgChar[i] - 'A';

        if(isLetter(msgChar[i])) {
          posAlphabet = charClef[posCharClef] - 'A';
          ++posCharClef;

          if(posCharClef > strClef.Length - 1) { // on revient sur la première lettre si depasse la
            posCharClef = 0;                     // longueur de la clef
          }
          msgChar[i] = alphabetTable[posAlphabet, posCharMessage];
        }        


      }

      string msgCrypted = new string(msgChar);
      Console.WriteLine("message original: {0} ", message);
      Console.WriteLine("clef de cyptage : {0} ", strClef);
      Console.WriteLine("message crypté  : {0} ", msgCrypted);

    }

    static char toUpperChar(char c) {
      if(c > 96 && c < 123) {// valid miniscule 
        return (char)(c - 32);
      }
      else {// ne rien faire 
        return c; 
      }
    }

    static bool isLetter(char c) {

      if((c < 91 && c > 64 ) || (c < 123 && c > 96)) { // une lettre 
        return true;
      }
      return false; 
    }

  }
}
