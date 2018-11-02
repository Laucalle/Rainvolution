using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

public class Generator : MonoBehaviour
{
    public int Id;
    public string name;
    public string descr;
    public float consume_rate;
    public float produce_rate;
    public int[] multiplier;
    // Add Icon later
    public float cost;
    public bool is_generator = true;


}
