using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plank : MonoBehaviour
{
    int times = 0;
    int plankType;
    

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Cutter")
        {
            times++;
            Debug.Log("WE ARE CUTTING");

            if (times == 5)
            {
                plankType = Random.Range(1, 4);
                Debug.Log(plankType);
                reSpawn(plankType);
                GameObject.Find("GameHolder").GetComponent<Cutgame>().score += 1;

                Debug.Log("you made the cut");

                if(gameObject == GameObject.Find("OPlankA"))
                {
                    GameObject.Find("Plank_A(Clone)").GetComponent<Collider2D>().isTrigger = true;
                }
                else if (gameObject == GameObject.Find("OPlankB"))
                {
                    GameObject.Find("Plank_B(Clone)").GetComponent<Collider2D>().isTrigger = true;
                }
                else if (gameObject == GameObject.Find("OPlankC"))
                {
                    GameObject.Find("Plank_C(Clone)").GetComponent<Collider2D>().isTrigger = true;
                }
                
                Destroy(gameObject);
            }
        }
    }

    public void reSpawn(int type)
    {
        if (type == 1)
        {
            Instantiate(GameObject.Find("GameHolder").GetComponent<Cutgame>().plankA, new Vector3(3.0F, 5, 0), Quaternion.identity);
        }
        else if (type == 2)
        {
            Instantiate(GameObject.Find("GameHolder").GetComponent<Cutgame>().plankB, new Vector3(3.0F, 5, 0), Quaternion.identity);
        }
        else
        {
            Instantiate(GameObject.Find("GameHolder").GetComponent<Cutgame>().plankC, new Vector3(3.0F, 5, 0), Quaternion.identity);
        }
    }

}
