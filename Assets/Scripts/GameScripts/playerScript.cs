using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour
{
    #region variables
    public static int points = 0;
    public Sprite[] playerSprits = new Sprite[4];
    public static Sprite[] SpritsArray;
    private Rigidbody2D player;
    public GUISkin theSkin;
    public static int SpriteNumber = 0;
    public static int playerScore = 0;
    #endregion

    void Start()
    {
        SpritsArray = playerSprits;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = SpritsArray[0];
    }

    void OnGUI()
    {
        GUI.skin = theSkin;
        theSkin.label.fontSize = GUISizeByScore(playerScore)/*Screen.height / 8*/;
        GUI.Label(new Rect(Screen.width / 10, 25, Screen.width / 4, Screen.height / 5), "" + playerScore);
    }

    #region helpers
    public static int AddOneLoop(int i, int loop = 4)
    {
        if (i == (loop - 1))
        {
            return 0;
        }
        else
        {
            return i + 1;
        }
    }
    public void AddOneToPlayerScore()
    {
        playerScore++;
    }
    public int GetPlayerScore()
    {
        return playerScore;
    }

    //GUI
    public int GUISizeByScore(int score)
    {
        if (score<=11)
        {
            return Screen.height/8;
        }
        if (score>=100)
        {
            return 20;
        }
        return 30;
    }
    #endregion
}
