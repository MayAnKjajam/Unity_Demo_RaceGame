using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour {
    public GameObject Lapcompletetrigger;
    public GameObject HalfLapTrigger;

    public GameObject Minutedisplay, SecondDisplay;

    public GameObject LapTimeBox;
    public GameObject LapCounter;
    public int LapsDone;
    public float RawTime;

	// Use this for initialization
	void Start () {
		
	}
    void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.name == "boxcollider")
        {
            LapsDone += 1;


            RawTime = PlayerPrefs.GetFloat("Rawtime");
            if (LapTimeManager.RawTime <= RawTime)
            {
                if (LapTimeManager.Secondscount <= 9)
                {
                    SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.Secondscount;
                }
                else
                {
                    SecondDisplay.GetComponent<Text>().text = ":  " + LapTimeManager.Secondscount;
                }
                if (LapTimeManager.Minutecount <= 9)
                {
                    Minutedisplay.GetComponent<Text>().text = "0" + LapTimeManager.Minutecount;
                }
                else
                {
                    Minutedisplay.GetComponent<Text>().text = "" + LapTimeManager.Minutecount + " :";
                }
            }
            PlayerPrefs.SetInt("min", LapTimeManager.Minutecount);
            PlayerPrefs.SetInt("sec", LapTimeManager.Secondscount);
            PlayerPrefs.SetFloat("Rawtime", LapTimeManager.RawTime);
            LapTimeManager.Minutecount = 0;
            LapTimeManager.Secondscount = 0;
            LapTimeManager.RawTime = 0;
            LapCounter.GetComponent<Text>().text = "" + LapsDone;
            HalfLapTrigger.SetActive(true);
            Lapcompletetrigger.SetActive(false);
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
