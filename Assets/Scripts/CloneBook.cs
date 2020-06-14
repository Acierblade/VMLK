using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneBook : MonoBehaviour
{

    public Transform prefab;
    public Transform obj1;
    public Transform obj2;
    public float distance;
    public Transform book;

    void Start()
    {
    }

    void Update()
    {
        distance = Vector3.Distance(obj1.position, obj2.position);

        if (distance < 3f)
        {
            Instantiate(prefab, new Vector3(book.transform.position.x, book.transform.position.y, book.transform.position.z), Quaternion.identity);
        }
    }


}