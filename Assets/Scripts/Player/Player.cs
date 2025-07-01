using System;
using System.Collections;
using System.Collections.Generic;
using Effect;
using UnityEngine;

public class Player : MonoBehaviour, ILifeable
{
    [SerializeField] private int _health = 100;
    public int Health
    {
        get => _health;
        set
        {
            if (value <= _maxHealth || value > 0) _health = value;
            else throw new ArgumentException("Health cannot be more than maximal value");
        }
    }
    
    [SerializeField] private int _maxHealth = 100;
    public int MaxHealth => _maxHealth;

    private String _name;
    public String Name => _name;
    
    private String _surname;
    public String Surname => _surname;
    
    

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
enum Sex{
    Male,
    Female
};