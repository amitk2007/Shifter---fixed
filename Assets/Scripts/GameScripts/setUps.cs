using UnityEngine;
using System.Collections;

public class setUps : MonoBehaviour
{

    //Reference the camera
    public Camera mainCam;

    public Transform player;
    public Transform obstacle;

    // Use this for initialization
    void Start()
    {
//        print(Screen.width + "w");
//        print(Screen.height + "h");
//        print(Screen.width / 2 + "w/2");
//        print(Screen.height + "h");

        player.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width / 2, 0f, 0f)).x, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height - 7 * (Screen.height / 8), 0f)).y + 0f);
        //player.position = new Vector3 (Screen.width/2f,Screen.height-3f*(Screen.height/4),0f		);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
