using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnColor : MonoBehaviour
{
    [SerializeField] int count = 0;
    [SerializeField] Color[] colorArray;



    public void ChangeColor()
    {
        gameObject.GetComponent<Image>().color = new Color(colorArray[count].r, colorArray[count].g, colorArray[count].b);

        if (count == colorArray.Length - 1)
        {
            count = -1;
        }
        count += 1;

    }
  
}
