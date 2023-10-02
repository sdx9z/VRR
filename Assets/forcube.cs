using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcube : MonoBehaviour
{
    private Renderer cubeRenderer;  // —сылка на компонент Renderer куба 
    public int a;
    public int b;
    public int c;
    public GameObject sphere;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            a = Random.Range(0, 255);
            b = Random.Range(0, 255);
            c = Random.Range(0, 255);
            this.gameObject.GetComponent<Renderer>().material.color = new Color32((byte)a, (byte)b, (byte)c, 1);
        }
    }
}
