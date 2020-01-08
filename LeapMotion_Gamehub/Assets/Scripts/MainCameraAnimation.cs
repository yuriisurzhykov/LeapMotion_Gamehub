using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraAnimation : MonoBehaviour
{


    private float angelUp = 10f;

    private BotsController bot;

    private float dist;

    // Start is called before the first frame update
    void Start()
    {

        bot = GameObject.Find("Bot").GetComponent<BotsController>();
        if(transform.position.x != bot.transform.position.x)
          dist = transform.position.x - bot.transform.position.x;
        else
          dist = transform.position.z - bot.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        ChooseWay();
        LookAtSmooth(gameObject.transform, bot.transform.position, angelUp);
    }

    private void ChooseWay()
    {
        switch (bot.transform.eulerAngles.y)
        {
            case 270:
                gameObject.transform.position = Vector3.MoveTowards(transform.position,
                    new Vector3(bot.transform.position.x + dist, transform.position.y, bot.transform.position.z),
                    40 * Time.deltaTime);
                // new Vector3(bot.transform.position.x + distX, transform.position.y, bot.transform.position.z);
                break;
            case 90:
                gameObject.transform.position = Vector3.MoveTowards(transform.position,
                    new Vector3(bot.transform.position.x - dist, transform.position.y, bot.transform.position.z),
                    40 * Time.deltaTime);
                break;
            case 0:
                gameObject.transform.position = Vector3.MoveTowards(transform.position,
                    new Vector3(bot.transform.position.x, transform.position.y, bot.transform.position.z - dist),
                    40 * Time.deltaTime);
                break;
            case 180:
                gameObject.transform.position = Vector3.MoveTowards(transform.position,
                    new Vector3(bot.transform.position.x, transform.position.y, bot.transform.position.z + dist),
                    40 * Time.deltaTime);
                break;
        }
    }


    public void LookAtSmooth(Transform me, Vector3 target, float t)
    {
        var look = Quaternion.LookRotation(target - me.position);

        me.rotation = Quaternion.Lerp(me.rotation, look, t * Time.deltaTime);
    }
}