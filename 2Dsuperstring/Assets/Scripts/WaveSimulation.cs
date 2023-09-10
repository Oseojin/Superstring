using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(LineRenderer))]
public class WaveSimulation : MonoBehaviour
{
    [SerializeField]
    private Wave origin_wave;

    public List<Wave> configuration_waves;

    private LineRenderer lineRenderer;

    public int number_of_configuration = 1;
    public int numberOfPoints = 40;
    public float width = 5f;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        configuration_waves.Add(origin_wave);
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.positionCount = numberOfPoints;

        for(int i = 0; i < numberOfPoints; i++)
        {
            float xPosition = i * (width / numberOfPoints) - (width / 2f);
            float yPosition = 0;
            foreach (Wave wave in configuration_waves)
            {
                yPosition += wave.Evaluate(xPosition, Time.time);
            }
            lineRenderer.SetPosition(i, new Vector3(xPosition, yPosition, 0));
        }
    }

    public bool Interference_Wave(Wave inter_wave)
    {
        if(inter_wave == null || number_of_configuration >= 4) // 자신을 포함한 4개 이상의 파동이 구성 요소로 존재한다면 간섭 X
        {
            return false;
        }

        configuration_waves.Add(inter_wave);
        number_of_configuration++;

        return true;
    }
}
