using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {
    public float rain_percentage;
    public float rain_max;
    public float danger_zone;
    public float dryness_rate;
    public float water_rate;
	
	// Update is called once per frame
	void Update () {
        Debug.Log(rain_percentage+" - " +dryness_rate * Time.deltaTime);
        rain_percentage = rain_percentage - dryness_rate * Time.deltaTime;
        if (rain_percentage >= rain_max)
        {
            Debug.Log("You died. Too much");
        }
        else if (rain_percentage <= 0) {
            Debug.Log("You died. Too little");
        }
	}
    public void Rain() {
        rain_percentage += water_rate;

    }
}
