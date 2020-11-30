using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Chronometer : MonoBehaviour
{

    // Un chronometre
    // reset()
    // play()
    // stop()
    // updateTime(deltaTime) //s 
    // float getTime()

    [SerializeField]
    private int monInt = 12;

    [NonSerialized]
    public int monInt2 = 24;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void updateTime(float deltaTime)
    {

    }

    // Update is called once per frame
    void Update()
    {
        updateTime(Time.deltaTime);
    }
}
