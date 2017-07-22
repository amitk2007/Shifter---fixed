using UnityEngine;
using System.Collections;

public class OnClick : MonoBehaviour
{
    GameObject slash;
  
    // Use this for initialization
    void Start()
    {
        switch (this.gameObject.name)
        {
            case "Music":
                slash = this.gameObject.transform.GetChild(0).gameObject;
                slash.SetActive(!Holders.IsMusicEnable);
                break;
            case "Sound":
                slash = this.gameObject.transform.GetChild(0).gameObject;
                slash.SetActive(!Holders.IsSoundEnable);
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnMouseDown()
    {
        switch (this.gameObject.name)
        {
            case "Back":
                Application.LoadLevel(Holders.Menus[0]);
                break;
            case "Music":
                slash = this.gameObject.transform.GetChild(0).gameObject;
                Holders.IsMusicEnable = !Holders.IsMusicEnable;
                slash.SetActive(!Holders.IsMusicEnable);
                Holders.SaveString("MusicEnable", Holders.IsMusicEnable.ToString());
                break;
            case "Sound":
                slash = this.gameObject.transform.GetChild(0).gameObject;
                Holders.IsSoundEnable = !Holders.IsSoundEnable;
                slash.SetActive(!Holders.IsSoundEnable);
                Holders.SaveString("SoundEnable", Holders.IsSoundEnable.ToString());
                break;
            default:
                break;
        }


    }
}
