using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class forcube2 : MonoBehaviour
{
    private Renderer cubeRenderer;
    int n;
    public Text c;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CEN");
        n = 100;
        n--;
        c.text = n.ToString();
    }
}
