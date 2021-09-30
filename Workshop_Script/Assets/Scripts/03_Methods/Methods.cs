using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
    public GameObject cube;
    public int health = 100;
    
    // Start is called before the first frame update
    void Start()
    {
       
        Debug.Log("The Cube's health is " + health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    

    public void CubeColorChange()
    {
        cube.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
    }

    int TakeDemage(int damageAmount)
    {
        int health = 100;
        return health - damageAmount;
    }
}
