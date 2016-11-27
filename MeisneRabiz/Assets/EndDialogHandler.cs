using UnityEngine;
using System.Collections;

public class EndDialogHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void show()
    {
        RectTransform rt = GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector2(0, 0);
    }


    public void restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("IntegrationScene");
    }

}
