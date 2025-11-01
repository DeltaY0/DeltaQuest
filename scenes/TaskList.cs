using Godot;
using System;

public partial class TaskList : Control
{
	private UserData user_data; // A cache for our singleton

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		user_data = GetNode<UserData>("/root/UserData");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void XPAddButton()
	{
		user_data.AddXP(10);
	}
}
