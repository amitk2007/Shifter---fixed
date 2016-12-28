using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SettingScript : MonoBehaviour {

    public GameObject[] MusicAndSound  = new GameObject[2];
	// Use this for initialization
	void Start () {
        Holders.IsSoundEnable = Holders.BoolFromString(Holders.GetString("SoundEnable", "True"));
        Holders.IsMusicEnable = Holders.BoolFromString(Holders.GetString("MusicEnable", "True"));
        MusicAndSound[0].GetComponent<Toggle>().isOn = Holders.IsMusicEnable;
        MusicAndSound[1].GetComponent<Toggle>().isOn = Holders.IsSoundEnable;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void MusicToggleIsChanged()
    {
        if (MusicAndSound[0].GetComponent<Toggle>().isOn != Holders.IsMusicEnable)
        {
            Holders.IsMusicEnable = !Holders.IsMusicEnable;
        }
        Holders.SaveString("MusicEnable", Holders.IsMusicEnable.ToString());
    }
    public void SoundToggleIsChanged()
    {
        if (MusicAndSound[1].GetComponent<Toggle>().isOn != Holders.IsSoundEnable)
        {
            Holders.IsSoundEnable = !Holders.IsSoundEnable;
        }
        Holders.SaveString("SoundEnable", Holders.IsSoundEnable.ToString());
    }
}
