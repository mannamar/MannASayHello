// Amardeep Mann
// 10-18-22
// Mini Challenge #1 - "What is your name?"
// Project that will ask user their name and output it back to the console

Console.Clear();

Console.WriteLine("Welcome!\n");

bool playAgain = true;

while (playAgain) {
  Console.WriteLine("What is your name? (Type \"exit\" to quit)");

  string userName = Console.ReadLine();

  if (userName.ToLower() == "exit") {
    playAgain = false;
  } else {
    Console.WriteLine("\nTop of the day to you, " + userName + ". Blessed be the fruit!\n");
  }
}