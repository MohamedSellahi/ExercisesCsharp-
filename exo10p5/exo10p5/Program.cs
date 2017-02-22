﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace exo10p5 {
  class Program {
    static void Main(string[] args) {

      
      //string filePath = @"C:\Users\34011-36-05\Documents\Visual Studio 2015\Projects\exo10p5\repertoire.txt";
      string filePath = @"C:\Users\Mohamed\Documents\Visual Studio 2015\Projects\ExercisesCsharp-\exo10p5\repertoire.txt"; 
      ContactProperties props;
      props.maxNameLen = 16;
      props.maxTelLen = 13;
      props.maxMailLen = 30;

      string UserInput;
      char delimiter = ' ';
      int nContacts = 0;

      List<Contact> Carnet = new List<Contact>();

      // open file for reading: copy contacts to RAM;
      using(StreamReader sr = File.OpenText(filePath)) {
        string tmp;
        //string[] tockens = new string[3];

        while((tmp = sr.ReadLine())!=null) { // read contacts: we suppose constant width fields 
                                             // TODO discard empty lines 

          Contact entry;
          if(string.IsNullOrWhiteSpace(tmp)) { // discard white spaces
            Console.WriteLine("Contact vide détecté");
          }
          else if(tmp.Length != props.maxMailLen + 
                                props.maxNameLen +
                                props.maxTelLen) {// contact not in correct format
            Console.WriteLine("format entry corrumpu");// TODO: proposer correction
          }
          else {
            entry.Nom = tmp.Substring(0, props.maxNameLen);
            entry.NumTel = tmp.Substring(props.maxNameLen, props.maxTelLen);
            entry.Mail = tmp.Substring(props.maxNameLen + props.maxTelLen);

            Carnet.Add(entry);
            ++nContacts;  // maybe not necessary 
          }
        
        }

      }

      /* modification du carnet */

      bool Ongoing = true;
      while(Ongoing) {
        //Console.Clear();
        Console.WriteLine("Veuiller entrer une operation: ");
        Console.WriteLine("a- Ajouter contact\n"+
                          "e- Editer contact\n"+
                          "s- Supprimer contact\n"+
                          "p- Afficher info contact\n"+
                          "d- Afficher tous les contacts\n"+
                          "c- Clear\n"+
                          "q- Quitter\n");

        UserInput = Console.ReadLine();  // TODO try catch ? 
        switch(UserInput) {
          case "a":
          case "A":
            AddContacts(Carnet, props);
            break;
          case "e":
          case "E":
            EditContacts(Carnet, props);
            break;
          case "s":
          case "S":
            DeleteContacts(Carnet, props);
            break;
          case "p":
          case "P":
            PrintContactsWrapper(Carnet, props);
            break;
          case "d":
          case "D":
            PrintAllContacts(Carnet);
            break; 
          case "q":
          case "Q":
            // quit 
            Ongoing = false;
            break;
          case "c":
          case "C":
            Console.Clear();
            break;
            
          default:
            PrintError("Entrée fause");
            break;
        }
      }// end while ongoing 

      /****** save all contacts *****/
      using(StreamWriter sw = File.CreateText(filePath)) {
        foreach(var item in Carnet) {
          sw.WriteLine("{0}{1}{2}", item.Nom, item.NumTel, item.Mail);
        }



      }
      
      
       





    }// end Main 







    public struct Contact {
      public string Nom;
      public string NumTel;
      public string Mail;
    };

    public struct ContactProperties {
      public int maxNameLen;
      public int maxTelLen;
      public int maxMailLen;
    };


    /******* functions *****/

    // add contacts wrapper  
    public static void AddContacts(List<Contact> carnet, ContactProperties props) {

      Console.Write("Entrer le nom de contact: ");
      string tmpName = Console.ReadLine();    // TODO : try catch

      tmpName = TrimInput(ref tmpName, props.maxNameLen);
      int index = ContactExists(carnet, tmpName); 
      if(index > -1) { // contact exists: suggest edition
        Console.WriteLine("le contact {0} exist déjà: Voulez vous l'éditer (O/N)? ");
        string choice;
        choice = Console.ReadLine();
        if(choice == "O") { // proceed to edit
          EditContact(carnet, tmpName, index, props); 

        }
        else { // contact does not exist: we dojn't want to edit : return 
          return; 
        }
      }
      else { // contact doenot exist : add

        AddContact(carnet, tmpName, props); 
      }

    }

    // add a contact; preserving the oredred list 

      public static void AddContact(List<Contact> carnet, string name, ContactProperties props) {

      Contact tmpContact;
      tmpContact.Nom = name;

      Console.WriteLine("Entrer le numéro de téléphone: ");
      string strTmp = Console.ReadLine();  // TODO : try catch
      strTmp = TrimInput(ref strTmp, props.maxTelLen);
      tmpContact.NumTel = strTmp;

      Console.WriteLine("Entrer le mail: ");
      strTmp = Console.ReadLine();
      strTmp = TrimInput(ref strTmp, props.maxMailLen);
      tmpContact.Mail = strTmp;

      // insert the contact

      int pos = 0;
      int initialSize = carnet.Count();  // TODO : maybe not necessary 
      while(pos < initialSize && string.Compare(carnet[pos].Nom, name)< 0) {
        ++pos; 
      }

      // insert contact 
      carnet.Insert(pos, tmpContact);
      PrintSuccess("Contact ajouté avec succes.");
          
      
    }






    // delete contacts wrapper :
    public static void DeleteContacts(List<Contact> carnet, ContactProperties props) {

      if(carnet.Count == 0) {
        Console.WriteLine(" le répertoire est vide");
        return; 
      }

      Console.WriteLine("Entrer le nom de contact à supprimer: ");
      string tmpName = Console.ReadLine(); // TODO try catch

      tmpName = TrimInput(ref tmpName, props.maxNameLen); 
      int index = ContactExists(carnet, tmpName); 

      if(index > -1) { // contact exists: proceed to delete
        //DeleteContact(carnet, index);
        carnet.Remove(carnet[index]);   //
      }
      else {
        Console.WriteLine(" Contact introuvable !"); 
      }

    }


    public static void DeleteContact(List<Contact> carnet, int index) {
      
    }

    // edit contact / contacts 

      // function to promp the user for edit contact  
      public static void EditContacts(List<Contact> carnet, ContactProperties props) {
      Console.WriteLine("Quelle est le nom du contact à editer: ");
      string tmpName = Console.ReadLine(); // todo try catch
      tmpName = TrimInput(ref tmpName, props.maxNameLen); 
      int index = ContactExists(carnet, tmpName);

      if(index > -1) { // contact exists proceed to edit 
        EditContact(carnet, tmpName, index, props);
      }
      else {
        Console.WriteLine("Contact n'exist pas: voulez vous l'ajouter (O/N): ");
        string choice = Console.ReadLine();
        if(choice == "O") { // proceed to add
          AddContact(carnet, tmpName, props);
        }
        else {
          return; 
        }

      }

    }

    public static void EditContact(List<Contact> carnet,string name, int index, ContactProperties props) {
      PrintContactInfo(carnet[index]);
      Contact tmpContact;
      string userInput;

      tmpContact.Nom = name;  
      Console.WriteLine("Entrer le numéro de téléphone (p pour passer): ");
      userInput = Console.ReadLine(); // TODO try catch
      if(userInput!= "p") {
        tmpContact.NumTel = TrimInput(ref userInput, props.maxTelLen);
      }
      else { // keep it as it is 
        tmpContact.NumTel = carnet[index].NumTel; 
      }
      
      Console.WriteLine("Entrer l'émail (p pour passer): "); // TODO try catch 
      userInput = Console.ReadLine();
      if(userInput != "p") {
        tmpContact.Mail = TrimInput(ref userInput, props.maxMailLen);
      }
      else {
        tmpContact.Mail = carnet[index].Mail; 
      }     
        
      carnet[index] = tmpContact; 
    }


    // teste if contact exists: function returns index of contact, otherwise -1; 
    // no need : 
    public static int ContactExists(List<Contact> carnet, string name) { // TODO : enhance function: get rid of if(count) if possible.

      if(carnet.Count == 0) { // directory empty 
        return -1;
      }

      int pos = 0;
      int initialSize = carnet.Count();  // TODO : maybe not necessary 
      while(pos < initialSize) {

        if(string.Compare(carnet[pos].Nom, name) == 0) { // found : return pos
          return pos;
        }
        ++pos;
      }

      if(pos < initialSize) {// not found
        return pos;
      }
      else {
        return -1;
      }

    }


    /*  truncates input if input length is greater than size allocated for,
     *  or pads with spaces if length is less than size 
     */
    public static string TrimInput(ref string str, int MaxLen) {

      if(str.Length >= MaxLen) {
        str = str.Substring(0, MaxLen);
      }
      else {
        str = str.PadRight(MaxLen);
      }
      return str;
    }

    // print contacts/ contact 
    // printContact wrapper 

      public static void PrintContactsWrapper(List<Contact> carnet, ContactProperties props) {

      if(carnet.Count == 0) { // empty directory : 
        PrintError("Carnet d'address vide");
        return; 
      }

      Console.WriteLine("Entrer le nom du contact à afficher: ");
      string tmpName = Console.ReadLine(); // TODO : try catch 
      tmpName = TrimInput(ref tmpName, props.maxNameLen);
      int index = ContactExists(carnet, tmpName);

      if(index > -1) { // contact exists 
        PrintContactInfo(carnet[index]);
      }
      else {
        PrintError("Contact non trouvé"); 
      }
    }

    // print all contacts 
    public static void PrintAllContacts(List<Contact> carnet){
      if(carnet.Count == 0) {
        PrintError("Carnet d'address vide");
        return; 
      }

      int pos = 0;
      Console.WriteLine('\n');
      Console.WriteLine("-----------------------------------------------------------+");
      Console.WriteLine("Nom             Tel          Mail                          |");
      Console.WriteLine("-----------------------------------------------------------+");
      while(pos < carnet.Count) {
        Console.WriteLine("{0}{1}{2}", carnet[pos].Nom
                                     , carnet[pos].NumTel
                                     , carnet[pos].Mail);
        ++pos; 
      }
      Console.WriteLine();
      Console.WriteLine("-----------------------------------------------------------");
      Console.WriteLine();
    }




    public static void PrintContactInfo(Contact c) {
      
      Console.WriteLine("Nom             Tel          Mail");
      Console.WriteLine("---------------------------------------------");
      Console.WriteLine("{0}{1}{2}", c.Nom, c.NumTel, c.Mail);
      Console.WriteLine("\n");
    }



    // print error message

    static public void PrintError(string message) {
      Console.WriteLine("Erreur: " + message);
    }

    // print success message
    static public void PrintSuccess(string message) {
      Console.WriteLine(message);
    }


  }
}