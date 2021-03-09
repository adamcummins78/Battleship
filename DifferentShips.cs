using System;

public class Aircraft : Ship
{
	public Aircraft()
	{
		Name = "Aircraft Carrier";
		Width = 5;
		//Coordinate?
	}
}

public class Battleship : Ship
{
	public Battleship()
	{
		Name = "Battleship";
		Width = 4;
		//Coordinates?
	}
}

public class Submarine : Ship
{
	public Submarine()
	{
		Name = "Submarine";
		Width = 4;
		//Coordinates?
	}
}

public class Cruiser : Ship
{
	public Cruiser()
	{
		Name = "Cruiser";
		Width = 3;
		//Coordinates?
	}
}

public class Destroyer : Ship
{
	public Destroyer()
	{
		Name = "Destroyer";
		Width = 2;
		//Coordinates?
	}
}


