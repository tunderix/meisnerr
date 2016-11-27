using UnityEngine;
using System.Collections;

public class InfoPanelHelper : MonoBehaviour {
	public Animator anim; 

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>() as Animator;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Space)) {
			showInfo ();
		}
	}

	public void hideInfo(){
		anim.SetTrigger ("hideInfo");
	}

	public void showInfo(){
		anim.SetTrigger ("showInfo");
	}
}
