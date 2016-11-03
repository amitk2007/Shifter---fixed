using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {


	public Texture tx1;
	public Texture tx2;
	public Texture tx3;
	public Texture tx4;
	public SpriteRenderer rend;
	private Rigidbody2D player;

	//try
	//float timer = 1f;
	//float dealy = 1f;

	/*timer -= Time.deltaTime;
	if (timer <= 0) {
	timer = dealy;
	}*/


	// Use this for initialization
	void Start () {
		print (rend.ToString ());
	}
	
	// Update is called once per frame
	void Update () {
	/*
		if (Input.GetKey (KeyCode.A)) {
			rend.sprite = tx1;
			//rend.material.mainTexture = tx1;
		}
		if (Input.GetKey (KeyCode.B)) {
			rend.material.mainTexture = tx2;
		}*/
	}
}
