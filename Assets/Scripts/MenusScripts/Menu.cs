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
		Application.LoadLevel (Holders.Menus[0]);
	}

	public void PlayGame()//ButtonTryAgain + ButtonStartGame
	{
		Application.LoadLevel (Holders.Menus[0]);
		playerScript.playerScore = 0;
		Application.LoadLevel(Holders.Menus[1]);
	}

	public void HowToPlay()
	{
		Application.LoadLevel(Holders.Menus[2]);
	}
    public void OpenSetting()
    {
        Application.LoadLevel(Holders.Menus[3]);
    }

	public void Exit()
	{
		Application.Quit ();
	}
}
