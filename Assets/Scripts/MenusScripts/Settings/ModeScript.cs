using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ModeScript : MonoBehaviour
{

    public static string ModeName;
    public string[] modes;
    int modeIndex = 0;
    public GameObject modeText;

    //ModesLock stuff
    public GameObject LockModeText;
    public GameObject ModeApplayButton;
    public int[] ModeLockScores;

    // Use this for initialization
    void Start()
    {
        modeIndex = GetModeIndexBySavedMode();
        showTextOnScreen(modeText, modes[modeIndex]);
        ModeName = Holders.CorrendTextureMode;
    }

    // Update is called once per frame
    void Update()
    {
    }

    #region Buttons
    public void nextMode()
    {
        modeIndex++;
        if (modeIndex == modes.Length)
        {
            modeIndex = 0;
        }
        showTextOnScreen(modeText, modes[modeIndex]);

        LockMode();
    }
    public void previousMode()
    {
        modeIndex--;
        if (modeIndex == -1)
        {
            modeIndex = modes.Length - 1;
        }
        showTextOnScreen(modeText, modes[modeIndex]);

        LockMode();
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
    void showTextOnScreen(GameObject place, string textToShow)
    {
        place.GetComponent<Text>().text = textToShow;
    }

    void LockMode()
    {
        if (Holders.HightScore < ModeLockScores[modeIndex]) 
        {
            showTextOnScreen(LockModeText, "You need to get More then "+ ModeLockScores[modeIndex].ToString()+" to get this mode");
            ModeApplayButton.GetComponent<Button>().interactable = false;
        }
        else
        {
            showTextOnScreen(LockModeText, "");
            ModeApplayButton.GetComponent<Button>().interactable = true;
        }
    }
}
