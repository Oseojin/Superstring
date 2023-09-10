using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public float amplitude = 1f;
    public float frequency = 1f;
    public float speed = 1f;
    public float phaseOffset = 0f;
    public virtual float Evaluate(float x, float t)
    {
        return 1;
    }
}
