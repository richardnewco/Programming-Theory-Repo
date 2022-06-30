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
        if(textbox != null)
        {
            textbox.text = "Welcome abstracton" +

               " Click on one of the buttons to learm more.";



        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
