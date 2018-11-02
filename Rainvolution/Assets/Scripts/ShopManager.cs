using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShopManager : MonoBehaviour
{
    private GameManager game;
    private GeneratorManager generator_manager;

	private void Start()
	{
        generator_manager = gameObject.GetComponent<GeneratorManager>();
        game = gameObject.GetComponent<GameManager>();
	}

	public void Shop (GameObject g) {

        if (g.GetComponent<Generator>() != null) {
            if (game.water > g.GetComponent<Generator>().cost)
            {
                generator_manager.number_of_gen[g.GetComponent<Generator>().Id] += 1;
                game.Pay(g.GetComponent<Generator>().cost, true);
                if (generator_manager.number_of_gen[g.GetComponent<PowerUp>().Id] % 10 == 0)
                {
                    generator_manager.generators[g.GetComponent<PowerUp>().Id].cost *= 2;
                }
            }
        }
        else if (g.GetComponent<PowerUp>() != null) {
            if (game.O2 > g.GetComponent<PowerUp>().cost)
            {
                generator_manager.number_of_pow[g.GetComponent<PowerUp>().Id] += 1;
                game.Pay(g.GetComponent<PowerUp>().cost, false);
                if (generator_manager.number_of_pow[g.GetComponent<PowerUp>().Id] % 10 == 0)
                {
                    generator_manager.power_ups[g.GetComponent<PowerUp>().Id].cost *= 2;
                }
                    
            }
        }
        
    }
}
