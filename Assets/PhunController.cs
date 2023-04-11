using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class PhunController : MonoBehaviour
{
	[SerializeField] HingeJoint joint;
	[SerializeField] FixedJoint ragdollJoint;
	[SerializeField] float force;
	[SerializeField] Rigidbody self;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//forward to push rope forward and backward to pull rope backward
		if (Input.GetKey(KeyCode.W))
		{
			self.AddForce(transform.forward * force);
		}
		if (Input.GetKey(KeyCode.S))
		{
			self.AddForce(-transform.forward * force);
		}
		//left and right to rotate rope
		if (Input.GetKey(KeyCode.A))
		{
			self.AddTorque(transform.up * force);
		}
		if (Input.GetKey(KeyCode.D))
		{
			self.AddTorque(-transform.up * force);
		}
		//space to let go of ragdoll 
		if (Input.GetKey(KeyCode.Space))
		{
			ragdollJoint.breakForce = 0;

		}

	}
}
