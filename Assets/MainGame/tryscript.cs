using UnityEngine;
using System.Collections;

public class tryscript : MonoBehaviour {

	public Transform obg;
	void Start () {
		obg.GetChild(0).position = new Vector3 (4,3,0);
		obg.GetChild(1).position = new Vector3 (-4,3,0);
	}
}
