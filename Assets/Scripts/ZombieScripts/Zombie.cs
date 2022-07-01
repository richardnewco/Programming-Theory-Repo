using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ui nameSpace
using UnityEngine.UI;

public class Zombie : MonoBehaviour
{
    // making ref to text box
    [SerializeField] private Text textbox;

    // Start is called before the first frame update
    void Start()
    {

       // textbox = GetComponent<Text>();


        textbox = GameObject.FindWithTag("Inher").GetComponent<Text>();

        if (textbox != null)
        {
            Debug.Log("text box exists");

            textbox.text = "Welcome " + Singleton.Instance.text+

              " Click on one of the buttons to learm more.";



        }
         



    }


}
