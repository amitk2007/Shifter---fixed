using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SettingScript : MonoBehaviour {

    public GameObject[] MusicAndSound  = new GameObject[2];
	// Use this for initialization
	void Start () {
        Holders.IsSoundEnable = Holders.BoolFromString(Holders.GetString("SoundEnable", "true"));
        Holders.IsMusicEnable = Holders.BoolFromString(Holders.GetString("MusicEnable", "true"));
        MusicAndSound[0].GetComponent<Toggle>().isOn = Holders.IsMusicEnable;
        MusicAndSound[1].GetComponent<Toggle>().isOn = Holders.IsSoundEnable;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void MusicToggleIsChanged()
    {
        Holders.IsMusicEnable = !Holders.IsMusicEnable;
        Holders.SaveString("MusicEnable", Holders.IsMusicEnable.ToString());
    }
    public void SoundToggleIsChanged()
    {
        Holders.IsSoundEnable = !Holders.IsSoundEnable;
        Holders.SaveString("SoundEnable", Holders.IsSoundEnable.ToString());
    }
}
