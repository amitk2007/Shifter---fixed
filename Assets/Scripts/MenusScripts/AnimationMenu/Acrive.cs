using UnityEngine;
using System.Collections;

public class Acrive : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

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
