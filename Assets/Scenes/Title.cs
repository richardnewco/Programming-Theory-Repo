using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ui namesapce 
using UnityEngine.UI;

// ui namesapce 
using UnityEngine.SceneManagement;



public class Title : MonoBehaviour
{
    // input field
    [SerializeField]private GameObject inputField;

    // your name to store the variable.

    [SerializeField] private string yourZombieName;

    // output the name

    [SerializeField] private Text outputString;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    // function to call 
    private void ReadZombieName()
    {
        // set name to the inputfield of the text 
        yourZombieName = inputField.GetComponent<Text>().text;
        //testin output 
        Debug.Log(yourZombieName);
        // output the text  to message and zombiename
        outputString.text = "Welcome fellow zombie " + yourZombieName;
        //wait a second then change scenes
        Invoke("ChangeScene" ,2.0f);
    }


    private void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }




}
