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
		generateHeatSpots ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void generateHeatSpots () {
		//Vector3 positionForHeatSpot = new Vector3 ();

		//-------
		//!     !
		//!	    !
		//-------

		//Split the ground in 10 rows and 10 columns.... 
		//Shoot a raycast from center of the cell. 
		//Summon a new HeatSpot in the center of cell if rayCast hit the ground!. 
		//Radius = 5???? 
		for (int y = 0; y < size - 1; y++) {
			for (int x = 0; x < size - 1; x++) {
				//check with raycast! 
				RaycastHit hit;
				float posX = -(size/2) + x;
				float posY = -(size/2) + y;

				Vector3 position = new Vector3 (posX, 0.01f, posY); 

				GameObject hs = summonHeatSpot (position);
				Debug.DrawRay (position, transform.TransformDirection (Vector3.down),Color.red,20.0f);

				if (Physics.Raycast(position, transform.TransformDirection(Vector3.down),10.0f)) {
					Debug.Log ("OmNomNom... Heating. row: " + y);

					hs.GetComponent<HeatSpot> ().amountOfHeat = 1;
					/*if (hit.collider.gameObject.name == "ground") {
					}*/
				}
			}
		}

	}

	private GameObject summonHeatSpot(Vector3 position){
		GameObject hs = (GameObject)Instantiate (heatSpotPrefab,position,transform.rotation);
		return hs;
	}
}
