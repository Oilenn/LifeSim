using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIHandler : MonoBehaviour
{
    [SerializeField] private Player _player;
    
    [SerializeField] private Slider _healthBar;
    [SerializeField] private TextMeshProUGUI _personName;
    [SerializeField] private TextMeshProUGUI _personSurname;
    
    void Start()
    {
        _healthBar.maxValue = _player.MaxHealth;
    }

    void Update()
    {
        _healthBar.value = _player.Health;
        _personName.text = _player.Name;
        _personSurname.text = _player.Surname;
    }
}
