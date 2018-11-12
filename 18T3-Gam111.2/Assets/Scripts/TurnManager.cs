using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
	public enum TurnPhase { Player, PlayerAnim, Enemy, EnemyAnim, Count};
	public TurnPhase turnPhase;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void NextPhase()
	{
		int phase = (int)turnPhase;
		phase++;
		if (phase == (int)TurnPhase.Count)
		{
			phase = 0;
		}
		turnPhase = (TurnPhase)phase;
		PrintCurrentPhase();
	}

	public void PrintCurrentPhase()
	{
		string phase;
		switch (turnPhase)
		{
			case TurnPhase.Player:
				phase = "Player";
				break;
			case TurnPhase.PlayerAnim:
				phase = "PlayerAnim";
				break;
			case TurnPhase.Enemy:
				phase = "Enemy";
				break;
			case TurnPhase.EnemyAnim:
				phase = "EnemyAnim";
				break;
			default:
				phase = "Unknown";
				break;
		}
		print("Current phase: " + phase);
	}

	public TurnPhase GetPhase()
	{
		return turnPhase;
	}
}
