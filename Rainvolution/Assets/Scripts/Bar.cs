using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour {


   
    public float fillAmount;
    [SerializeField]
    private float Maximo;
    [SerializeField]
    private float Minimo;
    [SerializeField]
    private Image content;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HandleBar();
    }

    private void HandleBar()
    {
    content.fillAmount = Map(fillAmount,Minimo,Maximo,0,1); 
    }
    private float Map(float value, float inMin, float inMax, float outMin, float outMax)
    {
        return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }
}
