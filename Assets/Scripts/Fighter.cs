using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Fighter : MonoBehaviour
{
    [SerializeField] private int hp;
    [SerializeField] private int atk;
    [SerializeField] private int def;
    [SerializeField] private Slider healthBar;

    private void Awake()
    {
        healthBar.maxValue = hp;
        healthBar.value = healthBar.maxValue;
        healthBar.minValue = 0;
    }

    public abstract void Act();
    public abstract void Flee();
}
