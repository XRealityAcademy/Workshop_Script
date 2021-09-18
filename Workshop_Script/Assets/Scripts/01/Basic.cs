using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic : MonoBehaviour
{
    public int num01 = 7;

    public string myDay = "Happy Friday";
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Hi, I am sleepy!");
       Debug.Log(num01);
       Debug.Log(myDay);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
