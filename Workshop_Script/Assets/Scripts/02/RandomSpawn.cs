using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RandomSpawn : MonoBehaviour
{
    public GameObject smallCubePrefab;

    public float rateOfSpawn = 1f;
    private float nextSpawn = 0;
    public int numberOfCubes;

    //  IT is a list of game objects named cubesList;
    // <Inside this you mention what kind of data you want to add to the list>
    private List<GameObject> cubesList = new List<GameObject>();
    //To accss data, it is same as an array and you access it via cubesList[i]
    
    // Update is called once per frame
    void Update()
    {
        
    }


    public void GenerateCubes()
    {
        // Create an empty list of cubes

        // Spawn cube at random position within the big cube's transform position
        
        
        // Spawn small cube
        

        for (int i = 0; i < numberOfCubes; i++)
        {
            Vector3 randPosition = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
            GameObject smallCube = Instantiate(smallCubePrefab, randPosition, transform.rotation);
            cubesList.Add(smallCube);
        }
        
        // Give random color
        //smallCube.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 0f, 1f, 0f, 1f);

        //int randSize = Random.Range(1, 10);
        //smallCube.transform.localScale = new Vector3(randSize, randSize, randSize);
        
        // Add spawned cube to the list of cubes




    }

    public object GameObject { get; set; }

    public  void DestroyCubes()
    { 
        // This for loop will go through all the cubes generated and 
        // instead of destroying those cubes, this code is destroying the prefab.
        var count = cubesList.Count; 
        for (int i = 0;i < count; i++)
        {
            Destroy(cubesList[i]);
        }
        

    }
}
