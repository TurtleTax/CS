/**
Jonathan Brann
13 June 2017

Program designed to judge a two player game of rock, paper, scissors.
*/
using System;

class Game { //class

public static void Main(string[] args)  { //main
//variables
string player1;
string player2;
//ask for player 1
      Console.Write("Player One, enter your choice; ROCK, PAPER, or SCISSORS.");
      player1 = Console.ReadLine();
      if (player1 == "") { //p1 exits on no entry
            Console.WriteLine("Exit."); 
            Environment.Exit(0);
        } //p1

//ask for player 2
      Console.Write("Player Two, enter your choice; ROCK, PAPER, or SCISSORS.");
      player2 = Console.ReadLine();
      if (player2 == "") { //p2 exits on no entry
            Console.WriteLine("Exit."); 
            Environment.Exit(0);
        } //p2

switch (player1) { // switch
	case "ROCK":	
		if (player2 == "ROCK") {
			Console.WriteLine("Tie");
		}
		else if (player2 == "PAPER") {
			Console.WriteLine("Player 2 Wins");
		}
		else if (player2 == "SCISSORS") {
			Console.WriteLine("Player 1 Wins");
		}
	break;
	case "PAPER":	
		if (player2 == "ROCK") {
			Console.WriteLine("Player 1 Wins");
		}
		else if (player2 == "PAPER") {
			Console.WriteLine("Tie");
		}
		else if (player2 == "SCISSORS") {
			Console.WriteLine("Player 2 Wins");
		}
	break;
	case "SCISSORS":	
		if (player2 == "ROCK") {
			Console.WriteLine("Player 2 Wins");
		}
		else if (player2 == "PAPER") {
			Console.WriteLine("Player 1 Wins");
		}
		else if (player2 == "SCISSORS") {
			Console.WriteLine("Tie");
		}
	break;
	} //switch
	} //class
}//main