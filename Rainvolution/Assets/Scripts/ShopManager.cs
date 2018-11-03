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
                game.Pay(g.GetComponent<Generator>().cost);
                // Update
                if (generator_manager.number_of_gen[g.GetComponent<Generator>().Id] % 10 == 0)
                {
                    generator_manager.generators[g.GetComponent<Generator>().Id].cost *= 1.2f;
                }
                if (generator_manager.number_of_gen[g.GetComponent<Generator>().Id] % 5 == 0)
                    game.water_rate += 2.5f;
                        
            }
        }
    }
}
