using UnityEngine;
using System.Collections;

public class Acrive : MonoBehaviour
{
    public Camera cam;

    // Use this for initialization
    void Start()
    {
        switch (this.gameObject.name)
        {
            case "Play":
                this.gameObject.transform.position = cam.ScreenToWorldPoint(new Vector3(Screen.width/4, Screen.height/2, 10));
                break;
            case "Settings":
                this.gameObject.transform.position = cam.ScreenToWorldPoint(new Vector3(50, Screen.height - 60, 10));
                break;
            case "HowToPlay":
                this.gameObject.transform.position = cam.ScreenToWorldPoint(new Vector3(Screen.width-40, Screen.height - 60, 10));
                break;

            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseDown()
    {
        switch (this.gameObject.name)
        {
            case "Play":
                Application.LoadLevel(Holders.Menus[1]);
                break;
            case "Settings":
                Application.LoadLevel(Holders.Menus[3]);
                break;
            case "HowToPlay":
                Application.LoadLevel(Holders.Menus[2]);
                break;

            default:
                break;
        }
    }
}
