using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { PLAYER, ENEMY, WIN, LOSE }
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameState state;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        state = GameState.PLAYER;
    }

    // Update is called once per frame
    void Update()
    {
        if(state == GameState.WIN)
        {
            Debug.Log("Player Wins!");
        }
        else if(state == GameState.LOSE)
        {
            Debug.Log("Player Lose!");
        }
    }
}
