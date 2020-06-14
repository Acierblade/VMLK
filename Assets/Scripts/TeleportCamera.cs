using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportCamera : MonoBehaviour {

    // Target Object
    public GameObject Player;

    // Target To
    public GameObject SpeakerPresepctive;
    public GameObject CrowdPrespective;
    public GameObject BalconyPrespective;
    public GameObject StartingPosition;

    //Bool
    private bool Speaker;
    private bool Crowd;
    private bool Balcony;
    private bool Starting;

    void Start()
    {
        Speaker = false;
        Crowd = true;
        Balcony = false;
        Starting = false;
    }

        void Update()
    {
        moveAround();
    }

private void moveAround()
    {

        if (OVRInput.GetUp(OVRInput.Button.One) && Crowd == true)
        {
            Player.gameObject.transform.position = CrowdPrespective.gameObject.transform.position;
            Crowd = false;
            Speaker = true;
        }

        else if (OVRInput.GetUp(OVRInput.Button.One) && Speaker == true)
        {
            Player.gameObject.transform.position = SpeakerPresepctive.gameObject.transform.position;
            Crowd = false;
            Speaker = false;
            Balcony = true;
        }

        else if (OVRInput.GetUp(OVRInput.Button.One) && Balcony == true)
        {
            Player.gameObject.transform.position = BalconyPrespective.gameObject.transform.position;
            Crowd = false;
            Speaker = false;
            Balcony = false;
            Starting = true;
        }
        else if (OVRInput.GetUp(OVRInput.Button.One) && Starting == true)
        {
            Player.gameObject.transform.position = StartingPosition.gameObject.transform.position;
            Crowd = true;
            Speaker = false;
            Balcony = false;
            Starting = false;
        }

    }

}
