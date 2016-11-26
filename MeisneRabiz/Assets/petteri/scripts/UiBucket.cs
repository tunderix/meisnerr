using UnityEngine;
using System.Collections;

public class UiBucket : MonoBehaviour {

    public BunnyController bunnyContr;

    UiDrag drag;

    void Awake()
    {
        drag = GetComponent<UiDrag>();
    }

	// Use this for initialization
	void Start () {
        if (drag)
        {
            drag.onDragend += dragend;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void dragend(UiDrag drag)
    {
        bunnyContr.shootCold(Input.mousePosition);
        drag.MoveToLocal(drag.startPosition, 0.5f);
    }

}
