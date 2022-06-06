using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialControl : MonoBehaviour
{
    private Material[] mats;

    public Renderer render;

    public Material clipingMat, NewMaterial;

    // Start is called before the first frame update
    void Start()
    {
        mats = render.sharedMaterials;

    }

    public void MaterialChange()
    {
        mats[1] = clipingMat;
        mats[2] = NewMaterial;
        render.sharedMaterials=mats;
    }


}
