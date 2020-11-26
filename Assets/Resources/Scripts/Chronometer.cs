using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chronometer : MonoBehaviour
{

    [SerializeField]
    private int _test;

    [SerializeField]
    private bool _isActive = false;

    

    public void play()
    {
        _isActive = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //Time.deltaTime
    }
}
