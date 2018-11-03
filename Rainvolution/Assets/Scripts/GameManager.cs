﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

    [Header("Rain Variables")]
    public float water;
    public float rain_max;
    public float danger_zone;
    public float dryness_rate;
    public float water_rate;

    [Header("Game values")]
    public float O2;
    public float life;

    public Text life_text;
    public Text h2o;
    public Text o2;

	// Update is called once per frame
	void Update () {
        //Debug.Log(water+" - "+dryness_rate * Time.deltaTime);
        water = water - dryness_rate * Time.deltaTime;


        // Fit this operation with the time
        life = (water + O2) / 2;



        //if (water >= rain_max)
        //{
        //    Debug.Log("You died. Too much");
        //}
        //else if (water <= 0) {
        //    Debug.Log("You died. Too little");
        //}

        life_text.text = "life -> " + life.ToString();
        h2o.text = "H2O -> " + water.ToString();
        o2.text = "O2 -> " + O2.ToString();

	}
    public void Rain() {
        water += water_rate;
    }

    public void setValuesGenerator (float consume_rate, float produce_rate) {
        water -= consume_rate;
        O2 += produce_rate;
    }

    public void Pay (float value) {
        water -= value;
    }
}
