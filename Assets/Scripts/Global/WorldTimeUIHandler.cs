using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WorldTimeUIHandler : MonoBehaviour
{
    [SerializeField] private WorldTime _worldTime;
    
    [SerializeField] private TextMeshProUGUI _day;
    [SerializeField] private TextMeshProUGUI _month;
    [SerializeField] private TextMeshProUGUI _year;

    private void Update()
    {
        _day.text = _worldTime.CurrentDay.ToString();
        _month.text = _worldTime.CurrentMonth.ToString();
        _year.text = _worldTime.CurrentYear.ToString();
    }
}
