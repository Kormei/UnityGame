using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int playerScoreNum = 0;
    public int opponentScoreNum = 0;
    [SerializeField]public Serve serv;

    // Changes score based on collision with respective boundary
    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("OpponentBoundary"))
        {
            playerScoreNum++;
            serv.NextServe();
        }
        else if (other.CompareTag("PlayerBoundary")) {
            opponentScoreNum++;
            serv.NextServe();
        }
    }
}
