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
        player.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width / 2, 0f, 0f)).x, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height - 7 * (Screen.height / 8), 0f)).y + 0f);

        #region Music and Sounds
        this.gameObject.GetComponent<AudioSource>().enabled = Holders.IsMusicEnable;
        player.gameObject.GetComponent<AudioSource>().enabled = Holders.IsSoundEnable;
        #endregion

    }

    // Update is called once per frame
    void Update()
    {

    }
}
