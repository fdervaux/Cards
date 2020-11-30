using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Chronometer : MonoBehaviour
{

    // Un chronometre
    // resume()
    // play()
    // pause()
    // updateTime(deltaTime) //s 
    // float getTime()

    private float _time = 0;

    [SerializeField]
    private bool _isInPlayMode = false;

    public void play()
    {
        _isInPlayMode = true;
    }

    public void pause()
    {
        _isInPlayMode = false;
    }

    public void resume()
    {
        _time = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        play();
    }

    public void updateTime(float deltaTime)
    {
        if(_isInPlayMode)
            _time += deltaTime;
    }

    public float getTime()
    {
        return _time;
    }

    // Update is called once per frame
    void Update()
    {
        updateTime(Time.deltaTime);
        Debug.Log(getTime());
    }
}
