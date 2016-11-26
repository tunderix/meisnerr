using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BunnyController : MonoBehaviour {

	public GameObject bunnyPrefab;

	//Parameters for spawning new bunnies! 
	public int quantity;
	public int thickness; 
	public float radius;

    //Parameters for handling bunnies.
    private List<Bunny> mBunnies = new List<Bunny>();
    private List<Bunny> bunnies { get { return mBunnies; } }


    void Start () {
		SpawnBunnies ();
        StartCoroutine(spawnMoreBunnies(0.5f));
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

        return b;
    }

    void bunnyDied(Bunny bunny)
    {
        bunny.onDied -= bunnyDied;
        mBunnies.Remove(bunny);
        Destroy(bunny.gameObject);
    }


	//generate 3D position on top of game area! 
	Vector3 generateRandomPosition() {

		Vector3 randomPos = Random.insideUnitSphere * radius;
		//Vector3 position = levitatingTerrain.transform.position;
		randomPos.y = bunnyPrefab.transform.position.y;

		Debug.Log ("Generating random pos: " + randomPos.ToString());
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

}
