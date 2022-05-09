using System;

public class Game
		//This is the parent class of all other classes

{
	public Game()
	{
		//Member Variables
	protected string Rock;
	protected string Paper;
	protected string Scissors;
	protected string Lizard;
	protected string Spock;
	protected bool turn = true;


		//Constructor

	public Game(string Rock, string Paper, string Scissors, string lizard, string Spock)

		this.Rock = Rock;
		this.Paper = Paper;
		this.Scissors = Scissors;
		this.Lizard = Lizard;
		this.Spock = Spock

		isTurn = true;

	//Member methods
	public void DisplayGameInformation()
	{
		Console.WriteLine("AI has chosen" + Rock + "to beat you!");


	}

	}
}
