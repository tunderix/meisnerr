using UnityEngine;
using System.Collections;

public enum PylonState
{
    s0,
    s1
}

public class Pylon : MonoBehaviour {

    public PylonState state = PylonState.s0;

    public Pylon pylonLeft;
    public Pylon pylonRigth;

    private Vector3 angle;
    public float angleY { get { return angle.y; } }


    void Awake()
    {
        angle = transform.localEulerAngles;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        angle.y += 2.0f * Time.deltaTime;
        transform.localEulerAngles = angle;
    }

    public void setRotate(Vector3 eulers)
    {
        angle = eulers;
        transform.localEulerAngles = eulers;
    }

}
