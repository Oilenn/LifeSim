using UnityEngine;

//Класс-таймер
public class TickTimer
{
    private float _currentTime;
    private float _targetTime;

    public bool IsReached => _currentTime >= _targetTime;

    public void Tick()
    {
        _currentTime += Time.deltaTime;
    }

    public void Start(float targetTime)
    {
        _currentTime = 0;
        _targetTime = targetTime;
    }
    
    public void Restart()
    {
        _currentTime = 0;
    }
}
