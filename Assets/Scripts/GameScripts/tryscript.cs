using UnityEngine;
using System.Collections;

public class tryscript : MonoBehaviour
{
    #region variables
    public Transform obj;
    bool isVideoReady = false;
    #endregion

    void Start()
    {
        obj.GetChild(0).position = new Vector3(4, 3, 0);
        obj.GetChild(1).position = new Vector3(-4, 3, 0);
    }

    void Update()
    {
        AdManager.Instance.ShowBanner();

        if (isVideoReady == false)
        {
            isVideoReady = AdManager.Instance.LoadVidoe();
        }
    }
}
