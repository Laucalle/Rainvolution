using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeGenerator : MonoBehaviour {

    public GameObject image0;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;

    public GeneratorManager generator;

    public Text name;
    public Text cost;
    public Text total;

	// Use this for initialization
	void Start () {
        name.text = "Green Algae";
        cost.text = generator.generators[0].cost.ToString();
        total.text = generator.number_of_gen[0].ToString();
	}
	
	// Update is called once per frame
	void Update () {
        if (generator.number_of_gen[0] >= 0 && generator.number_of_gen[0] <= 10){
            name.text = "Green Algae";
            cost.text = generator.generators[0].cost.ToString();
            total.text = generator.number_of_gen[0].ToString();
        }
        else if (generator.number_of_gen[0] > 10 && generator.number_of_gen[0] <= 20) {
            image0.SetActive(false);
            image1.SetActive(true);
            name.text = "Red Algae";
            cost.text = generator.generators[0].cost.ToString();
            total.text = generator.number_of_gen[0].ToString();
        }
        else if (generator.number_of_gen[0] > 20 && generator.number_of_gen[0] <= 30)
        {
            image1.SetActive(false);
            image2.SetActive(true);
            name.text = "Fern";
            cost.text = generator.generators[0].cost.ToString();
            total.text = generator.number_of_gen[0].ToString();
        }
        else if (generator.number_of_gen[0] > 30 && generator.number_of_gen[0] <= 40)
        {
            image2.SetActive(false);
            image3.SetActive(true);
            name.text = "Grass";
            cost.text = generator.generators[0].cost.ToString();
            total.text = generator.number_of_gen[0].ToString();
        }


            
	}
}
