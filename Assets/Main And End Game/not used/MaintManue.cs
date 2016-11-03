using UnityEngine;
using System.Collections;

public class MaintManue : MonoBehaviour {

	public Texture BackgroundTexture;
	public GUISkin theSkin;
    public Transform player;
	
	float middleScreenX = Screen.width * 0.25f;
	float middleScreenY = Screen.height * 0.5f;
	float buttonSizeX = Screen.width * 0.5f;
	float buttonSizeY = Screen.height * 0.1f;

	void OnGUI()
	{
		GUI.skin = theSkin;
		theSkin.label.fontSize =  Screen.height/(7);
		//Display our Background Texture
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height),BackgroundTexture);
		//Display our Buttons (with GUI outline)
		GUI.Label (new Rect (middleScreenX, middleScreenY - (buttonSizeY)-100, buttonSizeX*2, buttonSizeY*2), "Game Over");

		if (GUI.Button (new Rect (middleScreenX, middleScreenY - (buttonSizeY), buttonSizeX, buttonSizeY), "Main Manu")) {
			Application.LoadLevel("normal pong");
			//UnityEditor.EditorApplication.OpenScene("Assets/normal pong.unity");
		}
		if (GUI.Button (new Rect (middleScreenX, middleScreenY + (buttonSizeY), buttonSizeX, buttonSizeY), "Quit")) {
		}
	}	
	
	void Update () {
		if (Input.GetKey (KeyCode.Z)) {
			Application.LoadLevel ("zombie pong");
		}
	}
}

