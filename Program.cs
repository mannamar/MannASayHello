// Amardeep Mann
// 09-13-2022
// Challenge #0 - MC#1 "What is your name?"
// Project that will ask user their name and output it back to the console
// Ch#0 Peer Review by: Lerissa Lazar, I like how enthusiastic you sound in all your outputs, everything worked well and smoothly. Great job!

Console.Clear();

Console.WriteLine("Welcome!\n");

bool playAgain = true;

while (playAgain) {
  Console.WriteLine("What is your name? (Type \"exit\" to quit)");

  string userName = Console.ReadLine().ToLower();

  if (userName == "exit") {
    playAgain =false;
  } else {
    Console.WriteLine("\nTop of the morning, " + userName + ". Have a corntastic day!\n");
  }
}