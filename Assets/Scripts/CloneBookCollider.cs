using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneBookCollider : MonoBehaviour {

    public Transform prefab;
    public Transform bookpos;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider book)
    {
        if (book.gameObject.name == "Book")

            Instantiate(prefab, bookpos.transform.position, bookpos.transform.rotation);

            Debug.Log(book.name);
       
    }

    //Destroy(book);


}
