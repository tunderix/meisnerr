using UnityEngine;
using System.Collections;

public class HeatSpot : MonoBehaviour {

	public int amountOfHeat;

	// Use this for initialization
	void Start () {
		amountOfHeat = 0; 
	}
	
	// Update is called once per frame
	void Update () {
		//In here:
		//1) Check if overlapping / triggered by Bunny... 
		//2) Heat Up --> Cool Down.. 
		//3) Trigget animation? 

	}

	public void Cool(int amount) {
		amountOfHeat = amountOfHeat + amount;
		checkUpVolume ();
	}

	public void Heat(int amount) {
		amountOfHeat = amountOfHeat - amount;
		checkUpVolume ();
	}

	private void checkUpVolume () {
		if (amountOfHeat > 10) {
			//Spot is heating up, launch Hot Spot!

		}

		if (amountOfHeat < 0) {
			//Spot is freezing! 

			//TODO!!! Cool Down // Freeze --> Bunny.

		}
	}

	public int getHeat(){
		return amountOfHeat;
	}
}
