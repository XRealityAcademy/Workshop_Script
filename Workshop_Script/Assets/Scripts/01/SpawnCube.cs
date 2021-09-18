using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{

    public GameObject cubePrefab;

    public void Spawn()
    {
        GameObject cube= (GameObject)Instantiate(cubePrefab, transform.position, transform.rotation);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
