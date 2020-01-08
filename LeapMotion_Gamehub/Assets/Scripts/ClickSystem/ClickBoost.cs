using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickBoost : MonoBehaviour, IPointerClickHandler
{
    public static float boost=1f;
       
    public void OnPointerClick(PointerEventData eventData)
    {
        StartCoroutine(waitSet());
       
    }

    IEnumerator waitSet()
    {

        boost = 3.5f;
       // Debug.Log(boost);
        yield return new WaitForEndOfFrame();
        boost = 1;
    }





}
