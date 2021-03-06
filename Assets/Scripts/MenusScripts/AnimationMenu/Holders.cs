﻿using UnityEngine;
using System.Collections;

public class Holders : MonoBehaviour
{
    #region Menus
    public static string MenuType;//"Animated" or "NotAnimated"
    public static string CorrendTextureMode; //"Classic" or "Brick" or "Rainbow"
    public static string[] Menus = new string[5] { "AMenu", "Game", "AHowToPlay", "ASettings", "AEndGame" };
    public static int HightScore;
    #endregion
    #region Music and Sound
    //music and sounds
    public static bool IsMusicEnable = true; //have (true) or don't have (false)
    public static bool IsSoundEnable = true; //have (true) or don't have (false)
    #endregion
    
    // Use this for initialization
    void Start()
    {
        //mods
        //SaveInt("ModeInt", 0);
        CorrendTextureMode = GetString("TextureMode", "Classic");
        //audio
        IsSoundEnable = BoolFromString(GetString("SoundEnable", "True"));
        IsMusicEnable = BoolFromString(GetString("MusicEnable", "True"));
        //menus
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
        print("ok");
        if (menuType == "Animated")
        {
            Menus = new string[5] { "AMenu", "Game", "AHowToPlay", "ASettings" ,"AEndGame"};
        }
        if (menuType == "NotAnimated")
        {
            Menus = new string[5] { "Menu", "Game", "HowToPlay", "ASettings" ,"EndGame"};
        }
        else
        {
            ChangeMenus("Animated");
        }
    }
    public static bool BoolFromString(string str)
    {
        if (str == "True")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
