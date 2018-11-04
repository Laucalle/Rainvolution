using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManager : MonoBehaviour {
    
    private GameObject current_tree;

    private int counter;
    public int planet1;
    public int planet2;
    public int planet3;

    [Header("GameManager")]
    public GameManager game;

    [Header("Trees")]
    public GameObject[] trees;

	// Use this for initialization
	void Start () {
        counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
        
        float vegetals_clone = game.vegetals;

        if (gameObject.activeInHierarchy && gameObject.name == "ice_gray") {
            if ((vegetals_clone > counter + 1) && (vegetals_clone < counter + 2))
            {
                trees[counter].SetActive(true);
                if (counter < trees.Length - 1)
                    counter += 1;
            }
        }
        else if (gameObject.activeInHierarchy && gameObject.name == "egipt")
        {
            if ((vegetals_clone > counter + 1 + planet1) && (vegetals_clone < counter + 2 + planet1))
            {
                trees[counter].SetActive(true);
                if (counter < trees.Length - 1)
                    counter += 1;
            }
        }
        else if (gameObject.activeInHierarchy && gameObject.name == "ice")
        {
            if ((vegetals_clone > counter + 1 + planet2) && (vegetals_clone < counter + 2 + planet2))
            {
                trees[counter].SetActive(true);
                if (counter < trees.Length - 1)
                    counter += 1;
            }
        }
        else if (gameObject.activeInHierarchy && gameObject.name == "forest")
        {
            if ((vegetals_clone > counter + 1 + planet3) && (vegetals_clone < counter + 2 + planet3))
            {
                trees[counter].SetActive(true);
                if (counter < trees.Length - 1)
                    counter += 1;
            }
        }


        
	}
}
