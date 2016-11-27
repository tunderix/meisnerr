using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;


public class BloomSlider : MonoBehaviour {

    public Bloom bloom;
    public float minValue;
    public float maxValue;
    public AnimationCurve curve;

    private float time;
    private float t;

	// Use this for initialization
	void Start () {
        time = 4.0f;
        t = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

        t += Time.deltaTime / time;

        bloom.bloomIntensity = Mathf.Lerp(minValue, maxValue, curve.Evaluate(t));

        if (t > 1.0f)
            t = 0.0f;

	}
}
