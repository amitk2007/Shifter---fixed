using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHightScore : MonoBehaviour
{
    public static int hightscore;
    public static int score;
    public GameObject HighPointsText;
    public GameObject NewBest;
    
    // Use this for initialization
    void Start()
    {
        //Get Variables
        score = playerScript.playerScore;
        hightscore = Holders.GetInt("hightscore", 0);

        #region Writing the "New Hight Score" text
        //Writes "Hight Score" if playerScore is bigger then the last HightScore
        if (hightscore < score)
        {
            NewBest.GetComponent<Text>().enabled = true;
        }
        else
        {
            NewBest.GetComponent<Text>().enabled = false;
        }
        #endregion

        #region setting new hight score
        //save the hightest score (player/last hight score)
        hightscore = Mathf.Max(hightscore, score);
        Holders.SaveInt("hightscore", hightscore);
        //writing the new HightScore
        HighPointsText.GetComponent<Text>().text = hightscore.ToString();
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}
