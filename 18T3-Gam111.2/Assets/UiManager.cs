using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
	public Text currentPhase;
	private TurnManager turnManager;
	private SceneControl sceneControl;

	// Use this for initialization
	void Start()
	{
		turnManager = GetComponent<TurnManager>();
		sceneControl = GetComponent<SceneControl>();
	}

	// Update is called once per frame
	void Update()
	{
		if (sceneControl.GetCurrentScene() == SceneControl.CurrentScene.Combat)
		{
			string phase = "";
			switch (turnManager.GetPhase())
			{
				case TurnManager.TurnPhase.Player:
					phase = "Player";
					break;
				case TurnManager.TurnPhase.PlayerAnim:
					phase = "PlayerAnim";
					break;
				case TurnManager.TurnPhase.Enemy:
					phase = "Enemy";
					break;
				case TurnManager.TurnPhase.EnemyAnim:
					phase = "EnemyAnim";
					break;
				default:
					phase = "Unknown";
					break;
			}
			currentPhase.text = ("TurnPhase: " + phase);
		}
	}
}
