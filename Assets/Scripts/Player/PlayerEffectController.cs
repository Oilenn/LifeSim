using System;
using System.Collections;
using System.Collections.Generic;
using Effect;
using UnityEngine;

public class PlayerEffectController : MonoBehaviour
{
    private List<IEffect> _effects;
    
    public void Start()
    {
        _effects = new List<IEffect>();
    }
    
    public void ActivateEffects(ILifeable lifeable)
    {
        foreach (var effect in _effects)
        {
            effect.Activate(lifeable);
        }
    }
}
