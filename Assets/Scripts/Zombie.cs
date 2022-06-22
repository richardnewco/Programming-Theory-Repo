using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour 
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("name" + Singleton.Instance.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
