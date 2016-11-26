using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PylonController : MonoBehaviour {

    public GameObject pylonPrefab;
    public int pylonCount;

    List<Pylon> pylons;

	// Use this for initialization
	void Start () {
        pylons = new List<Pylon>();
        CreatePylon(pylonCount);
    }
	
	// Update is called once per frame
	void Update () {
	
	}


    void CreatePylon(int count)
    {
        Vector3 rot = Vector3.zero;
        for (int i = 0; i < count; ++i)
        {
            GameObject pylonGo = Instantiate(pylonPrefab);
            pylonGo.transform.SetParent(transform, false);

            Pylon pylon = pylonGo.GetComponent<Pylon>();
            pylons.Add(pylon);
            pylon.state = i % 2 == 0 ? PylonState.s0 : PylonState.s1;

            rot.y = i * (360 / count);
            pylon.setRotate(rot);

            if (i > 0)
            {
                pylon.pylonLeft = pylons[i - 1];
                pylons[i - 1].pylonRigth = pylon;
            }
        }

        pylons[0].pylonLeft = pylons[count - 1];
        pylons[count - 1].pylonRigth = pylons[0];
    }

}
