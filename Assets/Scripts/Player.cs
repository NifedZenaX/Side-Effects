using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : Fighter
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Act(string skillName)
    {
        //Fight
        if(skillName == "Attack")
        {
            //Attack
            Debug.Log("Player Attack!");
        }
        else if(skillName == "Heal")
        {
            //Heal
            Debug.Log("Player Heal!");
        }
        else
        {
            Debug.LogWarning("There is no " + skillName  +" in this skill list");
        }

    }

    public override void Flee()
    {
        //Flee
    }
}
