using System;

  namespace TreeHouse.FitnessFrog
  {
          class Program
              {
                  static void Main()
                    {
                      int runningTotal = 0;
                      bool keepGoing = true;

                            while(keepGoing)
                            {
                                      //Prompt the user for minutes exercises
                                        Console.Write("Enter How Many you Exercised");

                                        string entry = System.Console.ReadLine();

                                        int minutes = int.Parse(entry);//Here you transform a string into an int value
                                        runningTotal = runningTotal + minutes; //Add minutes exercised to total

                                        //Display total minutes exercised to the screen
                                     Console.WriteLine("You've entered " +runningTotal + " minutes");

                                    //repeat until the user quits
                                  }//End the while loop


                                  
                        }//End the class





}//End the namespace
