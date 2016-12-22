using UnityEngine;
using System.Collections;

public class PreLoaderScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Holders.CorrendTextureMode = Holders.GetString("TextureMode", "Classic");
        Application.LoadLevel("menu");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
