using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fighter : MonoBehaviour
{
    [SerializeField] public int hp { get; private set; }
    [SerializeField] public int atk { get; private set; }
    [SerializeField] public int def { get; private set; }

    public abstract void Act();
    public abstract void Flee();
}
