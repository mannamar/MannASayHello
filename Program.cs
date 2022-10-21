// Amardeep Mann
// 10-18-22
// Mini Challenge #1 - "What is your name?"
// Project that will ask user their name and output it back to the console
// Peer Reviewed by : Madeline Gowan
// I liked the personality in the greeting. I read it in an accent too lol. Although I don't know what "blessed be the fruit" means
// Github link: https://github.com/peedrama/MannASayHello


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