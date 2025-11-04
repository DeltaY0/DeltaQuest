using Godot;
using System;
using System.Collections.Generic;

public partial class BattleManager : Node
{
	// data
	List<CardData> deck;
	List<CardData> hand;
	List<CardData> discard;

	int playerEnergy;

	// deck moves
	public void ShuffleFromDiscard()
	{
		deck.AddRange(discard);
		discard.Clear();
	}

	public void DrawXCards(int x)
	{
		while (x > 0)
		{
			if (deck.Count == 0)
				ShuffleFromDiscard();

			// get random number
			int idx = (int)GD.Randi() % deck.Count;
			hand.Add(deck[idx]);
			deck.RemoveAt(idx);

			x--;
		}
	}

	public void PlayCard(CardData card, Character target)
	{
		if (playerEnergy >= card.Cost)
		{
			playerEnergy -= card.Cost;
			hand.Remove(card);
			target.UpdateHP(-10);
			discard.Add(card);
		}
	}

	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
	}
}
