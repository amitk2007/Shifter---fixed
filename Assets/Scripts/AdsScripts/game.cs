using UnityEngine;
using System.Collections;

public class game : MonoBehaviour
{
    bool shown = false;
    public GameObject player;
    Vector3 pozition = new Vector3(1, 1, 1);
    // Use this for initialization
    void Start()
    {
        AdManager.Instance.ShowVideo();
    }

    // Update is called once per frame
    void Update()
    {
        if (shown == false)
        {
            ShowInterstitial();

        }

    }

    public void ShowInterstitial()
    {
        if (AdManager.isVideoReady == false)
        {
            AdManager.Instance.ShowVideo();
        }
        else if (AdManager.isVideoReady == true)
        {
            AdManager.Instance.ShowVideo();
            shown = true;
        }
        else
        {
            Debug.Log("Interstitial is not ready yet.");
        }
    }
}
