using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(WorldTime))]
public class GameController : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private PlayerEffectController _playerEffectController;
    
    [Header("Время в секундах для прохождения одного шага времени")]
    [SerializeField] private int _timeStep = 5;

    private WorldTime _worldTime;

    void Start()
    {
        _worldTime = GetComponent<WorldTime>();
        _worldTime.OnNewDay += OnStepTime;
    }

    //Метод при прохождении единицы времени
    private void OnStepTime()
    {
        _playerEffectController.ActivateEffects(_player);
        _player.CheckCondition();
    }
}
