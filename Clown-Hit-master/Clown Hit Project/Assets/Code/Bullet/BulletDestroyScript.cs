using UnityEngine;
using System.Collections;

public class BulletDestroyScript : MonoBehaviour {
	
	// Use this for initialization
	void onEnable ()
	{
		Invoke ("Destroy", 2f);
	}
	
	// Update is called once per frame
	void Destroy () {
		gameObject.SetActive(false);
	}
	
	void OnDisable()
	{
		CancelInvoke ();
	}
}