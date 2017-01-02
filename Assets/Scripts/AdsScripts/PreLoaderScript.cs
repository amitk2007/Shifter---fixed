using UnityEngine;
using System.Collections;

public class PreLoaderScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Holders.CorrendTextureMode = Holders.GetString("TextureMode", "Classic");
        Holders.MenuType = Holders.GetString("MenuType", "Animated");

        if (Holders.MenuType == "Animated")
        {
            Holders.Menus = new string[5] { "AMenu", "Game", "AHowToPlay", "ASettings", "AEndGame" };
        }
        else
        {
            Holders.Menus = new string[5] { "Menu", "Game", "HowToPlay", "Settings", "EndGame" };
        }
        Application.LoadLevel(Holders.Menus[0]);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
