using Godot;
using System;

public partial class CardData : Resource
{
    [Export] public string CardName;

    [Export(PropertyHint.MultilineText)]
    public string Description;

    [Export] public int Cost;
}
