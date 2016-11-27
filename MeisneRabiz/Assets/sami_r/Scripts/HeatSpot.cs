using UnityEngine;
using System.Collections;

public class HeatSpot : MonoBehaviour {

	public int amountOfHeat;
	public GameObject heatController;


	public Vector3 pos;
	// Use this for initialization
	void Start () {
		amountOfHeat = 0; 
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Cool(int amount) {
		amountOfHeat = amountOfHeat - amount;
		checkUpVolume ();
	}

	public void Heat(int amount) {
		amountOfHeat = amountOfHeat + amount;
		checkUpVolume ();
	}

	private void checkUpVolume () {
		if (amountOfHeat > 30) {
			//Spot is heating up, launch Hot Spot!
			spawnHeatMarker();
		}

		if (amountOfHeat < 0) {
			//Spot is freezing! 

			//TODO!!! Cool Down // Freeze --> Bunny.

			spawnHeatMarker();
		}
	}

	public int getHeat(){
		return amountOfHeat;
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "bunny") {
			Heat (2);
		}
	}

	void spawnHeatMarker(){
		Instantiate(heatController, pos, Quaternion.identity);
	}
}
