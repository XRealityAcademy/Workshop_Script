using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeChange : MonoBehaviour
{
    // Start is called before the first frame update
    public void UP()
    {
        transform.Translate(Vector3.up*Time.deltaTime*7f);
    }
    
    public void Right()
    {
        transform.Translate(Vector3.right*Time.deltaTime*7f);
    }
    
    public void Left()
    {
        transform.Translate(Vector3.left*Time.deltaTime*7f);
    }
    
    public void Original()
    {
        transform.position = new Vector3(0, 0.5f, -5);
    }

}
