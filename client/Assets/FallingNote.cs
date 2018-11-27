using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingNote : MonoBehaviour {
	public float deltaTime;

	// Use this for initialization
	void Start () {
		
	}
	

	// Update is called once per frame
	void Update () {

		var oldDt = deltaTime;

		deltaTime = (transform.position.y-50) / Game.Instance.speed;

		var forceHit = Game.Instance.autoplay && Mathf.Abs(deltaTime) > Mathf.Abs(oldDt);

		if (forceHit || (Mathf.Abs(deltaTime) < 0.180f && Input.GetButtonDown(name)) || deltaTime < -1){
			Game.Instance.Judge(deltaTime);
			Destroy(gameObject);
		}


		//print(transform.position.y);

	}
}
