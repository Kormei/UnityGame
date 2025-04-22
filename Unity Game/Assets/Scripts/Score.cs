using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int playerScoreNum = 0;
    public int opponentScoreNum = 0;

    // Changes score based on collision with respective boundary
    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("OpponentBoundary"))
        {
            playerScoreNum++;
        }
        else if (other.CompareTag("PlayerBoundary")) {
            opponentScoreNum++;
        }
    }
}
