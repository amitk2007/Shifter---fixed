﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SettingScript : MonoBehaviour {

    public GameObject[] SoundAndMusic  = new GameObject[2];
	// Use this for initialization
	void Start () {
        SoundAndMusic[0].GetComponent<Toggle>().isOn = Holders.IsMusicEnable;
        SoundAndMusic[1].GetComponent<Toggle>().isOn = Holders.IsSoundEnable;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void MusicToggleIsChanged()
    {
        Holders.IsMusicEnable = !Holders.IsMusicEnable;
        Holders.SaveString("MusicEnable", Holders.IsSoundEnable.ToString());
    }
    public void SoundToggleIsChanged()
    {
        Holders.IsSoundEnable = !Holders.IsSoundEnable;
        Holders.SaveString("SoundEnable", Holders.IsSoundEnable.ToString());
    }
}
