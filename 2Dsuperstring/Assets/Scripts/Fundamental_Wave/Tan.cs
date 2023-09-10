using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tan : Wave
{
    public override float Evaluate(float x, float t)
    {
        return amplitude * Mathf.Tan(frequency * x + speed * t + phaseOffset);
    }
}
