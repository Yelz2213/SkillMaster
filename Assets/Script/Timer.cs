using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer_text;
    public float timers;
    // Start is called before the first frame update
    void Start()
    {
        timer_text = timer_text.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer_text.text = "" + timers.ToString("F0");
        timers -= Time.deltaTime;
    }
}
