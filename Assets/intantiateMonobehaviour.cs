using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intantiateMonobehaviour : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    [SerializeField] private GameObject container;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Instantiate(prefab, Vector3.zero, Quaternion.identity, container.transform);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
