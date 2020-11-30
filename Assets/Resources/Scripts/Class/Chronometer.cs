using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Chronometer : MonoBehaviour
{

    // Un chronometre
    // resume()
    // play()
    // pause()
    // updateTime(deltaTime) //s 
    // float getTime()

    [SerializeField]
    private Text chronoText; 

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

    public string getTime()
    {
        return _time.ToString("#00.00");
    }

    // Update is called once per frame
    void Update()
    {
        updateTime(Time.deltaTime);
        Debug.Log(getTime());

        chronoText.text = getTime();
    }
}
