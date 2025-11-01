using Godot;
using System;

public partial class UserData : Node
{
	public int xp { get; private set; } = 0;
	public int lvl { get; private set; } = 1;

	public void AddXP(int amount)
	{
		xp += amount;
		GD.Print($"XP: {xp}");
	}
}
