using UnityEngine;
using System.Collections;

public enum PylonType
{
    type1,
    type2
}

public class Pylon : MonoBehaviour {

    public delegate void OnPressed(Pylon pylon);
    public event OnPressed onPressed;

    [Range(0.0f,1.0f)]
    public float state = 0.0f;
    public PylonType type = PylonType.type1;

    public Pylon pylonLeft;
    public Pylon pylonRigth;

    public float rotateSpeed = 2.0f;

    private Vector3 angle;
    public float angleY {
        get {
            return angle.y;
        }
        set {
            setRotateY(value);
        }
    }

    static float angleSize = 25.0f;

    void Awake()
    {
        angle = transform.localEulerAngles;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        angle.y += rotateSpeed * Time.deltaTime;
        transform.localEulerAngles = angle;
    }

    public void setRotateY(float y)
    {
        if(pylonLeft != null)
        {
            float AngleLeft = pylonLeft.angleY;
            if (AngleLeft > angleY)
                AngleLeft -= 360.0f;

            y = Mathf.Max(AngleLeft + angleSize, y);
        }

        if (pylonRigth != null)
        {
            float AngleRigth = pylonRigth.angleY;
            if (AngleRigth < angleY)
                AngleRigth += 360.0f;

            y = Mathf.Min(AngleRigth - angleSize, y);
        }

        angle.y = y;
        transform.localEulerAngles = angle;
    }

    Coroutine chargeCo;
    public void changePylonState(bool onOff, float time)
    {
        if (onOff)
            chargePylon(time);
        else
            dischargePylon(time);
    }

    public void chargePylon(float time)
    {
        if(chargeCo != null)
        {
            StopCoroutine(chargeCo);
        }

        chargeCo = StartCoroutine(doChargePylon(time));
    }

    IEnumerator doChargePylon(float time)
    {
        if(type == PylonType.type1)
        {
            yield return new WaitForSeconds(time);
            state = 1.0f;
        }
        else if(type == PylonType.type2)
        {
            while (state < 1.0f)
            {
                state += Time.deltaTime / time;
                yield return null;
            }
        }
    }

    public void dischargePylon(float time)
    {
        if (chargeCo != null)
        {
            StopCoroutine(chargeCo);
        }

        chargeCo = StartCoroutine(doDischargePylon(time));
    }

    IEnumerator doDischargePylon(float time)
    {
        if (type == PylonType.type1)
        {
            yield return new WaitForSeconds(time);
            state = 0.0f;
        }
        else if (type == PylonType.type2)
        {
            while (state > 0.0f)
            {
                state -= Time.deltaTime / time;
                yield return null;
            }
        }
    }


    public void pylonPressed()
    {
        if (onPressed != null)
        {
            onPressed(this);
        }
    }

}
