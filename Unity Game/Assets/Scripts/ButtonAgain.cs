using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAgain : MonoBehaviour
{
    [SerializeField]Score score;
    [SerializeField]Serve serve;
    public void Reload()
    {
        score.playerScoreNum = 0;
        score.opponentScoreNum = 0;
        score.pboundary.SetActive(true);
        score.oboundary.SetActive(true);
        score.otext.SetActive(false);
        score.LoseButton.SetActive(false);
        serve.NextServe();
    }
}
