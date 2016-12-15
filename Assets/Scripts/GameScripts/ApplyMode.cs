using UnityEngine;
using System.Collections;
using System.IO;

public class ApplyMode : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print(GetSprite("first"));
        if (this.gameObject.tag=="Player")
        {
            print("Player settings");
            PlayerSetup();
        }
        else if (this.gameObject.tag== "Obstacle")
        {
            print("othersettings");
            ObstacleSetup();
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void PlayerSetup()
    {
        this.GetComponent<playerScript>().playerSprits = new Sprite[4]{GetSprite("first"),GetSprite("second"),GetSprite("third"),GetSprite("forth") };
        playerScript.SpritsArray = this.GetComponent<playerScript>().playerSprits;
    }

    void ObstacleSetup()
    {
        this.GetComponent<obstacleScript>().obstacleSprites = new Sprite[4] { GetSprite("obstacle1"), GetSprite("obstacle2"), GetSprite("obstacle3"), GetSprite("obstacle4") };
    }

    Sprite GetSprite(string name)
    {
        string path = "Modes/" + ModeScript.ModeName + "/" + name;
        Sprite spt = (Sprite) Resources.Load(path,typeof(Sprite));
        return spt;
    }
}
