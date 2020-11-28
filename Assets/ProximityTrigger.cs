using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityTrigger : MonoBehaviour
{
	public Animator animation;
	public AudioSource recording;

	void onTriggerEnter (Collider other)
	{
		animation.Play("sss");
		recording.Play();
		Debug.Log("Touching");
		
		
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
