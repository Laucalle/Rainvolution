using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventSystem : MonoBehaviour {

    private GameManager game;
    private GeneratorManager generator;
    private ShopManager shop;

	// Use this for initialization
	void Start () {
        game = gameObject.GetComponent<GameManager>();
        generator = gameObject.GetComponent<GeneratorManager>();
        shop = gameObject.GetComponent<ShopManager>();
	}
	
	// Update is called once per frame
	void Update () {

        CheckingForEvents();
	}

    void CheckingForEvents() {
        
    }
}
