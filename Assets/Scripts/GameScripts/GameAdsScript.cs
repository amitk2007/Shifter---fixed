using UnityEngine;
using System.Collections;

public class GameAdsScript : MonoBehaviour
{
    #region variables
    public Transform obj;
    bool isVideoReady = false;
    #endregion

    void Start()
    {
        obj.GetChild(0).position = new Vector3(4, 3, 0);
        obj.GetChild(1).position = new Vector3(-4, 3, 0);
        AdManager.Instance.ShowBanner();
    }

    void Update()
    {
        if (isVideoReady == false)
        {
            isVideoReady = AdManager.Instance.LoadVidoe();
        }
    }
}
