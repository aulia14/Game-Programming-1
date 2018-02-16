using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {
    private Scores myScore;
    int scoreMin = 5;
    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        myScore = other.gameObject.GetComponent<Scores>();
        Destroy(gameObject);
        Scores.score -= 5;
        if (Scores.score <= 0) {
            Scores.score = 0;
        }
        
    }
}
