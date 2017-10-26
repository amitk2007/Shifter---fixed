using UnityEngine;
using System.Collections;
using System.IO;

public class ApplyMode : MonoBehaviour
{

    //public static float DeltaTime =6.00f;
    public GameObject player;
    public GameObject obstacle;
    // Use this for initialization
    void Start()
    {
        #region public game objects
        PlayerSetup(player);
        ObstacleSetup(obstacle);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
    }

    void PlayerSetup(GameObject player)
    {
        player.GetComponent<playerScript>().playerSprits = new Sprite[4] { GetSprite("first"), GetSprite("second"), GetSprite("third"), GetSprite("forth") };
        playerScript.SpritsArray = player.GetComponent<playerScript>().playerSprits;
    }
    void ObstacleSetup(GameObject obstacle)
    {
        obstacle.GetComponent<obstacleScript>().obstacleSprites = new Sprite[4] { GetSprite("obstacle1"), GetSprite("obstacle2"), GetSprite("obstacle3"), GetSprite("obstacle4") };
    }

    Sprite GetSprite(string name)
    {
        print(Holders.CorrendTextureMode);
        string path = "Modes/" + Holders.CorrendTextureMode + "/" + name;
        Sprite spt = (Sprite)Resources.Load(path, typeof(Sprite));
        return spt;
    }
}
