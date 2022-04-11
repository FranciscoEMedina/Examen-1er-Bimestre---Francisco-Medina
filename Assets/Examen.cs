using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examen : MonoBehaviour
{
    public string CategoriaDelAnimal;
    public int DiasEstadia;
    int GramosDeAlimeto;
    int precio;
    // Start is called before the first frame update
    void Start()
    {
        
        if (CategoriaDelAnimal != "G" && CategoriaDelAnimal != "PP" && CategoriaDelAnimal != "PG"|| DiasEstadia <= 2)
        {
            Debug.Log("La categoria del animal no existe o la cantidad de días es menor a 3");
        }
    
        else if (CategoriaDelAnimal == "G")
        {
            GramosDeAlimeto= DiasEstadia * 300;
            precio = GramosDeAlimeto / 100 * 80;
            Debug.Log("Para ese periodo se necesitan " + GramosDeAlimeto + " gramos de alimento");
            Debug.Log("El costo de todo el alimento es $" + precio);
        }
        else if (CategoriaDelAnimal == "PP")
        {
            GramosDeAlimeto = DiasEstadia * 400;
            precio = GramosDeAlimeto / 100 * 80;
            Debug.Log("Para ese periodo se necesitan " + GramosDeAlimeto + " gramos de alimento");
            Debug.Log("El costo de todo el alimento es $" + precio);
        }
        else if (CategoriaDelAnimal == "PG")
        {
            GramosDeAlimeto = DiasEstadia * 700;
            precio = GramosDeAlimeto / 100 * 80;
            Debug.Log("Para ese periodo se necesitan " + GramosDeAlimeto + " gramos de alimento");
            Debug.Log("El costo de todo el alimento es $" + precio);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
