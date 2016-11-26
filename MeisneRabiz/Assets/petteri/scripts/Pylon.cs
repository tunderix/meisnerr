using UnityEngine;
using System.Collections;

public class Pylon : MonoBehaviour {

    [Range(0.0f,1.0f)]
    public float state = 0.0f;

    public float rotSpeed = 0.0f;
    private Vector3 angle;

    void Awake()
    {
        angle = transform.localEulerAngles;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        angle.y += rotSpeed * Time.deltaTime;
        transform.localEulerAngles = angle;
    }

    public void setRotate(Vector3 eulers)
    {
        angle = eulers;
        transform.localEulerAngles = eulers;
    }

}
