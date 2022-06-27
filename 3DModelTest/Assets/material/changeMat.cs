using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMat : MonoBehaviour
{
    public Material[] material;
    Renderer rend;

  
    public int x;


    // Start is called before the first frame update
    void Start()
    {

        rend = GetComponent<Renderer>();

 
        rend.sharedMaterial = material[x];
    }

    void Update()
    {
        rend.sharedMaterial = material[x];
    }

    


    public void NextMaterial()
    {
        if (x < 1)
        {
            x++;
        }
        else
        {
            x = 0;
        }
    }
    
}


