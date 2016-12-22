using UnityEngine;
using System.Collections;
//
using UnityEngine.UI;
//

public class Menu : MonoBehaviour {
	
	public GameObject PointsText;
	// Use this for initialization
	void Start () {
        if (PointsText!=null)
        {
            PointsText.GetComponent<Text>().text = playerScript.playerScore.ToString();
        }
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

	public void HowToPlay()
	{
		Application.LoadLevel("HowToPlay");
	}
    public void OpenSetting()
    {
        Application.LoadLevel("Settings");
    }

	public void Exit()
	{
		Application.Quit ();
	}
}
