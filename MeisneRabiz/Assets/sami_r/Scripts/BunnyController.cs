using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BunnyController : MonoBehaviour {

	public GameObject bunnyPrefab;
    public Collider floorCollider;
    public GameObject bunnyDeathParticlePrefab;

	//Parameters for spawning new bunnies! 
	public int quantity;
	public int thickness; 
	public float radius;

    //Parameters for handling bunnies.
    private List<Bunny> mBunnies = new List<Bunny>();
    public List<Bunny> bunnies { get { return mBunnies; } }


    void Start () {
		SpawnBunnies ();
        StartCoroutine(spawnMoreBunnies(1.5f));
	}

	// Update is called once per frame
	void Update () {
		
	}

	//Function for controlling amount/quantity of bunnies, starting position..... 
	void SpawnBunnies () {

		//Vector3[] positions = new Vector3[quantity];
		List<Vector3> positions = new List<Vector3>();

		for (int i = 0; i < quantity - 1; i++) {
			// Generate locations//vector3s --> Spawn points. 
			positions.Add(generateRandomPosition());

			//TODO!!!! 
			//Check up that we do NOT overlap with other coords. 
		}



		for (int i = 1; i < positions.Count; i++) {
			GenerateBunny(positions[i]);
		}
	}

    Bunny GenerateBunny (Vector3 spawnPoint) {
        GameObject go = Instantiate(bunnyPrefab, spawnPoint, bunnyPrefab.transform.rotation) as GameObject;

        Bunny b = go.GetComponent<Bunny>();
        mBunnies.Add(b);

        b.onDied += bunnyDied;
        b.onPairing += bunnyPaired;

        return b;
    }

    void bunnyDied(Bunny bunny)
    {
        bunny.onDied -= bunnyDied;
        bunny.onPairing += bunnyPaired;
        mBunnies.Remove(bunny);
        

        GameObject particleGo = Instantiate(bunnyDeathParticlePrefab);
        particleGo.transform.position = bunny.transform.position;

        Destroy(bunny.gameObject, 0.1f);
        Destroy(particleGo, 1.0f);
    }

    void bunnyPaired(Bunny bunny)
    {
        //Debug.Log("-------------bunnyPaired----------------");

        Vector3 offset = Random.onUnitSphere;
        offset.y = 0.0f;
        offset.Normalize();
        offset = offset * 2.0f;

        GenerateBunny(bunny.transform.position + offset);
    }

	//generate 3D position on top of game area! 
	Vector3 generateRandomPosition() {

		Vector3 randomPos = Random.insideUnitSphere * radius;
		//Vector3 position = levitatingTerrain.transform.position;
		randomPos.y = bunnyPrefab.transform.position.y;

		//Debug.Log ("Generating random pos: " + randomPos.ToString());
		return randomPos;
	}

    IEnumerator spawnMoreBunnies(float interval)
    {
        while(true)
        {
            Vector3 pos = Random.insideUnitSphere * radius;
            pos.y = 10.0f;
            Bunny bunny = GenerateBunny(pos);

            Rigidbody rb = bunny.GetComponent<Rigidbody>();
            pos.y = 0.0f;
            rb.AddForce(-pos * 50f);

            yield return new WaitForSeconds(interval);
        }
    }


    public void shootCold(Vector3 screenpoint)
    {
        Ray ray = Camera.main.ScreenPointToRay(screenpoint);

        RaycastHit hit;
        if(floorCollider.Raycast(ray, out hit, 100.0f))
        {
            Vector3 point = ray.GetPoint(hit.distance);

            // cool near bunnies down
            foreach (Bunny bunny in bunnies)
            {
                if(Vector3.Distance(point, bunny.transform.position) <= 5.0f)
                {
                    bunny.reduceTemperature(1.0f);
                }
            }

            // temp sphere to see where hit
            //GameObject s = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            //s.transform.position = point;
            //s.transform.localScale = Vector3.one * 5.0f;
            //Destroy(s, 1.0f);
        }
    }

}
