using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorManager : MonoBehaviour 
{
    public Generator[] generators;
    public int[] number_of_gen;

    private GameManager game;

	// Use this for initialization
	void Start () {
        game = gameObject.GetComponent<GameManager>();

        //for (int i = 0; i < generators.Length; i++) {
        //    number_of_gen[i] = 0;
        //}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float consume = 0.0f;
        float produce = 0.0f;
        for (int i = 0; i < generators.Length; i++) {
            consume += (float) number_of_gen[i] * generators[i].consume_rate * Time.deltaTime;
            produce += (float) number_of_gen[i] * generators[i].produce_rate * Time.deltaTime;
        }

        game.setValues(consume, produce);
	}


}
