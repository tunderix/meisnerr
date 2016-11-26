using UnityEngine;
using System.Collections;

public class Bunny : MonoBehaviour {

	//State from 0...1 --> initial 0-0.5
	public float state;
	public float stateChangeSpeed;
	private int direction = 1 ; // 1 == incrementing, -1 decrementing

    
    public float forceAmmount;

    public Renderer render;

    public float tempPerCollision;
    float temperature = 0.0f;

    private float angle; 
	private Vector3 position; 
	private float acceleration;
    private Rigidbody rb;

    public bool debugEnabled;
	// Use this for initialization
	void Start () {
		initialize ();
        StartCoroutine(pulsingMovement());
	}
	
	// Update is called once per frame
	void Update () {

        state += stateChangeSpeed * direction;
        if (state < 0.0f || state > 1.0f)
            direction *= -1;

        state = Mathf.Clamp01(state);

        if (debugEnabled) {
			Debug.Log ("State changin: " + this.state);
		}

        if (transform.position.y < -10.0f)
            Destroy(gameObject);

	}

	private void initialize () {
		debugEnabled = false;
        rb = GetComponent<Rigidbody>();
	}
	

    IEnumerator pulsingMovement()
    {
        yield return new WaitForSeconds(1.0f);

        while (true)
        {
            Vector3 force = Random.onUnitSphere;
            force.y = Mathf.Abs(force.y);

            force.y = 0.0f;

            rb.AddForce(force.normalized * forceAmmount);
            yield return new WaitForSeconds(Random.Range(0.5f, 1.5f));
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bunny"))
        {
            Debug.Log("---OnTriggerEnter---Bunny---");
            temperature += tempPerCollision;
            Material[] sharedMats = render.sharedMaterials;
            Material[] mats = render.materials;
            mats[0] = sharedMats[0];
            mats[1].color = Color.Lerp(Color.green, Color.red, temperature);
            render.materials = mats;
        }
    }

}
