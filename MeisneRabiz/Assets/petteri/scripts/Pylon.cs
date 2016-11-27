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

    public GameObject colliderGo;
    private Vector3 colliderScale;

    public Renderer pylonEffectRenderer;
    Material pylonEffectMateria;

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
        colliderScale = colliderGo.transform.localScale;
        pylonEffectMateria = pylonEffectRenderer.material;
    }

	// Use this for initialization
	void Start () {
        setState(state);
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


    void setState(float newState)
    {
        state = Mathf.Clamp01(newState);
        colliderScale.z = 1.0f + state * 2;
        colliderGo.transform.localScale = colliderScale;
        pylonEffectMateria.SetFloat("_Multiplier", state);
    }

    Coroutine pylonPressedCo;
    IEnumerator doPylonPressed()
    {
        if (type == PylonType.type1)
        {
            float time = 3.0f;
            float t = 0.0f;
            while (t < 1.0f)
            {
                t += Time.deltaTime / time;
                setState(Mathf.Lerp(0.0f, 1.0f, t));

                yield return null;
            }

            yield return new WaitForSeconds(5.0f);

            time = 1.0f;
            t = 0.0f;
            while (t < 1.0f)
            {
                t += Time.deltaTime / time;
                setState(Mathf.Lerp(1.0f, 0.0f, t));

                yield return null;
            }
        }
        else if (type == PylonType.type2)
        {
            setState(1.0f);
            yield return new WaitForSeconds(2.5f);
            setState(0.0f);
        }

        pylonPressedCo = null;
    }




    public void pylonPressed()
    {
        if (pylonPressedCo == null)
            pylonPressedCo = StartCoroutine(doPylonPressed());
    }

}
