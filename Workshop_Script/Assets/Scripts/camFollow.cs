using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour
{
    public GameObject cameraObj;
    public float distanceFromCam;
    [Range(0,1)]
    public float lerpSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var cameraPosition = cameraObj.transform.position;
        var cameraForward = cameraObj.transform.forward;
        var newPosition= cameraPosition + cameraForward * distanceFromCam;
        transform.position = Vector3.Lerp(transform.position, newPosition, lerpSpeed*Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, cameraObj.transform.rotation, lerpSpeed*Time.deltaTime);
    }
}
