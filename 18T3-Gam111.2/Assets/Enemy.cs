using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public enum EnemyType { };
	public EnemyType type;

	public enum OverworldBehaviour { Idle, Aggressive, Defeated};
	public OverworldBehaviour behaviour;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
