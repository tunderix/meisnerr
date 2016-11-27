using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class HeatSpotController : MonoBehaviour {

	private List<GameObject> heatSpots;
	public GameObject heatSpotPrefab;
	private GameObject ground; 
	public float radiusForHeatSpots;

	public int size;

	// Use this for initialization
	void Start () {
		heatSpots = new List<GameObject> ();
		generateHeatSpots ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void generateHeatSpots () {
		for (int y = 0; y < size - 1; y++) {
			for (int x = 0; x < size - 1; x++) {
				RaycastHit hit;
				float posX = -(size/2) + x;
				float posY = -(size/2) + y;
				Vector3 position = new Vector3 (posX, 2.5f, posY); 

				Debug.DrawRay (position, transform.TransformDirection (Vector3.down),Color.red,50.0f);
				if (Physics.Raycast(position, transform.TransformDirection(Vector3.down),out hit,50.0f)) {
					Debug.Log ("Hit On : " + hit.collider.gameObject.name);
					//Destroy (hs);
					//position.y = 0.01f;
					summonHeatSpot (position);
				}
			}
		}

	}

	private void summonHeatSpot(Vector3 position){
		GameObject hs = (GameObject)Instantiate (heatSpotPrefab, position, transform.rotation);
		hs.GetComponent<HeatSpot> ().pos = position;
		heatSpots.Add (hs);
	}
}
