using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BulletFireScript : MonoBehaviour {
	
	public float fireTime = 1f;
	public float reload = .05f;
	public GameObject bullet;
	
	public int pooledAmount = 20;
	List<GameObject> bullets;
	
	// Use this for initialization
	void Start () {
		bullets = new List<GameObject> ();
		for(int i = 0; i < pooledAmount; i++) {
			GameObject obj = (GameObject)Instantiate(bullet);
			obj.SetActive(false);
			bullets.Add(obj);
		}
		
		InvokeRepeating ("Fire", fireTime, fireTime);
		
	}
	
	// Update is called once per frame
	void Fire () {
		for(int i = 0; i < bullets.Count; i++)
		{
			if(!bullets[i].activeInHierarchy)
			{	
				
				
				if (!bullets[i].activeInHierarchy)
					
					bullets[i].transform.position = transform.position;
				bullets[i].transform.rotation = transform.rotation;
				bullets[i].SetActive(true);
				break;
			}
		}
	}
}
