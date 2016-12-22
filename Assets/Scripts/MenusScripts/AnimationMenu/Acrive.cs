using UnityEngine;
using System.Collections;

public class Acrive : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnMouseDown()
    {
        switch (this.gameObject.name)
        {
            case "Play":
                Application.LoadLevel("game");
                break;
            case "Settings":
                Application.LoadLevel("Settings");
                break;
            case "HowToPlay":
                Application.LoadLevel("HowToPlay");
                break;

            default:
                break;
        }
    }
}
