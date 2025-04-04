using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpells : MonoBehaviour
{
    // Manually get the Ball script and cast several spells with BallHit to impact the ball
    [SerializeField]Ball ball;
    public void TestSpell()
    {
        ball.BallHit(transform.position, .3f);
    }
    public void SpellOne()
    {

    }
    // etc add more spells
}
