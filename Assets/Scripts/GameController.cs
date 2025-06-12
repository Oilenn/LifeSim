using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private PlayerEffectController _effectController;
    
    [SerializeField] private int _timeStep = 5;
    
    private TickTimer _timer;
    

    void Start()
    {
        _timer = new TickTimer();
        _timer.Start(_timeStep);
    }

    void Update()
    {
        //Мировое время игры
        //todo лучше переместить в другое место
        _timer.Tick();
        if (_timer.IsReached)
        {
            _effectController.ActivateEffects(_player);
            _timer.Restart();
        }
    }
}
