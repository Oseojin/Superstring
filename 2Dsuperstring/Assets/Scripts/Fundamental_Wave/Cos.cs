using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cos : Wave
{
    public override float Evaluate(float x, float t)
    {
        return amplitude * Mathf.Cos(frequency * x + speed * t + phaseOffset);
    }
}
