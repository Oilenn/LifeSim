using System;
using System.Collections;
using System.Collections.Generic;
using Action;
using UnityEngine;

public class Player : MonoBehaviour, ILifeable
{
    [SerializeField] private int _health;
    [SerializeField] private int _maxHealth;
    
    private TickTimer _timer;

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

    public void Start()
    {
        _timer = new TickTimer();
        _timer.Start(5);
    }
    
    public void Update()
    {
        _timer.Tick();
        if (_timer.IsReached)
        {
            TickTime();
            _timer.Start(5);
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
    public void TickTime()
    {
        if (_health < 0)
        {
            Die();
        }
    }
}
