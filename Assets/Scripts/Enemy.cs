using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Fighter
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Act(string skillName)
    {
        if(GameManager.instance.state == GameState.ENEMY)
        {
            //Fight
            GameManager.instance.state = GameState.PLAYER;
        }
    }

    public override void Flee()
    {
        //Cannot run
    }
}
