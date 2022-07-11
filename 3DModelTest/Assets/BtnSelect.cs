using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnSelect : MonoBehaviour
{

    public GameObject[] Obj;
    public int x; //0,1 


    [SerializeField] Color[] colorArray;

    void Start()
    {

        //...

    }

    void Update()
    {
        //...
    }

    public void SelectSkin()
    {
        //x는 0으로 시작


        if (x < 1)
        {
            x++; //x가 1일 때

            //...

            //버튼 색상
            Obj[0].GetComponent<Image>().color = new Color(colorArray[0].r, colorArray[0].g, colorArray[0].b);


            // 버튼 비활성화
             Obj[1].GetComponent<Button>().interactable = false;
            Obj[2].GetComponent<Button>().interactable = false;
        }
        else
        {
            //x가 1에서 0으로 변경 
            x = 0;

            //...

            //버튼 색상
            Obj[0].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);

            //버튼 활성화
            Obj[1].GetComponent<Button>().interactable = true;
            Obj[2].GetComponent<Button>().interactable = true;

        }

    }

    public void SelectMuscle()
    {
        if (x < 1)
        {
            x++;

            //...

            Obj[0].GetComponent<Image>().color = new Color(colorArray[0].r, colorArray[0].g, colorArray[0].b);
            Obj[1].GetComponent<Image>().color = new Color(colorArray[0].r, colorArray[0].g, colorArray[0].b);

            Obj[0].GetComponent<Button>().interactable = false;
            Obj[2].GetComponent<Button>().interactable = false;



        }
        else
        {
            x = 0;

            //...

            Obj[0].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);
            Obj[1].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);

            Obj[0].GetComponent<Button>().interactable = true;
            Obj[2].GetComponent<Button>().interactable = true;
        }

    }



    public void SelectBone()
    {
        if (x < 1)
        {
            x++;

            //...

            Obj[0].GetComponent<Image>().color = new Color(colorArray[0].r, colorArray[0].g, colorArray[0].b);
            Obj[1].GetComponent<Image>().color = new Color(colorArray[0].r, colorArray[0].g, colorArray[0].b);
            Obj[2].GetComponent<Image>().color = new Color(colorArray[0].r, colorArray[0].g, colorArray[0].b);

            Obj[0].GetComponent<Button>().interactable = false;
            Obj[1].GetComponent<Button>().interactable = false;
        }
        else
        {
            x = 0;

            //...

            Obj[0].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);
            Obj[1].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);
            Obj[2].GetComponent<Image>().color = new Color(colorArray[1].r, colorArray[1].g, colorArray[1].b);

            Obj[0].GetComponent<Button>().interactable = true;
            Obj[1].GetComponent<Button>().interactable = true;
        }

    }

}