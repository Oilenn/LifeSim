using System;
using System.Collections;
using System.Collections.Generic;
using Effect;
using UnityEngine;

public class Player : MonoBehaviour, ILifeable
{
    [SerializeField] private int _health;
    [SerializeField] private int _maxHealth;

    private PlayerEffectController _playerEffectController;
    
    public int Health
    {
        get => _health;
        set
        {
            if (value <= _maxHealth || value > 0) _health = value;
            else throw new ArgumentException("Health cannot be more than maximal value");
        }
    }
    
    public void Die()
    {
        throw new System.NotImplementedException();
    }

    public void OnDie()
    {
        throw new System.NotImplementedException();
    }

    //Метод для прохода части времени
    public void CheckCondition()
    {
        if (_health < 0)
        {
            Die();
        }
    }
}
