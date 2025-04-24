using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreDisplay : MonoBehaviour
{
    [SerializeField] Score score;
    private Text playerScore;

    // Start is called before the first frame update
    void Start()
    {
        if(!score)
        {
            score = GetComponent<Score>();
        }
        playerScore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (score != null && playerScore != null)
        {
            playerScore.text = score.playerScoreNum.ToString();
        }
    }
}
