using UnityEngine;
using System.Collections;
using admob;

public class AdManager : MonoBehaviour
{

    #region variables
    bool testads = false;
    public static bool isVideoReady = true;
    public static AdManager Instance { set; get; }

    public string bunnerId = "ca-app-pub-1819293788939652/2866953691";
    public string videoId = "ca-app-pub-1819293788939652/4343686897";
    #endregion

    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

        Admob.Instance().initAdmob(bunnerId, videoId);
        Admob.Instance().setTesting(testads);
        Admob.Instance().loadInterstitial();
    }

    public void ShowBanner()
    {
        Admob.Instance().showBannerRelative(AdSize.Banner, AdPosition.BOTTOM_CENTER, 0);
    }

    public void ShowVideo()
    {
        if (Admob.Instance().isInterstitialReady())
        {
            isVideoReady = true;
            Admob.Instance().showInterstitial();
        }
        else
        {
            isVideoReady = false;
            Admob.Instance().loadInterstitial();
        }
    }

    public bool LoadVidoe()
    {
        if (Admob.Instance().isInterstitialReady())
        {
            return true;
        }
        Admob.Instance().loadInterstitial();
        return false;
    }

    public void RemoveBunner()
    {
        Admob.Instance().removeBanner();
    }
}
