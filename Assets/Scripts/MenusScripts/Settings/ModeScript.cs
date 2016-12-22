using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ModeScript : MonoBehaviour {

    public static string ModeName;
    public string[] modes;
    int modeIndex = 0;
    public GameObject modeText;

	// Use this for initialization
	void Start () {
        modeIndex = GetModeIndexBySavedMode();
        showTextOnScreen(modeText, modes[modeIndex]);
        ModeName = Holders.CorrendTextureMode;
    }
	
	// Update is called once per frame
	void Update () {
	}

    #region Buttons
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
        Application.LoadLevel("menu");
        ModeName = modes[modeIndex];
        Holders.SaveString("TextureMode", ModeName);
        Holders.CorrendTextureMode = ModeName;
    }
    #endregion

    int GetModeIndexBySavedMode()
    {
        for (int i = 0; i < modes.Length; i++)
        {
            if (modes[i] == Holders.CorrendTextureMode)
            {
                return i;
            }
        }
        return 0;
    }
    void showTextOnScreen(GameObject place,string textToShow)
    {
        place.GetComponent<Text>().text = textToShow;
    }
}
