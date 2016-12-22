using UnityEngine;
using System.Collections;

public class Holders : MonoBehaviour
{
    public static string MenuType;//"Animated" or "NotAnimated"
    public static bool Sound; //have (true) or don't have (false)
    public static bool Music; //have (true) or don't have (false)
    public static string CorrendTextureMode; //"Classic" or "Brick" or "Rainbow"
    public static string[] Menus = new string[5];
    // Use this for initialization
    void Start()
    {
        Sound = (GetInt("Sound",1)==1);
        Music = (GetInt("Music",1)==1);
        CorrendTextureMode = GetString("TextureMode", "Classic");
        MenuType = GetString("MenuType", "Animated");
        ChangeMenus(MenuType);
    }

    // Update is called once per frame
    void Update()
    {

    }

    #region Get (Int/Float/String)
    public static float GetFloat(string name,float defaultVlaue)
    {
        return PlayerPrefs.GetFloat(name,defaultVlaue);
    }
    public static int GetInt(string name,int defaultVlaue)
    {
        return PlayerPrefs.GetInt(name, defaultVlaue);
    }
    public static string GetString(string name,string defaultVlaue)
    {
        return PlayerPrefs.GetString(name, defaultVlaue);
    }
    #endregion

    #region Save/set (Int/Flaot/String)
    public static void SaveFloat(string name, float value)
    {
        PlayerPrefs.SetFloat(name, value);
    }
    public static void SaveInt(string name, int value)
    {
        PlayerPrefs.SetInt(name, value);
    }
    public static void SaveString(string name, string value)
    {
        PlayerPrefs.SetString(name, value);
    }
    #endregion

    public static void ChangeMenus(string menuType)
    {
        if (menuType == "Animated")
        {
            Menus = new string[4] { "AMenu", "Game", "AHowToPlay", "ASettings" };
        }
        if (menuType == "NotAnimated")
        {
            Menus = new string[4] { "Menu", "Game", "HowToPlay", "ASettings" };
        }
        else
        {
            ChangeMenus("Animated");
        }
    }
}
