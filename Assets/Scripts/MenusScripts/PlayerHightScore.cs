using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHightScore : MonoBehaviour {

	public static int score;
	public GameObject HighPointsText;
	public GameObject NewBest;
	// Use this for initialization
	void Start () {

		score = playerScript.playerScore;
		
		Holders.HightScore = Holders.GetInt ("highscore", 0);

		if (Holders.HightScore < score) {
			NewBest.GetComponent<Text> ().enabled = true;
		} else {
			NewBest.GetComponent<Text>().enabled = false;
		}

		Holders.HightScore = Mathf.Max(Holders.HightScore,score);
		Holders.SaveInt ("highscore",Holders.HightScore);
		HighPointsText.GetComponent<Text> ().text = Holders.HightScore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
