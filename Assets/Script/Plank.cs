using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plank : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Cutter")
        {
            Debug.Log("WE ARE CUTTING");
            Destroy(gameObject);
        }
    }
}
