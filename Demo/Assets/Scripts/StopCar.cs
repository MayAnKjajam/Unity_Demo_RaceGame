using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class StopCar : MonoBehaviour,IPointerDownHandler {

    public GameObject car;
    public virtual void OnPointerDown(PointerEventData eventData)
    {
        car.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
