using UnityEngine;
using System.Collections;

public class obstacleScript : MonoBehaviour
{
    #region variables
    #region game objects
    public Transform player;
    public Transform obstacle;
    public Camera mainCam;
    #endregion
    #region numbers
    float playerSpeed = 0.05f;
    int obstacleSpriteNumber;
    float points = 0;
    #endregion
    #region arrays
    public Sprite[] obstacleSprites = new Sprite[4];
    public Color[] obstacleColor = new Color[4];
    string[] playersSkinsNames = new string[4] { "first", "second", "third", "forth" };
    #endregion
    #endregion

    void Start()
    {
        ReStartObstacle();
        points = 0;
    }

    void Update()
    {
        playerSpeed = 0.05f + Mathf.Sqrt(points)/100;
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
            ReStartObstacle();
    }

    void RandomObstacleCalor()
    {
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
        player.gameObject.GetComponent<AudioSource>().Play();
    }
}
