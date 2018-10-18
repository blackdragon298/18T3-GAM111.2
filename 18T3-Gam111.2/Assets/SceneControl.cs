using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
	public enum CurrentScene { Splash, Menu, Overworld, Combat, End, Credits};
	public CurrentScene currentScene;

	// Use this for initialization
	void Start()
	{
		currentScene = (CurrentScene)SceneManager.GetActiveScene().buildIndex;
	}

	// Update is called once per frame
	void Update()
	{
		if (currentScene == CurrentScene.Splash)
		{
			if (Input.GetMouseButtonDown(0))
			{
				LoadMainMenu();
			}
		}
	}

	public CurrentScene GetCurrentScene()
	{
		return currentScene;
	}

	public void LoadSplashScreen()
	{
		SceneManager.LoadScene("SplashScreen");
	}

	public void LoadMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}

	public void LoadOverworld()
	{
		SceneManager.LoadScene("Overworld");
	}

	public void LoadCombat()
	{
		SceneManager.LoadScene("Combat");
	}

	public void LoadGameEnd()
	{
		SceneManager.LoadScene("GameEnd");
	}

	public void LoadCredits()
	{
		SceneManager.LoadScene("Credits");
	}
}
