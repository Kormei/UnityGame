using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpponentScoreText : MonoBehaviour
{
    public Score score; // Assign this in the Inspector if it's on a different GameObject
    private Text opponentScore;

    // Start is called before the first frame update
    void Start()
    {
        opponentScore = GetComponent<Text>();

        // Optional safety check
        if (score == null)
        {
            Debug.LogWarning("Score reference not set on OpponentScoreText. Attempting to find it on the same GameObject.");
            score = GetComponent<Score>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (score != null && opponentScore != null)
        {
            opponentScore.text = score.opponentScoreNum.ToString();
        }
    }
}
