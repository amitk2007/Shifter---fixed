using UnityEngine;
using System.Collections;

public class obstacleScript : MonoBehaviour
{
    #region variables
    //public Sprite[] BreakSprits = new Sprite[11];
    float playerSpeed = 0.05f;
    public Sprite[] obstacleSprites = new Sprite[4];
    //public Sprite obstacleBreakSprites;
    public Color[] obstacleColor = new Color[4];
    public Transform player;
    public Transform obstacle;
    public Camera mainCam;
    int obstacleSpriteNumber;
    float points = 0;
    bool addMorePoints = false;
    string[] playersSkinsNames = new string[4] { "first", "second", "third", "forth" };

    //break
    bool breaking = false;
    float timer;
    //End break
    #endregion

    void Start()
    {
        ReStartObstacle();
        points = 0;
    }

    void Update()
    {
        playerSpeed = 0.05f + ((points / 2) / 100);
        transform.Translate(Vector3.down * playerSpeed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            string playerSpriteName = player.gameObject.GetComponent<SpriteRenderer>().sprite.name;
            if (playerSpriteName.Equals(playersSkinsNames[obstacleSpriteNumber]))
            {
                player.SendMessage("AddOneToPlayerScore");
                points++;
                obstacleBreak();
            }
            else
            {
                AdManager.Instance.ShowVideo();
                AdManager.Instance.RemoveBunner();
                Application.LoadLevel("EndGame");
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (breaking == false)
        {
            ReStartObstacle();
        }
    }

    void RandomObstacleCalor()
    {
        print("randome");
        obstacleSpriteNumber = Random.Range(0, 4);//0 or 1 or 2 or 3
        gameObject.GetComponent<SpriteRenderer>().sprite = obstacleSprites[obstacleSpriteNumber];
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        obstacle.GetChild(0).GetComponent<SpriteRenderer>().color = new Color(obstacleColor[obstacleSpriteNumber].r, obstacleColor[obstacleSpriteNumber].g, obstacleColor[obstacleSpriteNumber].b);
        obstacle.GetChild(1).GetComponent<SpriteRenderer>().color = new Color(obstacleColor[obstacleSpriteNumber].r, obstacleColor[obstacleSpriteNumber].g, obstacleColor[obstacleSpriteNumber].b);
    }

    void ReStartObstacle()
    {
        obstacle.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width / 2, 0f, 0f)).x, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0f);
        obstacle.GetChild(0).localScale = new Vector3(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 1, 1, 1);
        obstacle.GetChild(1).localScale = new Vector3(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 1, 1, 1);
        obstacle.GetChild(0).position = new Vector2(5, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y);
        obstacle.GetChild(1).position = new Vector2(-5, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y);
        RandomObstacleCalor();
    }

    void obstacleBreak()
    {
        timer = Time.time;
        breaking = true;
        breaking = false;
        /*for (int i = 0; i < 11; i++) {
			gameObject.GetComponent<SpriteRenderer>().sprite = BreakSprits[i];
			System.Threading.Thread.Sleep(100);
		}*/
    }
}
