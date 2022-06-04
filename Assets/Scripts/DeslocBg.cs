using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeslocBg : MonoBehaviour
{

    private Renderer objetoRender;
    private Material objetoMaterial;
    public float offset;
    public float offsetIncrement;
    public float offsetVelocit;


    public string sortingLayer;
    public int orderinLayer;
    // Start is called before the first frame update
    void Start()
    {
        objetoRender = GetComponent<MeshRenderer>();

        objetoRender.sortingLayerName = sortingLayer;
        objetoRender.sortingOrder = orderinLayer;

        objetoMaterial = objetoRender.material;

    }

    // Update is called once per frame
    void Update()
    {
        offset += offsetIncrement; 
        objetoMaterial.SetTextureOffset("_MainTex", new Vector2(offset * offsetVelocit, 0));
    }
}
