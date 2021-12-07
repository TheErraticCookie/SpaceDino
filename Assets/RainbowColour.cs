using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowColour : MonoBehaviour {

    Renderer rend;
    Material material;

    void Start () {
        rend = GetComponent<Renderer>();
        material = rend.material;
        material.SetColor("_Colour", Color.magenta);
    }
    
    void Update () {
        
    }
}

