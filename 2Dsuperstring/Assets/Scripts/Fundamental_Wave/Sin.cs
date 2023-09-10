using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sin : Wave
{
    public override float Evaluate(float x, float t)
    {
        return amplitude * Mathf.Sin(frequency * x + speed * t + phaseOffset);
    }
}
