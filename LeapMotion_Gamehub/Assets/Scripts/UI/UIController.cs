using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Text FPSText;
    

    //очки игрока
    private int score;
    //скорость игрока
    private int speed;
    //бонус к очкам
    private float index;

    //нужены для вычисления ФПС
    int accumulator = 0;
    int counter = 0;
    float timer = 0f;
    // Start is called before the first frame update
    void Awake()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        CounterFPS();
    }

    private void CounterFPS()
    {
        accumulator++;
        timer += Time.deltaTime;

        if (timer >= 1)
        {
            timer = 0;
            counter = accumulator;
            accumulator = 0;
        }

        FPSText.text = "FPS:" + counter.ToString();
    }

}
