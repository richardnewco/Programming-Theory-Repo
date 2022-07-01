using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Abstraction : Inheretance
{

    //  gameobject 
    [SerializeField] private GameObject zombieA;

    // speed 
    [SerializeField] private float speedsA;

    //bool for the speed
    [SerializeField] private bool speedOA = false;

    //get ref to the textfield
    [SerializeField] private Text textyA;

    // get ref to audiosource

    [SerializeField] private AudioSource audioSourceA;

    // get ref to animation
    [SerializeField] private Animator animA;

    [SerializeField] private int num = 0;

    // Start is called before the first frame update
    void Start()
    {
        // created a var
        
    }

    // Update is called once per frame
    private void Update()
    {
        // if bool is true 
        if (speedOA == true)
        {
            MovingBacknForward();
            //move the zombie
            //zombieA.transform.Translate(Vector3.forward * speedsA * Time.deltaTime);
            // MovingBacknForward();

        }
    }
    public override void ZombieMove()
    {
       
        //added one.
        num++;

        Debug.Log(num);

        // bool
        speedOA = true;
        //text
        TextBox();
        //zombiesound
        ZombieSound();
        // stop the zombie after 2 secosa
        Invoke("StopZombie", 2.0f);

    }
    public override void ZombieSound()
    {
        // if clicked play zombie sound
       
    }

    public override void TextBox()
    {
        // get reference to the text box
        textyA.text = "doggy god";
      
    }
    public override void StopZombie()
    {
        //stop the zombie
        speedOA = false;

    }
    public override void MovingBacknForward()
    {
        //added one.
       
        // if it is even move forward 
        if(num % 2 == 0)
        {
            //move the zombie
            zombieA.transform.Translate(Vector3.back * speedsA * Time.deltaTime);
        }
        else
        {
            zombieA.transform.Translate(Vector3.forward * speedsA * Time.deltaTime);

        }



    }


}






