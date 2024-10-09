using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMaterial : MonoBehaviour
{

  
    public float velocidade;
    private Renderer _renderer;
    void Start()
    {
       _renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(0, velocidade * Time.deltaTime);

        _renderer.material.mainTextureOffset += offset;
       
    }

   
}


