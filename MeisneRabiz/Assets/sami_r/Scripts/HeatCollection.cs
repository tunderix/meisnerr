using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class HeatCollection : MonoBehaviour {

	public List<Texture2D> textures;

	private float spotAngle; //30 - 70
	private float intensity; //0 - 3


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.A)) {
			this.setRandomTexture ();
		}
	}

	void setRandomTexture(){
		//Choose one texture from textures and use it as light cookie! 
		Texture2D randomTexture = textures[(Random.Range(0,textures.Count-1))];
		this.GetComponentInChildren<Light> ().cookie = randomTexture;
	}
}
