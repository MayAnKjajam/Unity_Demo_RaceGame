using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CarJoyStick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool ispointerdown = false;
    float speed = 0;
    public virtual void OnPointerDown(PointerEventData eventData)
    {
        ispointerdown = true;
    }

    public virtual void OnPointerUp(PointerEventData eventData)
    {
        ispointerdown = false;
    }
    public float Acceleratecar()
    {
        if (ispointerdown == true)
        {
            speed += 0.1f;
        }
        else
        {
            speed = 0;
        }
        return speed;
    }
}