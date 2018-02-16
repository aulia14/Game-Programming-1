﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour {
    static Scores scoreX;
    public static int score;
    public Text Text;
	// Use this for initialization
	void Start () {
		Text.text = "Score : "+score;
	}
	
	// Update is called once per frame
	void Update () {
        Text.text = "Score : " + score;
    }

    public void AddScore(int _score)
    {
        score += _score;
        Debug.Log("Score Bertambah");
        Text.text = "Score : " + score.ToString();
    }

    public void MinScore(int _score)
    {
        score -= _score;
        Debug.Log("Score Berkurang");
        Text.text = "Score : " + score.ToString();
    }
}
