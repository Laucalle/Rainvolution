using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratorManager : MonoBehaviour 
{
    public Generator[] generators;
    public int[] number_of_gen;

    public PowerUp[] power_ups;
    public int[] number_of_pow;

    private GameManager game;
    private int counter;

    public GameObject panel;
    public Text console;


	// Use this for initialization
	void Start () {
        game = gameObject.GetComponent<GameManager>();
        counter = 1;

        for (int i = 0; i < generators.Length; i++) {
            number_of_gen[i] = 0;
        }
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float consume = 0.0f;
        float produce = 0.0f;

        // For Generators
        for (int i = 0; i < generators.Length; i++) {
            consume += (float) number_of_gen[i] * generators[i].consume_rate * Time.deltaTime;
            produce += (float) number_of_gen[i] * generators[i].produce_rate * Time.deltaTime;
        }

        // For PowerUps
        for (int i = 0; i < power_ups.Length; i++) {
            consume -= (float)number_of_pow[i] * power_ups[i].produce_rate * Time.deltaTime;
        }

        game.setValuesGenerator(consume, produce);
        CheckForNewPowers();

	}

    void CheckForNewPowers () {
        int total_powers = 0;

        for (int i = 0; i < number_of_gen.Length; i++) {
            total_powers += number_of_gen[i];
        }
        for (int i = 0; i < number_of_pow.Length; i++) {
            total_powers += number_of_pow[i];
        }

        switch (total_powers) {

            // Unlock PowerUp1
            case 10:
                panel.GetComponent<Button>().transform.Find("PowerUp" + counter).gameObject.SetActive(true);
                // When power up set active to true, update counter +1
                counter++;
                break;

            // Unlock Generator2
            case 25:
                break;
        }
    }


}
