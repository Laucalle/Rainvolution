using System.Collections;
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
    public float vegetals;
    public float animals;

    private float vegetals_rate;
    private float animals_rate;

    public Text life_text;
    public Text h2o;
    public Text o2;
    public Text animals_text;
    public Text vegetals_text;

	void Start()
	{
        vegetals_rate = 1.0f;
        animals_rate = 1.2f;
	}

	// Update is called once per frame
	void Update () {

        if (O2 > 100.0f)
            animals_rate += (0.5f * Time.deltaTime);

        //Debug.Log(water+" - "+dryness_rate * Time.deltaTime);
        //water = water - dryness_rate * Time.deltaTime;

        water = water - (vegetals_rate * Time.deltaTime * dryness_rate);

        O2 = O2 - (animals_rate * Time.deltaTime);

        life = (water + O2) / 2;

        if (life <= 0.0f)
            life = 0.0f;

        if (life > 100.0f)
        {
            life = 100.0f;
            addVitality();
        }
        else {
            addVitality();
        }

        if (O2 <= 0.0f)
            O2 = 0.0f;

        if (O2 > 120.0f)
            O2 = 120.0f;

        if (water <= 0.0f)
            water = 0.0f;

        if (water > 120.0f)
            water = 120.0f;


        life_text.text = "life -> " + life.ToString();
        h2o.text = "H2O -> " + water.ToString();
        o2.text = "O2 -> " + O2.ToString();

        animals_text.text = "Animals -> " + animals.ToString();
        vegetals_text.text = "Vegetals -> " + vegetals.ToString();

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

    public void addVitality() {

        float v_rate = water * Time.deltaTime * vegetals_rate;
        float a_rate = O2 * Time.deltaTime * animals_rate; 

        if (life >= 30.0f && life <= 35.0f)
        {
            animals += (1.5f * a_rate)* Time.deltaTime;
            vegetals += v_rate* Time.deltaTime;
        }
        else if (life > 35.0f && life <= 40.0f)
        {
            animals += (1.5f * a_rate)* Time.deltaTime;
            vegetals += v_rate* Time.deltaTime;
        }
        else if (life > 40.0f && life <= 45.0f)
        {
            animals += (1.5f * a_rate)* Time.deltaTime;
            vegetals += v_rate* Time.deltaTime;
        }
        else if (life > 45.0f && life <= 50.0f)
        {
            animals += (1.5f * a_rate)* Time.deltaTime;
            vegetals += v_rate* Time.deltaTime;
        }
        else if (life > 50.0f && life <= 55.0f)
        {
            animals += (1.5f * a_rate)* Time.deltaTime;
            vegetals += v_rate* Time.deltaTime;
        }
        else if (life > 55.0f && life <= 60.0f)
        {
            animals += (1.5f * a_rate)* Time.deltaTime;
            vegetals += v_rate* Time.deltaTime;
        }
        else if (life > 60.0f && life <= 65.0f)
        {
            animals += (1.5f * a_rate)* Time.deltaTime;
            vegetals += v_rate* Time.deltaTime;
        }
        else if (life > 65.0f && life <= 70.0f)
        {
            animals += (1.5f * a_rate)* Time.deltaTime;
            vegetals += v_rate* Time.deltaTime;
        }
        else if (life > 70.0f && life <= 75.0f)
        {
            animals += (1.5f * a_rate)* Time.deltaTime;
            vegetals += v_rate* Time.deltaTime;
        }
        else if (life > 75.0f && life <= 80.0f)
        {
            animals += (1.5f * a_rate)* Time.deltaTime;
            vegetals += v_rate* Time.deltaTime;
        }
        else if (life > 80.0f && life <= 85.0f)
        {
            animals += (1.5f * a_rate)* Time.deltaTime;
            vegetals += v_rate* Time.deltaTime;
        }
        else if (life > 85.0f && life <= 90.0f)
        {
            animals += (1.5f * a_rate)* Time.deltaTime;
            vegetals += v_rate* Time.deltaTime;
        }
        else if (life > 90.0f && life <= 100.0f)
        {
            animals += (1.5f * a_rate)* Time.deltaTime;
            vegetals += v_rate* Time.deltaTime;
        }
        else if (life < 30.0f) {
            animals -= (1.5f * a_rate)* Time.deltaTime;
            vegetals -= v_rate* Time.deltaTime;
        }
    }
}
