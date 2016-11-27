using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;


public class BloomSlider : MonoBehaviour {

    public Bloom bloom;
    public float minValue;
    public float maxValue;
    public AnimationCurve curve;

    public Material fogMat;
    public Color startColor;
    public Color endColor;

    private float time;
    private float t;

	// Use this for initialization
	void Start () {
        time = 10.0f;
        t = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

        t += Time.deltaTime / time;

        bloom.bloomIntensity = Mathf.LerpUnclamped(minValue, maxValue, curve.Evaluate(t));
        fogMat.SetColor("_node_1695", Color.LerpUnclamped(startColor, endColor, curve.Evaluate(t)));


        if (t > 1.0f)
            t = 0.0f;

	}
}
