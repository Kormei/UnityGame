using UnityEngine;

public class Serve : MonoBehaviour
{
    bool isPlayServe;
    bool isOppServe;
    [SerializeField]Ball ball;
    [SerializeField]Score score;
    [SerializeField]PlayerMovement player;
    [SerializeField]Opponent opponent;
    Vector3 PServeStart = new Vector3(.8f,2.2f,-6.4f);
    Vector3 OServeStart = new Vector3(0f,1.5f,-.2f);
    Vector3 PStart = FindFirstObjectByType<PlayerMovement>().transform.position;
    Vector3 OStart = FindFirstObjectByType<Opponent>().transform.position;
    // Start is called before the first frame update
    void Start()
    {
        ball.transform.position = PServeStart;
        player.transform.position = PStart;
        opponent.transform.position = OStart;
        ball.GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if((score.playerScoreNum + score.opponentScoreNum)%2 == 0){isPlayServe = true;}else{isPlayServe=false;}
        isOppServe = !isPlayServe;
        if(isPlayServe){PlayerServe();}else{OpponentServe();}
    }
    void PlayerServe()
    {

    }
    void OpponentServe()
    {

    }
}
