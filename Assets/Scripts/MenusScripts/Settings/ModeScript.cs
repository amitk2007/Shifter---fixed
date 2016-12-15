using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ModeScript : MonoBehaviour {

    public static string ModeName = "Brick";
    public string[] modes;
    int modeIndex = 0;
    public GameObject modeText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void nextMode()
    {
        modeIndex++;
        if (modeIndex==modes.Length)
        {
            modeIndex = 0;
        }
        showTextOnScreen(modeText, modes[modeIndex]);
    }
    public void previousMode()
    {
        modeIndex--;
        if (modeIndex==-1)
        {
            modeIndex = modes.Length - 1;
        }
        showTextOnScreen(modeText, modes[modeIndex]);
    }
    public void ApplyMode()
    {
        Application.LoadLevel("game");
        ModeName = modes[modeIndex];
    }


    void showTextOnScreen(GameObject place,string text)
    {
        place.GetComponent<Text>().text = text;
    }
}
