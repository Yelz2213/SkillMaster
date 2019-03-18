using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter : MonoBehaviour
{
    public GameObject tailPrefab;
    public float minCuttingVelocity = .001f;
    bool isCutting = false;

    Vector2 previousPosition;

    GameObject currentTail;

    BoxCollider2D boxCollider;

    Rigidbody2D rb;
    Camera cam;

    private void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCutting();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopCutting();
        }

        if (isCutting)
        {
            UpdateCut();
        }
    }

    void UpdateCut() {
        Vector2 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        rb.position = newPosition;
        rb.position = cam.ScreenToWorldPoint(Input.mousePosition);

        float velocity = (newPosition - previousPosition).magnitude * Time.deltaTime;
        if (velocity > minCuttingVelocity)
        {
            boxCollider.enabled = true;
        }
        else
        {
            boxCollider.enabled = false;
        }

        previousPosition = newPosition;
    }

    void StartCutting()
    {
        isCutting = true;
        currentTail = Instantiate(tailPrefab, transform);
        previousPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        boxCollider.enabled = false;
    }

    void StopCutting()
    {
        isCutting = false;
        currentTail.transform.SetParent(null);
        Destroy(currentTail);
        boxCollider.enabled = false;
    }
}
