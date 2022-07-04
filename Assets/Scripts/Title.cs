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

    // ENCAPSULATION

    private string texty;

    public string Texty
    {
        get
        {
            // assigna  name to input field
            yourZombieName = inputField.GetComponent<Text>().text;
            // assign that to texty variable
            texty = yourZombieName;

            return texty;

        }
        set
        {
            // set the output to texty 
           texty = outputString.text;
            // set that to the value
            texty = value;
        }
    }
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
        // output the text  to message and zombienamet
        outputString.text = "Let's learn together " + Texty;

        //save zombie name to singleton
        Singleton.Instance.text = Texty;

        //wait a second then change scenes
        Invoke("ChangeScene" ,2.0f);
    }


    private void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }




}
