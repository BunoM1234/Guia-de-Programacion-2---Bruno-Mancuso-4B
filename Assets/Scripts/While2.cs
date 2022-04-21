using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While2 : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log("Los numeros son iguales");
        }
        else{
        while (num1 < num2)
        {
            Debug.Log("esta es la " + num1 + " vuelta.");
            num1++;
        }
        while (num2 < num1)
        {
            Debug.Log("esta es la " + num2 + " vuelta.");
            num2++;
        }
        }
        Debug.Log("Final");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
