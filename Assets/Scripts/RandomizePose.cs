using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizePose : MonoBehaviour
{

    public bool LocalTF = false;
    public int UpdateRate = 10; // Update rate w.r.t. the framerate
    public float xMinLimit = 0f;
    public float xMaxLimit = 0f;
    public float yMinLimit = 0f;
    public float yMaxLimit = 0f;
    public float zMinLimit = 0f;
    public float zMaxLimit = 0f;
    public float rollMinLimit = 0f;
    public float rollMaxLimit = 0f;
    public float pitchMinLimit = 0f;
    public float pitchMaxLimit = 0f;
    public float yawMinLimit = 0f;
    public float yawMaxLimit = 0f;

    private int frames;
    private Vector3 position;
    private Vector3 orientation;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frames++;
        if (frames % UpdateRate == 0) {
        position = new Vector3(Random.Range(xMinLimit, xMaxLimit), Random.Range(yMinLimit, yMaxLimit), Random.Range(zMinLimit, zMaxLimit));
        orientation = new Vector3(Random.Range(rollMinLimit, rollMaxLimit), Random.Range(pitchMinLimit, pitchMaxLimit), Random.Range(yawMinLimit, yawMaxLimit));
        if (!LocalTF) transform.SetPositionAndRotation(position, Quaternion.Euler(orientation));
        else transform.SetLocalPositionAndRotation(position, Quaternion.Euler(orientation));
        }
    }
}
