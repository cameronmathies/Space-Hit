using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public float max_Health = 100f;
	public float cur_Health = 0f;


	void Start (){
		cur_Health = max_Health;
		InvokeRepeating ("decreasehealth", 1f, 1f);
	}

	void decreasehealth(){
		cur_Health -= 2f;
	}
}