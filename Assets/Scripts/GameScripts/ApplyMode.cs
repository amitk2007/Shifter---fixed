using UnityEngine;
using System.Collections;
using System.IO;

public class ApplyMode : MonoBehaviour {

    //public static float DeltaTime =6.00f;
    public GameObject player;
    public GameObject obstacle;
    // Use this for initialization
    void Start () {

        #region public game objects
        print("*****************************************");
        PlayerSetup(player);
        ObstacleSetup(obstacle);
        print("*****************************************");

        #endregion
        #region this game object
        /*print(GetSprite("first"));
        if (this.gameObject.tag=="Player")
        {
            print(Time.time);
            print("Player settings");
            PlayerSetup(this);
        }
        else if (this.gameObject.tag== "Obstacle")
        {
            print(Time.time);
            print("othersettings");
            ObstacleSetup(this);
        }*/
        #endregion
    }

    // Update is called once per frame
    void Update () {
	
	}

    void PlayerSetup(GameObject player)
    {
        player.GetComponent<playerScript>().playerSprits = new Sprite[4]{GetSprite("first"),GetSprite("second"),GetSprite("third"),GetSprite("forth") };
        playerScript.SpritsArray = player.GetComponent<playerScript>().playerSprits;
    }

    void ObstacleSetup(GameObject obstacle)
    {
        obstacle.GetComponent<obstacleScript>().obstacleSprites = new Sprite[4] { GetSprite("obstacle1"), GetSprite("obstacle2"), GetSprite("obstacle3"), GetSprite("obstacle4") };
    }

    Sprite GetSprite(string name)
    {
        string path = "Modes/" + ModeScript.ModeName + "/" + name;
        Sprite spt = (Sprite) Resources.Load(path,typeof(Sprite));
        return spt;
    }

    public static void Dealy()
    {
       /* while (Time.time<=DeltaTime)
        {

        }*/
    }
}
