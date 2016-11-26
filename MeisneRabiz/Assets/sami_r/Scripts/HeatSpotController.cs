using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class HeatSpotController : MonoBehaviour {

	private List<GameObject> heatSpots;
	public GameObject heatSpotPrefab;
	private GameObject ground; 
	public float radiusForHeatSpots;

	public int rows;
	public int columns;

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
		for (int y = 0; y < columns - 1; y++) {
			for (int x = 0; x < rows - 1; x++) {
				//check with raycast! 
				RaycastHit hit;
				float posX = -5 + 1 * x;
				float posY = -5 + 1 * y;

				Vector3 position = new Vector3 (posX, 0.5f, posY); 

				Debug.DrawRay (position, transform.TransformDirection (Vector3.down),Color.red,20.0f);

				if (Physics.Raycast(position, transform.TransformDirection(Vector3.down),10.0f)) {
					Debug.Log ("OmNomNom... Heating. row: " + y);

					GameObject hs = summonHeatSpot (position);
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
