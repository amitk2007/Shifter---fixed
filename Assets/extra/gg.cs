using UnityEngine;
using System.Collections;

public class gg : MonoBehaviour {

	public Texture[] textures;
	public int currentTexture;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			currentTexture++;
			currentTexture%=textures.Length;
		}
	}
}


/*
 * void Sleep(float sec)
	{
		float timer = sec;

		while (timer>=0) {
			timer = timer - Time.deltaTime;
			print(timer.ToString());
		}
	}*/