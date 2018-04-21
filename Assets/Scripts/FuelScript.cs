using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelScript : MonoBehaviour
{

	
	// Update is called once per frame
	void Update ()
    {
        FuelBar();	
	}

    void FuelBar()
    {
        if (PlayerController.jetpackFuel > 0.001)
        {
            gameObject.transform.localScale = new Vector3(PlayerController.jetpackFuel, 1, 1);
        }
    }
}

