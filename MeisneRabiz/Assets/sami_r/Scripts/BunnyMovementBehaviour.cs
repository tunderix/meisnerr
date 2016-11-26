using UnityEngine;
using System.Collections;

public class BunnyMovementBehaviour : MonoBehaviour {

	private GameObject bunny;

	//Bunny Movement behaviour happens in pulses! Speed, Heat, length---> 
	private float speed;

	void Start () {
		bunny = this.gameObject;
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			//pushBunny ();
		}
	}

	void pushBunny () {
		float yPos = bunny.transform.position.y;
		Vector3 q = Quaternion.AngleAxis (Random.Range (0, 360), Vector3.up).eulerAngles;
		q.y = yPos;
		bunny.GetComponent<CharacterController> ().Move (q);

	}
}
