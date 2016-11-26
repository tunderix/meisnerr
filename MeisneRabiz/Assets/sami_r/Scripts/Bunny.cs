using UnityEngine;
using System.Collections;

public class Bunny : MonoBehaviour {

	//State from 0...1 --> initial 0-0.5
	public float state;
	public float stateChangeSpeed;
	private int direction; //0 == incrementing, 1 decrementing


	private float angle; 
	private Vector3 position; 
	private float acceleration; 


	public bool debugEnabled;
	// Use this for initialization
	void Start () {
		initialize ();	
		Debug.Log ("Mrrlrlrlrlll --> I Am HERE!!");
	}
	
	// Update is called once per frame
	void Update () {
		if (direction == 0) {
			if (state < 1) {
				state = state + (1 * stateChangeSpeed);
			} else {
				direction = 1;
			}

		}else if (direction == 1) {
			if (state > 0) {
				state = state - (1 * stateChangeSpeed);
			} else {
				direction = 0;	
			}
		}
		if (debugEnabled) {
			Debug.Log ("State changin: " + this.state);
		}
	}

	private void initialize () {
		debugEnabled = false;
	}
		
}
