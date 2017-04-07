using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod {
  class Car {
    // internal state data
    public int CurrentSpeed { get; set; }
    public int MaxSpeed { get; set; }
    public string PetName { get; set; }

    // is the car alive or dead 
    private bool CarIsDead;

    // Constructors 
    public Car() {
      MaxSpeed = 100;
    }
    public Car(string name, int maxSpeed, int currSpeed) {
      PetName = name;
      MaxSpeed = maxSpeed;
      CurrentSpeed = currSpeed;
    }

    // defining the delegate that holds methods to be called 
    // in relation with the engine health
    // this delegate works in conjunction with the Cars events 
    // using generic event handler 

    public event EventHandler<CarEventArgs> Exploaded;
    public event EventHandler<CarEventArgs> AboutToBlow;

    public void Accelerate(int delta) {
      // if car is dead, fire exploided event ; 
      if (CarIsDead) {
        if (Exploaded != null) {
          Exploaded(this, new CarEventArgs("Sorry this car is dead..."));
        }
      }
      else {
        CurrentSpeed += delta;
        // Almost dead ?
        if (MaxSpeed - CurrentSpeed <= 50 && AboutToBlow != null) {
          AboutToBlow(this, new CarEventArgs("Carefully buddy! Gonna blow!"));
        }

        // still ok 
        if (CurrentSpeed >= MaxSpeed)
          CarIsDead = true;
        else
          Console.WriteLine("Current speed = {0}", CurrentSpeed);

      }
    }

    public override string ToString() {
      return String.Format("{0}", PetName);
    }



  }
}
