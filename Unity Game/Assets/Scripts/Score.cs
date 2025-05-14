using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int playerScoreNum = 0;
    public int opponentScoreNum = 0;
    [SerializeField]public Serve serv;
    [SerializeField]public GameObject ptext;
    [SerializeField]public GameObject otext;
    [SerializeField]public GameObject pboundary;
    [SerializeField]public GameObject oboundary;
    [SerializeField]public GameObject WinButton;
    [SerializeField]public GameObject LoseButton;

    // Changes score based on collision with respective boundary
    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("OpponentBoundary"))
        {
            playerScoreNum++;
            if(playerScoreNum >= 7 || opponentScoreNum >= 7){GameOver();}else{serv.NextServe();}
        }
        else if (other.CompareTag("PlayerBoundary")) {
            opponentScoreNum++;
            if(playerScoreNum >= 7 || opponentScoreNum >= 7){GameOver();}else{serv.NextServe();}
        }
    }
    void GameOver()
    {
        if(playerScoreNum >= 7){ptext.SetActive(true);WinButton.SetActive(true);}else{otext.SetActive(true);LoseButton.SetActive(true);}
        pboundary.SetActive(false);
        oboundary.SetActive(false);
    }
}
