using UnityEngine;
using System.Collections;
//
using UnityEngine.UI;
//

public class Menu : MonoBehaviour {
	
	public GameObject PointsText;
	// Use this for initialization
	void Start () {
		PointsText.GetComponent<Text> ().text = playerScript.playerScore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void ButtonMainMenu()
	{
		Application.LoadLevel ("menu");
	}

	public void PlayGame()//ButtonTryAgain + ButtonStartGame
	{
		Application.LoadLevel ("menu");
		playerScript.playerScore = 0;
		Application.LoadLevel("game");
	}

	public void Exit()
	{
		Application.Quit ();
	}
}
