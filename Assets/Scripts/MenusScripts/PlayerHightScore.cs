using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHightScore : MonoBehaviour {

	public static int highscore;
	public static int score;
	public GameObject HighPointsText;
	public GameObject NewBest;
	// Use this for initialization
	void Start () {

		score = playerScript.playerScore;
		
		highscore = PlayerPrefs.GetInt ("highscore", highscore);

		if (highscore < score) {
			NewBest.GetComponent<Text> ().enabled = true;
		} else {
			NewBest.GetComponent<Text>().enabled = false;
		}

		highscore = Mathf.Max(highscore,score);
		PlayerPrefs.SetInt ("highscore",highscore);
		HighPointsText.GetComponent<Text> ().text = highscore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
