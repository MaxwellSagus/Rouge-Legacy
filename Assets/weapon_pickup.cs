using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon_pickup : MonoBehaviour {

    public GameObject hand;
    Vector3 zero = new Vector3(0, 0, 0);
    Vector3 SwordRotation = new Vector3(0, 35, 0);
    
    
	// Use this for initialization
	void Start () {

        

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "holdable")
        {
            collider.transform.position = hand.transform.position;
            collider.transform.rotation = Quaternion.FromToRotation(zero,SwordRotation);

            collider.transform.parent = hand.transform;
        }
    }
}
