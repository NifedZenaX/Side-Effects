using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillsHandler : MonoBehaviour
{
    [SerializeField] private Player player;
    private Toggle skill;

    public void UseSkill()
    {
        if(GameManager.instance.state == GameState.PLAYER)
        {
            player.Act(skill.name);
            GameManager.instance.state = GameState.ENEMY;
        }
    }

    public void SelectSkill(Toggle selectedSkill)
    {
        skill = selectedSkill;
    }
}
