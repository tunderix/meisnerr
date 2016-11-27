using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class mainmenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void loadScenen(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
