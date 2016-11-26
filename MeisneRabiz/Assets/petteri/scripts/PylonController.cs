using UnityEngine;
using System.Collections;

public class PylonController : MonoBehaviour {

    public Pylon[] pylons;

	// Use this for initialization
	void Start () {
        int count = pylons.Length;
        Vector3 rot = Vector3.zero;

        for(int i=0; i<count; ++i)
        {
            rot.y = i * (360 / count);
            pylons[i].setRotate(rot);
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
