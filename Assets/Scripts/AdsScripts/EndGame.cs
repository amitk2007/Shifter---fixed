using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{

    public GameObject Text;
    bool activBunner = true;
    // Use this for initialization
    void Start()
    {
        AdManager.Instance.ShowBanner();
        Text.GetComponent<Text>().text = AdManager.isVideoReady.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (activBunner == true)
        {
            AdManager.Instance.ShowBanner();
        }
    }

    public void changebool()
    {
        activBunner = !activBunner;
    }

    public void StartGame()
    {
        Application.LoadLevel("MainGame");
    }
}
