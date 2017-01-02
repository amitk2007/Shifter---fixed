using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ModeTextScript : MonoBehaviour
{
    public GameObject TextWithLock;
    public static int modeint;
    string modeName;
    public GameObject applyButton;
    bool applyClickable = true;
    // Use this for initialization
    void Start()
    {
        modeint = GetModeIndexBySavedMode();
        modeName = Holders.CorrendTextureMode;
        showTextOnScreen(TextWithLock, modeName);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        switch (this.gameObject.name)
        {
            case "Cube>":
                nextMode();
                break;
            case "Cube<":
                previousMode();
                break;
            case "ApplyCube":
                if (applyClickable == true)
                {
                    ApplyMode();
                }
                break;
            default:
                break;
        }
    }


    #region Buttons
    void nextMode()
    {
        modeint++;
        if (modeint == ModeScript.modes.Length)
        {
            modeint = 0;
        }
        showTextOnScreen(TextWithLock, ModeScript.modes[modeint]);

        LockMode();
    }
    void previousMode()
    {
        modeint--;
        if (modeint == -1)
        {
            modeint = ModeScript.modes.Length - 1;
        }
        showTextOnScreen(TextWithLock, ModeScript.modes[modeint]);

        LockMode();
    }
    void ApplyMode()
    {
        print("mode int2 =" + modeint);

        modeName = ModeScript.modes[modeint];
        Holders.SaveString("TextureMode", modeName);
        Holders.CorrendTextureMode = modeName;
        Application.LoadLevel(Holders.Menus[0]);

    }
    #endregion

    int GetModeIndexBySavedMode()
    {
        for (int i = 0; i < ModeScript.modes.Length; i++)
        {
            if (ModeScript.modes[i] == Holders.CorrendTextureMode)
            {
                return i;
            }
        }
        return 0;
    }
    void showTextOnScreen(GameObject place, string textToShow)
    {
        place.GetComponent<TextMesh>().text = textToShow;
    }

    void LockMode()
    {
        if (Holders.HightScore < ModeScript.ModeLockScores[modeint])
        {
            showTextOnScreen(TextWithLock.transform.GetChild(0).gameObject, "Get More then " + ModeScript.ModeLockScores[modeint].ToString() + "\n to get this mode");
            applyButton.GetComponent<Renderer>().material.color = Color.gray;
            //applyButton.GetComponent<Material>().color = Color.grey;
            applyClickable = false;
        }
        else
        {
            showTextOnScreen(TextWithLock.transform.GetChild(0).gameObject, "");
            //applyButton.GetComponent<Renderer>().material.SetColor("", new Color(60, 60, 60));
            applyButton.GetComponent<Renderer>().material.color = new Color(150, 150, 150);
            //print(applyButton.GetComponent<Renderer>().material.color);
            //applyButton.GetComponent<Color>() = Color.white;
            applyClickable = true;
        }
    }

}
