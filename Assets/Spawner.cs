using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//check for shiftdown
		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			//spawn a new ragdoll
			Instantiate(prefab, transform.position, transform.rotation);
		}
	}
}
