using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpells : MonoBehaviour
{
    // Manually get the Ball script and cast several spells with BallHit to impact the ball
    [SerializeField] Ball ball;
    [SerializeField] Score score;
    public Opponent opponent;
    public Transform playTarget;

    public GameObject fireSource;
    public GameObject iceSource;
    public GameObject fireworkSource;
    public GameObject soulsSource;
    public GameObject electricitySource;
    public GameObject runicSource;
    public GameObject darkSource;

    void Start()
    {
        if (score == null)
        {
            score = GetComponent<Score>();
        }

        if (opponent == null)
        {
            opponent = GetComponent<Opponent>();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            FireSpell();
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            IceSpell();
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            FireworkSpell();
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            SoulsSpell();
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            ElectrcitySpell();
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            RunicSpell();
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            DarkSpell();
        }

    }

    public void FireSpell()
    {
        ball.BallHit(transform.position, playTarget.position, 0.4f);
        fireSource.SetActive(true);   

        iceSource.SetActive(false);  
        fireworkSource.SetActive(false);  
        soulsSource.SetActive(false);  
        electricitySource.SetActive(false);  
        runicSource.SetActive(false);  
        darkSource.SetActive(false);  
    }

    public void IceSpell()
    {
        if (opponent != null) {
            opponent.speed = 0.7f;
            } else {
                Debug.LogWarning("Opponent reference is not assigned!");
                }

        iceSource.SetActive(true);  

        fireSource.SetActive(false);   
        fireworkSource.SetActive(false);  
        soulsSource.SetActive(false);  
        electricitySource.SetActive(false);  
        runicSource.SetActive(false);  
        darkSource.SetActive(false);  
    }
    public void FireworkSpell()
    {
        ball.BallHit(transform.position, playTarget.position, 0.33f);
        fireworkSource.SetActive(true);  

        fireSource.SetActive(false);   
        iceSource.SetActive(false);  
        soulsSource.SetActive(false);  
        electricitySource.SetActive(false);  
        runicSource.SetActive(false);  
        darkSource.SetActive(false);  
    }
    public void SoulsSpell()
    {
        ball.BallHit(transform.position, playTarget.position, 0.2f);

        if (score.opponentScoreNum > 0)
        {
            score.opponentScoreNum--;
        }

        soulsSource.SetActive(true); 

        fireSource.SetActive(false);   
        iceSource.SetActive(false);  
        fireworkSource.SetActive(false);  
        electricitySource.SetActive(false);  
        runicSource.SetActive(false);  
        darkSource.SetActive(false);  
    }
    public void ElectrcitySpell()
    {
        ball.BallHit(transform.position, playTarget.position, 0.35f);

        electricitySource.SetActive(true);  

        soulsSource.SetActive(false); 
        fireSource.SetActive(false);   
        iceSource.SetActive(false);  
        fireworkSource.SetActive(false);  
        runicSource.SetActive(false);  
        darkSource.SetActive(false);  
    }
    public void RunicSpell()
    {
        if (score.playerScoreNum < 7)
        {
            score.playerScoreNum ++;
        }

        ball.BallHit(transform.position, playTarget.position, 0.3f);
        runicSource.SetActive(true);  

        electricitySource.SetActive(false);  
        soulsSource.SetActive(false); 
        fireSource.SetActive(false);   
        iceSource.SetActive(false);  
        fireworkSource.SetActive(false);  
        darkSource.SetActive(false); 
        
    }
    public void DarkSpell()
    {
        score.playerScoreNum+=3;
        ball.BallHit(transform.position, playTarget.position, 0.1f);
        darkSource.SetActive(true); 

        runicSource.SetActive(false);  
        electricitySource.SetActive(false);  
        soulsSource.SetActive(false); 
        fireSource.SetActive(false);   
        iceSource.SetActive(false);  
        fireworkSource.SetActive(false);  
    }

    public void TestSpell()
    {
        ball.BallHit(transform.position, playTarget.position, 0.3f);
    }
}
