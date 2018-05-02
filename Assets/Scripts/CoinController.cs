using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public float rotateSpeed;

	void FixedUpdate ()
    {
        transform.Rotate(0, Time.deltaTime * rotateSpeed, 0, Space.World);
	}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        Destroy(this.gameObject);
    //    }
    //}
}
