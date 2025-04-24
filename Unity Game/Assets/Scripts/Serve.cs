using UnityEngine;

public class Serve : MonoBehaviour
{
    bool isPlayServe;
    bool isOppServe;
    [SerializeField]Ball ball;
    [SerializeField]Score score;
    [SerializeField]PlayerMovement player;
    [SerializeField]Opponent opponent;
    Vector3 PServeStart = new Vector3(1f,1.5f,-7.4f);
    Vector3 OServeStart = new Vector3(-1.3f,1.5f,-.2f);
    Vector3 PStart;
    Vector3 OStart;

    void Start()
    {
        PStart = player.transform.position;
        OStart = opponent.transform.position;
        ball.GetComponent<Rigidbody>().useGravity = false;

    }
    public void NextServe()
    {
        if((score.playerScoreNum + score.opponentScoreNum)%2 == 0){isPlayServe = true;}else{isPlayServe=false;}
        isOppServe = !isPlayServe;
        if(isPlayServe){PlayerServe();}else{OpponentServe();}
        player.transform.position = PStart;
        opponent.transform.position = OStart;
        ball.GetComponent<Rigidbody>().useGravity = false;
        ball.transform.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
    void PlayerServe()
    {
        ball.transform.position = PServeStart;
    }
    void OpponentServe()
    {
        ball.transform.position = OServeStart;
    }
}
