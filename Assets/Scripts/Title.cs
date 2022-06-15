using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ui namesapce 

using UnityEngine.UI;


public class Title : MonoBehaviour
{
    
    public GameObject inputField;

    [SerializeField] private string yourZombieName;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // function to call 
    public void ReadZombieName()
    {
        yourZombieName = inputField.GetComponent<Text>().text;
        Debug.Log(yourZombieName);
    }
}
