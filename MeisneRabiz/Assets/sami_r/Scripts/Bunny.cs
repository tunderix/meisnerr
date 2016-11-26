using UnityEngine;
using System.Collections;

public class Bunny : MonoBehaviour {

	//State from 0...1 --> initial 0-0.5
	public float state;
	public float stateChangeSpeed;
	private int direction = 1 ; // 1 == incrementing, -1 decrementing

    public float forceAmmount;

    private float angle; 
	private Vector3 position; 
	private float acceleration;
    private Rigidbody rb;

    public bool debugEnabled;
	// Use this for initialization
	void Start () {
		initialize ();
        StartCoroutine(pulsingMovement());
		Debug.Log ("Mrrlrlrlrlll --> I Am HERE!!");
	}
	
	// Update is called once per frame
	void Update () {
		//if (direction == 0) {
		//	if (state < 1) {
		//		state = state + (1 * stateChangeSpeed);
		//	} else {
		//		direction = 1;
		//	}

		//}else if (direction == 1) {
		//	if (state > 0) {
		//		state = state - (1 * stateChangeSpeed);
		//	} else {
		//		direction = 0;
		//	}
		//}

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

            rb.AddForce(force * forceAmmount);
            yield return new WaitForSeconds(Random.Range(0.5f, 1.5f));
        }
    }

}
