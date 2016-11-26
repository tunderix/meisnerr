using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CounterHelper : MonoBehaviour {

    public BunnyController bunnyController;
    public Text countText;

    private int bunnyCount;

	// Use this for initialization
	void Start () {
        bunnyCount = 0;
        if(bunnyController != null)
        {
            bunnyCount = bunnyController.bunnies.Count;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (bunnyController != null)
        {
            int newCount = bunnyController.bunnies.Count;
            if (newCount != bunnyCount)
            {
                countText.text = "x " + newCount;
                bunnyCount = newCount;
            }
        }
	}
}
