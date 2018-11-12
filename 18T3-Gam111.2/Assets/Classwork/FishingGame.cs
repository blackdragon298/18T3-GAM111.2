using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingGame : MonoBehaviour
{
	public TextAsset fishList;
	string rawString;
	string[] fish;
	int myScore;

	// Use this for initialization
	void Start()
	{
		print(fishList.text);
		rawString = fishList.text;

		fish = rawString.Split('\n');
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			CatchFish();
		}
	}

	void CatchFish()
	{
		string caughtFish = fish[Random.Range(0, fish.Length)];
		print(caughtFish);

		// Fish name is 0, Fish value is 1
		string[] fishAndScore = caughtFish.Split(',');
		
		print("I caught a " + fishAndScore[0]);
		print("It is worth $" + fishAndScore[1] + "!");

		myScore += int.Parse(fishAndScore[1]);

		print("My score is now: $" + myScore);
	}
}
