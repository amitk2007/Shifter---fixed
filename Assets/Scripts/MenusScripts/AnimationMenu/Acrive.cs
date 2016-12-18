using UnityEngine;
using System.Collections;

public class Acrive : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        print(";");
	}

    void OnMouseDown()
    {
        print("ok");

        switch (this.gameObject.name)
        {
            default:
                break;
        }
        if (this.gameObject.name == "Play")
        {
            Application.LoadLevel("game");
        }
        if (this.gameObject.name =="Settings")
        {
            Application.LoadLevel("Settings");
        }
        if (this.gameObject.name == "HowToPlay")
        {
            Application.LoadLevel("HowToPlay");
        }
    }
}
