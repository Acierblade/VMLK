using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class v_Reading : MonoBehaviour {

    public GameObject Subtitle;
    public GameObject RightHand;

    public float posOffset = 5f;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Subtitle.transform.position = new Vector3(RightHand.transform.position.x, RightHand.transform.position.y, RightHand.transform.position.z-posOffset);
        //Subtitle.transform.rotation = RightHand.transform.rotation;
    }
}
