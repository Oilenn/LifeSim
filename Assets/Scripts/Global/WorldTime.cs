using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Класс мирового времени игры
public class WorldTime : MonoBehaviour
{
    private int _currentDay = 0;
    private int _currentMonth = 0;
    private int _currentYear = 0;

    private float _daySeconds = 5;

    private TickTimer _timer;
    
    public event Action OnNewDay;

    public int CurrentDay => _currentDay;
    public int CurrentMonth => _currentMonth;
    public int CurrentYear => _currentYear;
    
    private void NextDay()
    {
        _currentMonth++;
        OnNewDay?.Invoke();
    }

    public void Start()
    {
        _timer = new TickTimer();
        _timer.Start(_daySeconds);
    }

    public void Update()
    {
        _timer.Tick();
        if (_timer.IsReached)
        {
            _timer.Restart();
            NextDay();
        }
    }
}
