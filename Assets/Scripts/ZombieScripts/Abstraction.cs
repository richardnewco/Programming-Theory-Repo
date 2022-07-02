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

    [SerializeField] private int numA = 0;

    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    private void Update()
    {
        // if bool is true 
        if (speedOA == true)
        {

            //move the zombie
            MovingBacknForward();

        }
    }
    public override void ZombieMove()
    {
       
        //added one.
        numA++;
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
        audioSourceA.Play();

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
        
       
        // if it is even move forward 
        if(numA % 2 == 0)
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






