using UnityEngine;
using System.Collections;

public class Bunny : MonoBehaviour {

    public delegate void OnDied(Bunny bunny);
    public event OnDied onDied;

    public delegate void OnPairing(Bunny bunny);
    public event OnPairing onPairing;

    //State from 0...1 --> initial 0-0.5
    public float state;
	public float stateChangeSpeed;
	private int direction = 1 ; // 1 == incrementing, -1 decrementing

    [Range(0.0f, 1.0f)]
    public float pairingThreshold;
    public float forceAmmount;

    public Renderer render;

    public float tempPerCollision;
    public float tempRiseSpeed;
    float mTemperature = 0.0f;
    public float temperature { get { return mTemperature; } }

    private float angle; 
	private Vector3 position; 
	private float acceleration;
    private Rigidbody rb;
    public Animator animator;
    private bool mayPair = false;

    public bool debugEnabled;
	// Use this for initialization
	void Start () {
        initialize ();
        StartCoroutine(pulsingMovement());
        mayPair = false;
        disableMayPairFor(1.0f);
    }
	
	// Update is called once per frame
	void Update () {

        state += stateChangeSpeed * direction * Time.deltaTime;
        if (state < 0.0f || state > 1.0f)
            direction *= -1;

        state = Mathf.Clamp01(state);

        setTemperature(mTemperature + tempRiseSpeed*Time.deltaTime);

        if (debugEnabled) {
			Debug.Log ("State changin: " + this.state);
		}

        if (rb.velocity.y > 0.1f)
        {
            animator.SetTrigger("fall");
        }else if(rb.velocity.sqrMagnitude < 0.1f)
        {
            animator.SetTrigger("idle");
        }

        if (transform.position.y < -10.0f)
        {
            if (onDied != null)
                onDied(this);
        }
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

            addForce(force.normalized * forceAmmount);
            animator.SetTrigger("run");
            yield return new WaitForSeconds(Random.Range(1.0f, 2.5f));
        }
    }

    public void addForce(Vector3 force)
    {
        rb.AddForce(force);
    }


    void setTemperature(float temperature)
    {
        mTemperature = Mathf.Clamp01(temperature);
        Color c = Color.Lerp(Color.green, Color.red, temperature);
        Material[] mats = render.materials;
        mats[0].color = c;
        mats[1].color = c;
        render.materials = mats;

        if (mTemperature >= 1.0f && onDied != null)
            onDied(this);
    }

    public void reduceTemperature(float ammount)
    {
        setTemperature(mTemperature - ammount);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bunny"))
        {
            //Debug.Log("---OnTriggerEnter---Bunny---");
            setTemperature(mTemperature + tempPerCollision);
            animator.SetTrigger("knockback");
            animator.SetTrigger("run");
            
            Bunny other = collision.gameObject.GetComponent<Bunny>();

            //Debug.Log("------mayPair"+ mayPair+" other.mayPair:"+ other.mayPair + " mTemperature:"+ mTemperature + " other.mTemperature:" + other.mTemperature);

            if (mayPair && other.mayPair && mTemperature < pairingThreshold && other.mTemperature < pairingThreshold)
            {
                //Debug.Log("--------PAIRING-----");
                if (onPairing != null)
                    onPairing(this);

                disableMayPairFor(0.5f);
            }

        }
        else if (collision.gameObject.CompareTag("pylon"))
        {
            //Debug.Log("---OnTriggerEnter---pylon---");
            setTemperature(mTemperature + tempPerCollision * 1.5f);
            animator.SetTrigger("knockback");
            animator.SetTrigger("run");
        }
    }

    Coroutine disableMayPairForCo;
    void disableMayPairFor(float time)
    {
        //Debug.Log("--------disableMayPairFor-----");
        if (disableMayPairForCo != null)
            StopCoroutine(disableMayPairForCo);

        disableMayPairForCo = StartCoroutine(doDisableMayPairFor(time));
    }

    IEnumerator doDisableMayPairFor(float time)
    {
        //Debug.Log("--------doDisableMayPairFor-----");
        yield return null;
        mayPair = false;
        //Debug.Log("--------mayPair-FALSE-----");
        yield return new WaitForSeconds(time);
        mayPair = true;
        //Debug.Log("--------mayPair-TRUE-----");
    }
}
