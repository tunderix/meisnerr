using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PylonController : MonoBehaviour {

    public GameObject pylonPrefab;
    public int pylonCount;

    List<Pylon> mPylons;
    public List<Pylon> pylons {
        get { return mPylons; }
    }

    // Use this for initialization
    void Start () {
        mPylons = new List<Pylon>();
        CreatePylon(pylonCount);
        StartCoroutine(randomPylonStateChange());
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void CreatePylon(int count)
    {
        float rot = 0.0f;
        for (int i = 0; i < count; ++i)
        {
            GameObject pylonGo = Instantiate(pylonPrefab);
            pylonGo.transform.SetParent(transform, false);
            pylonGo.transform.localPosition = Vector3.zero;

            Pylon pylon = pylonGo.GetComponent<Pylon>();
            mPylons.Add(pylon);
            pylon.state = i % 2;

            rot = i * (360 / count);
            pylon.setRotateY(rot);

            if (i > 0)
            {
                pylon.pylonLeft = mPylons[i - 1];
                mPylons[i - 1].pylonRigth = pylon;
            }
        }

        mPylons[0].pylonLeft = mPylons[count - 1];
        mPylons[count - 1].pylonRigth = mPylons[0];
    }

    IEnumerator randomPylonStateChange()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(3.0f, 6.0f));

            Pylon pylon = mPylons[Random.Range(0, mPylons.Count)];
            pylon.changePylonState(Random.value > 0.4f, 10.0f);
        }
    }

}
