using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vKingMovement : MonoBehaviour {

    private Animation anim;
    public float MoveSpeed = 2.0f;

    void Start()
    {


        // Walk at double speed
        anim[name: "vAnimation"].speed = MoveSpeed;
    }

}
