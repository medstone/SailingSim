using UnityEngine;
using System.Collections;

public class boatMovement : MonoBehaviour {
    public float shipSpeed;
    public float turnSpeed;
    Rigidbody rig;

	// Use this for initialization
	void Start () {
        rig = gameObject.GetComponent<Rigidbody>();
	}
	
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rig.AddForce(transform.forward * shipSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rig.AddForce(-transform.forward * shipSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rig.AddForceAtPosition(transform.right * turnSpeed, transform.position - (transform.forward * (transform.lossyScale.z / 2)));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rig.AddForceAtPosition(-transform.right * turnSpeed, transform.position - (transform.forward * (transform.lossyScale.z / 2)));
        }
    }

	// Update is called once per frame
	void Update () {
        
	}
}
