using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Polymorphism : Inheretance
{
    [SerializeField] private GameObject zombieP;

    [SerializeField] private float speedP;

    [SerializeField] private bool speedBP = false;

    //get ref to the textfield

    [SerializeField] private Text textPp;

    // get ref to audiosource

    [SerializeField] private AudioSource audioSource;

    // get ref to animation
    [SerializeField] private Animator animP;

    private int numP = 0;


    // Start is called before the first frame update
    void Start()
    {
        // audio source component
        audioSource = GetComponent<AudioSource>();
        //animation component
        animP = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ZombieMovingForward();
    }
    public override void ZombieMove()
    {
        numP++;
        // move the zombie
        speedBP = true;
        // play the audio\
        ZombieSound();
        // print the text
        TextBox();
        // stop the zombie after 2 secosa
        Invoke("StopZombie", 2.0f);

    }
    public override void ZombieSound()
    {
        audioSource.Play();
    }

    public override void TextBox()
    {
        // get reference to the text box
        textPp.text = "Polymorphism is where we overloaded the functions, an example of this is where we used the move forward function.All zombie have a different way of moving.An example is the skull moves vertically where the girl moves horizontally.";

    }


    public override void ZombieMovingForward()
    {
        // if the bool is true
        if (speedBP == true)
        {
            // move the zombie
            // zombieP.transform.Translate(Vector3.forward * speedP * Time.deltaTime);
            MovingBacknForward();
        }
    }

    public override void StopZombie()
    {
        //stop the zombie
        speedBP = false;

    }
    public override void MovingBacknForward()
    {
        //added one.

        // if it is even move forward 
        if (numP % 2 == 0)
        {
            //move the zombie
            zombieP.transform.Translate(Vector3.back * speedP * Time.deltaTime);
        }
        else
        {
            zombieP.transform.Translate(Vector3.forward * speedP * Time.deltaTime);

        }

    }
}

