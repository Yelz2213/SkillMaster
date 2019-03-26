using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D node)
    {
        if (node.tag == "Plank")
        {
            Destroy(node.gameObject);
        }
    }
}
