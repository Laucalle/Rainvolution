using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratorManager : MonoBehaviour 
{
    public Generator[] generators;
    public int[] number_of_gen;

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

        game.setValuesGenerator(consume, produce);
        CheckForNewPowers();

	}

    void CheckForNewPowers () {
        int total_powers = 0;

        for (int i = 0; i < number_of_gen.Length; i++) {
            total_powers += number_of_gen[i];
        }

        //switch (total_powers) {

            // Unlock PowerUp1
            //case 10:
            //    panel.transform.Find("PowerUp1").gameObject.SetActive(true);
            //    // When power up set active to true, update counter +1
            //    break;

            //// Unlock Generator2
            //case 25:
            //    panel.transform.Find("Generator2").gameObject.SetActive(true);
            //    break;

            //case 50:
                //panel.transform.Find("PowerUp2").gameObject.SetActive(true);
                //break;

            //case 100:
            //    panel.transform.Find("Generator3").gameObject.SetActive(true);
            //    break;

            //case 200:
            //    panel.transform.Find("PowerUp3").gameObject.SetActive(true);
            //    break;

            //case 400:
            //    panel.transform.Find("Generator4").gameObject.SetActive(true);
            //    break;

            //case 1000:
            //    panel.transform.Find("PowerUp4").gameObject.SetActive(true);
            //    break;

            //case 2000:
            //    panel.transform.Find("Generator5").gameObject.SetActive(true);
            //    break;

            //case 5000:
            //    panel.transform.Find("PowerUp5").gameObject.SetActive(true);
            //    break;

            //case 10000:
            //    panel.transform.Find("Generator6").gameObject.SetActive(true);
            //    break;

            //case 20000:
                //panel.transform.Find("PowerUp6").gameObject.SetActive(true);
                //break;
        //}
    }


}
