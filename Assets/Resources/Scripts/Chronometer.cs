using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public struct ChronometerData
{
    public bool _isActive;
    public float _chronoTime;
}

public class Chronometer : MonoBehaviour
{

    [SerializeField]
    private Text _chronoText;

    private ChronometerData _chronometerData;

    public void play()
    {
        _chronometerData._isActive = true;
    }

    public void pause()
    {
        _chronometerData._isActive = false;
    }

    public void reset()
    {
        _chronometerData._chronoTime = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        _chronometerData = new ChronometerData();
        _chronometerData._isActive = false;
        _chronometerData._chronoTime = 0;
    }

    public string FormatTime(float time)
    {
        time = time * 100;
        int minutes = (int) time / 6000;
        int seconds = (int) time / 100 - 60 * minutes;
        int milliseconds = (int) time - minutes * 6000 - 100 * seconds;
        return string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
    }

    // Update is called once per frame
    void Update()
    {
        if(_chronometerData._isActive)
        {
            _chronometerData._chronoTime += Time.deltaTime;
        }

        _chronoText.text = FormatTime(_chronometerData._chronoTime);
    }
}
