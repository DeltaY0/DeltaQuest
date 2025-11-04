using Godot;
using System;

public partial class Character : Sprite2D
{
	[Export] public int maxHP = 50;
	public int currHP;
	public int position; // 1, 2, or 3

	public ProgressBar healthbar;

	public void _Ready()
	{
		healthbar = GD.Load<ProgressBar>("./health_bar");
		healthbar.MaxValue = maxHP;
		healthbar.Value = maxHP;
	}


	public void UpdateHP(int change)
	{
		currHP = Math.Max(0, currHP + change);
		healthbar.Value = currHP;
	}

}
