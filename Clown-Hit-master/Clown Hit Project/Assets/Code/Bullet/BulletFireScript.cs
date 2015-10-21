//using UnityEngine;
//using System.Collections;
//using System.Collections.Generic;
//
//public class BulletFireScript : MonoBehaviour {
//	
//	public float fireTime = .05f;
//	//	public GameObject bullet;
//	//
//	//	public int pooledAmount = 20;
//	//	List<GameObject> bullets;
//	
//	// Use this for initialization
//	void Start () {
//		//		bullets = new List<GameObject> ();
//		//		for(int i = 0; i < pooledAmount; i++) {
//		//			GameObject obj = (GameObject)Instantiate(bullet);
//		//			obj.SetActive(false);
//		//			bullets.Add(obj);
//		//		}
//		
//		InvokeRepeating ("Fire", fireTime, fireTime);
//		
//	}
//	
//	// Update is called once per frame
//	void Fire () {
//		//		for(int i = 0; i < bullets.Count; i++)
//		//		{
//		//			if(!bullets[i].activeInHierarchy)
//		//			{	
//		GameObject obj = NewObjectsPooling.current.GetPooledObject();
//		
//		if (obj == null) return;
//		
//		obj.transform.position = transform.position;
//		obj.transform.rotation = transform.rotation;
//		obj.SetActive(true);
//		break;
//	}
//}