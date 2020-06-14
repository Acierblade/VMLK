using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour {

    public Transform Spot1;
    public Transform Spot2;
    public Transform Spot3;
    public Transform Spot4;

    private float stage = 0;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (stage == 0)
            {
                transform.position = Spot2.position;
            }
            else if (stage == 1)
            {
                transform.position = Spot3.position;
            }
            else if (stage == 2)
            {
                transform.position = Spot4.position;
            }
            else if (stage == 3)
            {
                transform.position = Spot1.position;
            }
            stage = stage + 1;
        }

        if (stage > 3)
        {
            stage = 0;
        }

    }

  
}
