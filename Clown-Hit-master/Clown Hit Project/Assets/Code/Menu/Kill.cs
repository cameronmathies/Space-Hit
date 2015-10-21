using UnityEngine;
using System.Collections;

public class Kill : MonoBehaviour {
		
	public GameObject EWave;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		Debug.Log ("Works");
		Application.LoadLevel ("Win");
	}
}
