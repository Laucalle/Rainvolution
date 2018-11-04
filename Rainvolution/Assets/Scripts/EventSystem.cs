using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventSystem : MonoBehaviour {

    private GameManager game;
    private GeneratorManager generator;
    private ShopManager shop;

    private bool first_event = true;
    private bool new_event_hurricane = false;
    private bool new_event_brutal_sun = false;
    private bool new_special_event = false;

    private bool new_update = false;

    private float waiting_time = 15.0f;

    private float time = 0.0f;

    public Text console;

    [Header("Tutorial objects")]
    public GameObject tutoButton1;
    public GameObject tutoButton2;
    public GameObject tutoButton3;
    public GameObject tutoButton4;
    public GameObject tutoButton5;
    public GameObject tutoButton6;

    public GameObject shadow_panel1_1;
    public GameObject shadow_panel1_2;
    public GameObject shadow_panel1_3;
    public GameObject shadow_panel1_4;
    public GameObject shadow_panel1_5;



	// Use this for initialization
	void Start () {
        Time.timeScale = 0.0f;
        tutoButton1.SetActive(true);
        shadow_panel1_1.SetActive(true);
        shadow_panel1_2.SetActive(true);
        console.text = "Welcome to Rainvolution \nLet's do a very little tutorial";

        game = gameObject.GetComponent<GameManager>();
        generator = gameObject.GetComponent<GeneratorManager>();
        shop = gameObject.GetComponent<ShopManager>();
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(waiting_time);

        if (new_event_hurricane)
        {
            time -= Time.deltaTime;
            if (time <= 0.0f && new_event_hurricane)
            {
                console.text = "The hurricane destroy some vegetals and kill some animals";
                game.animals -= (game.animals * 0.3f);
                game.vegetals -= (game.vegetals * 0.2f);
                game.O2 -= (game.O2 * 0.6f);
                new_event_hurricane = false;
                time = -1.0f;
                waiting_time = 15.0f;
            }
        }
        else if (new_event_brutal_sun){
            time -= Time.deltaTime;
            if (time <= 0.0f && new_event_brutal_sun)
            {
                console.text = "The sun has caused fires and killed some animals";
                game.animals -= (game.animals * 0.2f);
                game.vegetals -= (game.vegetals * 0.4f);
                game.water -= (game.water * 0.4f);
                new_event_brutal_sun = false;
                time = -1.0f;
                waiting_time = 15.0f;
            }
        }
        else if (new_special_event) {
            time -= Time.deltaTime;
            if (time <= 0.0f && new_special_event)
            {
                console.text = "the storm has destroyed half of everything";
                game.animals -= (game.animals * 0.5f);
                game.vegetals -= (game.vegetals * 0.5f);
                game.water -= (game.water * 0.5f);
                game.O2 -= (game.O2 * 0.5f);
                new_special_event = false;
                time = -1.0f;
                waiting_time = 15.0f;
            }
        }
        else
        {
            if ((game.O2 > 90.0f && game.O2 <= 100.0f) && waiting_time <= 0.0f)
            {
                float value = Random.Range(0.0f, 10.0f);
                if (value > 8.5f)
                {
                    console.text = "Hurricane on the way, be careful. Time of arrival: 15 seconds";
                    new_event_hurricane = true;
                    time = 10.0f;
                }
            }
            else if ((game.water > 100.0f) && waiting_time <= 0.0f) {
                float value = Random.Range(0.0f, 10.0f);
                if (value > 7.5f)
                {
                    console.text = "The sun shines a lot, a good drought is approaching: 10 seconds";
                    new_event_brutal_sun = true;
                    time = 6.0f;
                }
            }
            else if ((game.water > 90.0f && game.water <= 100.0f && game.O2 > 100.0f) && waiting_time <= 0.0f)
            {
                float value = Random.Range(0.0f, 10.0f);
                if (value < 0.5f)
                {
                    console.text = "Link played the song of the storm and is forming a very large. 12 seconds to receive the storm";
                    new_special_event = true;
                    time = 12.0f;
                }
            }
        }
            
	}

    void FixedUpdate()
    {
        waiting_time -= Time.deltaTime;

        if (waiting_time <= 0.0f) {
            waiting_time = -1.0f;
        }

	}

	public void tuto1 () {
        shadow_panel1_2.SetActive(false);
        console.text = "here you have your planet, it is a planet that you will have to make evolve by controlling the amount of water and oxygen it has. To make it rain, you can press on your planet.";
        tutoButton1.SetActive(false);
        tutoButton2.SetActive(true);
    }

    public void tuto2 () {
        shadow_panel1_1.SetActive(false);
        shadow_panel1_5.SetActive(true);
        console.text = "If it rains, your water indicator will increase and create plants and wildlife that you will have to keep alive.";
        tutoButton2.SetActive(false);
        tutoButton3.SetActive(true);
    }

    public void tuto3 () {
        shadow_panel1_5.SetActive(false);
        shadow_panel1_3.SetActive(true);
        shadow_panel1_4.SetActive(true);
        console.text = "Also with this water you can buy oxygen generators, to maintain the planet with an adequate atmosphere for your plants and animals";
        tutoButton3.SetActive(false);
        tutoButton4.SetActive(true);
    }

    public void tuto4 () {
        shadow_panel1_3.SetActive(false);
        shadow_panel1_4.SetActive(false);
        console.text = "On the left you have the number of living beings on your planet, if you reach the right number, who knows, maybe you will get a better planet.";
        tutoButton4.SetActive(false);
        tutoButton5.SetActive(true);
    }

    public void tuto5 () {
        console.text = "For now it's all, let's see if you can keep the planet alive.Good luck";
        tutoButton5.SetActive(false);
        tutoButton6.SetActive(true);
    }

    public void setEnabled () {
        console.text = "";
        tutoButton6.SetActive(false);
        Time.timeScale = 1.0f;
    }
    
}