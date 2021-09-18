using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public void Up()
    {
        transform.Translate(Vector3.up *Time.deltaTime*7f);
    }

    public void Right()
    {
        transform.Translate(Vector3.right *Time.deltaTime*7f);       
    }

    public void Left()
    {
        transform.Translate(Vector3.left *Time.deltaTime*7f);             
    }

    public void Original()
    {
        transform.position = new Vector3(0, 0.5f, -2);
    }
    
    
    
    
    
}
