using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	
	public float speed = 5;
	
	// Update is called once per frame
	void Update () {
			Input.GetKey(KeyCode.Escape);
		transform.Translate (0, 0, -1);
	}
}