using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamara : MonoBehaviour
{
    public GameObject player;
    public Vector3 camPosOffset;
    public Vector3 camRotOffset;

    //private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //horizontalInput = Input.GetAxis("Horizontal");
        transform.position = player.transform.position + CalPosOffset();
        //transform.Rotate(Vector3.up, horizontalInput);
        //Cam rotation will be slighty behind car velocity angle
        //Also rotate camara based on right stick angle, if 0 it uses default cam.
    }

    private Vector3 CalPosOffset()
    {
        //Make it so cam lags behind just a little bit. Map it to car's top speed?
        //Maybe open pov?
        return camPosOffset;
    }
}
