using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ModeScript : MonoBehaviour
{

    public string ModeName;
    public static string[] modes = new string[3] { "Classic", "OutLine", "8Bit" };
    public int modeIndex = 0;
    public GameObject modeText;

    //ModesLock stuff
    public GameObject LockModeText;
    public GameObject ModeApplayButton;
    public static int[] ModeLockScores = new int[3] { 0, 10, 20 };

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
    void nextMode()
    {
        modeIndex++;
        if (modeIndex == modes.Length)
        {
            modeIndex = 0;
        }
        showTextOnScreen(modeText, modes[modeIndex]);

        LockMode();
    }
    void previousMode()
    {
        modeIndex--;
        if (modeIndex == -1)
        {
            modeIndex = modes.Length - 1;
        }
        showTextOnScreen(modeText, modes[modeIndex]);

        LockMode();
    }
    void ApplyMode()
    {
        Application.LoadLevel(Holders.Menus[0]);
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
