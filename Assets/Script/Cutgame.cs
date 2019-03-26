using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cutgame : MonoBehaviour
{
    public float timers;

    bool isGaming;
    public GameObject cutter;

    public GameObject plankA;
    public GameObject plankB;
    public GameObject plankC;

    public GameObject gameOverPanel;

    public int score;

    public Text timer_text;
    public Text score_text;
    public Text final_score_text;

    void Start()
    {
        score = 0;
        score_text = score_text.GetComponent<Text>();
        timer_text = timer_text.GetComponent<Text>();
        final_score_text = final_score_text.GetComponent<Text>();
        Plank plank = GetComponent<Plank>();

    }

    // Update is called once per frame
    void Update()
    {
        timer_text.text = "" + timers.ToString("F0");
        if (timers >= 0)
        {
            timers -= Time.deltaTime;
        }

        if (timers <= 0) {
            gameOverPanel.SetActive(true);

        }

        score_text.text = "Score : " + score;
        final_score_text.text = "Score: " + score;
    }

    void gameStart() {
        isGaming = true;
    }

}
