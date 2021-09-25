using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionScripts : MonoBehaviour
{
    private int x = 5;

    private int y = 3;

    private int count = 1;
    private int sum = 0;

    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        // if statement
        if (true)
        {
            // do something
        }

        if (x > 3)
        {
            Debug.Log("X is larger than 3");
        }


        if (x == 5)
        {
            Debug.Log("X is 5");
        }
        
        // if...else statement
        if (true)
        {
            //do something
            Debug.Log("it is true");
        }
        else
        {
            //do something else
            Debug.Log("it is false");
        }
        
        // if...else statement
        if (x > y)
        {
            Debug.Log("x is larger than y");
        }
        else
        {
            Debug.Log("y is larger than x");            
        }

        // if... else if...else if...else
        if (x > y)
        {
            // Do something
        }
        else if (x < y)
        {
            // Do something else
        }
        else
        {
            // Do something else
        }
        
        // if... else if...else if...else example

        if (speed >= 100)
        {
            Debug.Log("You drive too fast ");
        }
        else if (speed >= 80)
        {
            Debug.Log("You drive a little fast ");
        }
        else if (speed > 60)
        {
            Debug.Log("You are in a good speed ");
        }
        else
        {
            Debug.Log("You are too slow ");
        }
        
        //The While Loop
        while (false)
        {
            // Do something until the state turns true
        }
        
        // The While Loop example
        while (count <= 100)
        {
            sum += count;
            count++;
        }
        print(sum);
        
        /*
         for(<create a counter>; <Boolean conditional>; <increment the counter>)
         {
           // Do something
         }
         */

        for (int i = 1; i <= 100; i++)
        {
            sum += i;
        }
        print("for loop" + sum);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
