using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static float jetpackFuel = 1.5f;
    public float jetpackForce = 10.0f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButton("Jump") && jetpackFuel>=0.001f)
        {
            BoostUp();
        }
	}

    void BoostUp()
    {
        jetpackFuel = Mathf.MoveTowards(jetpackFuel, 0, Time.fixedDeltaTime);
        GetComponent<Rigidbody>().AddForce(new Vector3(0, jetpackForce));

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            jetpackFuel = 1.5f;
        }
    }
}
