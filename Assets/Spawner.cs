using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour

{	
	public GameObject spawn;
	public Transform startPosRot;
	public Rigidbody ballBody;
	
    // Start is called before the first frame update
    void Start()
    {
      spawn.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

		if (spawn.activeSelf){
			
			Rigidbody ballSpawn;
			ballSpawn = Instantiate(ballBody, startPosRot.position, startPosRot.rotation);
			ballSpawn.AddForce(startPosRot.forward * 5000f);

			spawn.SetActive(false);

		}
			

    }

}
