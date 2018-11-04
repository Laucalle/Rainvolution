using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvolveMesh : MonoBehaviour
{
    public ParticleSystem puff;
    AudioSource puffSource;
    public GameObject[] planets;
    GameManager game;
    int active_planet = 0;
    // Use this for initialization
    void Start()
    {
        game = GetComponent<GameManager>();
        puffSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (game.vegetals >= 20 && game.vegetals < 50)
        {
            if (active_planet != 1)
            {
                planets[active_planet].SetActive(false);
                puff.Play();
                puffSource.PlayOneShot(puffSource.clip);
                planets[1].SetActive(true);
                active_planet = 1;

            }

        }
        else if (game.vegetals >= 50 && game.vegetals < 150)
        {
            if (active_planet != 2)
            {
                planets[active_planet].SetActive(false);
                puff.Play();
                puffSource.PlayOneShot(puffSource.clip);

                planets[2].SetActive(true);
                active_planet = 2;
            }
        }
        else if (game.vegetals >= 150)
        {
            if (active_planet != 3)
            {
                planets[active_planet].SetActive(false);
                puff.Play();
                puffSource.PlayOneShot(puffSource.clip);

                planets[3].SetActive(true);
                active_planet = 3;

            }
        }
        else if (game.vegetals < 20) {
            if (active_planet != 0)
            {
                planets[active_planet].SetActive(false);
                puff.Play();
                puffSource.PlayOneShot(puffSource.clip);

                planets[0].SetActive(true);
                active_planet = 0;

            }
        }
    }
}
