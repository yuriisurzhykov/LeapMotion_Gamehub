using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BotsController : MonoBehaviour
{

    [SerializeField] protected float speed; //Скорость машинки
    protected bool isTouchNextCar;
  
    private bool isTouchCrossRoads;

    private float posX;//Задать позицию по Х, если вошел в тригер 
    private float posZ;//Задать позицию по Z, если вошел в тригер 

    private int rndSide = 0;//Выбрать в какую сторону 

    int rotStep = 0; //В какую сторну поворочиваем
    float posStep = 0; // через сколько надо поворачивать

    float timeForCR=2;
    float timeForCheckNC=2;

    private CheckOnCrossRoads crossRoadsInfo;

    [SerializeField] private GameObject lightF;
    private GameObject lightG;

    public CheckOnCrossRoads CrossRoadsInfo
    {
        get { return crossRoadsInfo; }
        set { crossRoadsInfo = value; }
    }

    public bool IsTouchNextCar
    {
        get { return isTouchNextCar; }
        set { isTouchNextCar = value; }
    }
    public bool IsTouchCrossRoads
    {
        get { return isTouchCrossRoads; }
        set { isTouchCrossRoads = value; }
    }

    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public int RndSide
    {
        get { return rndSide; }
        set { rndSide = value; }
    }

    public void Awake()
    {
        lightG = GameObject.Find("Directional Light");
    }

    // Update is called once per frame
    public void Update()
    {
        if (lightG.transform.eulerAngles.x > 0&& lightG.transform.eulerAngles.x < 180)
        {
            lightF.SetActive(false);
        }
        else 
           lightF.SetActive(true);

        GoIf(speed, IsTouchNextCar);
      
        gameObject.transform.Translate(new Vector3(0, 0, speed));

        CheckRot();
   }

    



     public void DeleteIfCrossRoads(float speed, bool check, List<GameObject> bots) {

        if (timeForCR <= 0)
        {
            crossRoadsInfo.BotsList.Remove(gameObject);
            bots.Remove(gameObject);
            Destroy(gameObject);
        }

        if (check && speed==0)
            timeForCR -= Time.deltaTime;
        else timeForCR = 3;
     }

    void GoIf(float speed, bool check)
    {

        if (timeForCheckNC <= 0)
        {
            speed = 0.3f;
        }

        if (!check && speed == 0&&rndSide==0)
            timeForCheckNC -= Time.deltaTime;
        else timeForCheckNC = 3;
    }
    public void RandomWay(float distR, float distL)
    {
        switch (rndSide)
        {
            case 1:
               // SetData(-90, 18.5f+3.06f);
                SetData(-90, distL);
                break;
            case 2:
                SetData(90, distR);
                break;
         }

    }

    private void SetData(int rot, float pos) {
        rotStep = rot;
        posStep = pos;
        posX = gameObject.transform.position.x;
        posZ = gameObject.transform.position.z;
    }

    private void CheckRot()
    {

        switch (gameObject.transform.eulerAngles.y)
        {
            case 270:
                if (transform.position.x < posX - posStep && rndSide != 0)
                    ChangeRot();
                break;
            case 90:
                if (transform.position.x > posX + posStep && rndSide != 0)
                    ChangeRot();
                break;
            case 0:
                if (transform.position.z > posZ + posStep && rndSide != 0)
                    ChangeRot();
                break;
            case 180:
                if (transform.position.z < posZ - posStep && rndSide != 0)
                    ChangeRot();
                break;
        }

    }


    private void ChangeRot()
    {
        float rot = LimitRot(transform.eulerAngles.y + rotStep);
        gameObject.transform.rotation = Quaternion.Euler(0, rot, 0);
        rotStep = 0;
        posStep = 0;
        rndSide = 0;
        posX = 0;
        posZ = 0;
        if (!isTouchNextCar)
            Speed = Random.Range(0.3f, 0.6f);
    }


    private float LimitRot(float newRot) {
       
        if (newRot >= 360|| newRot <= -360)
            newRot = 0;
 
        return newRot;
    }

}
