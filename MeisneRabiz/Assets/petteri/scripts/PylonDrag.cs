using UnityEngine;
using System.Collections;

public class PylonDrag : MonoBehaviour {

    public Pylon pylon;
    public float sensitivity = 2.0f;

    Plane mDragPlane;

	// Use this for initialization
	void Start () {
        Vector3 pylPos = pylon.transform.position;
        Vector3 normal = pylPos - Camera.main.transform.position;

        mDragPlane = new Plane(normal, pylPos);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    Vector3 startPoint;
    Vector3 prevPoint;

    void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        float distance;
        if(mDragPlane.Raycast(ray, out distance))
        {
            Vector3 point = ray.GetPoint(distance);
            startPoint = point;
            prevPoint = point;
        }
    }

    void OnMouseDrag()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        float distance;
        if (mDragPlane.Raycast(ray, out distance))
        {
            Vector3 point = ray.GetPoint(distance);
            Vector3 dif = point - prevPoint;

            pylon.angleY = pylon.angleY + dif.x * sensitivity;

            prevPoint = point;
        }
    }

}
