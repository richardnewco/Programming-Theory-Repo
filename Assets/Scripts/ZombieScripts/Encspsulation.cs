using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Encspsulation : Inheretance
{

    [SerializeField] private GameObject zombieE;

    [SerializeField] private float speedE;

    [SerializeField] private bool speedeE = false;

    //get ref to the textfield

    [SerializeField] private Text textE;

    // get ref to audiosource

    [SerializeField] private AudioSource audioSourceE;

    // get ref to animation
    [SerializeField] private Animator animE;

    private int numE = 0;


    // Start is called before the first frame update
    void Start()
    {
        // audio source component
        audioSourceE = GetComponent<AudioSource>();
        //animation component
        animE = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ZombieMovingForward();
    }
    public override void ZombieMove()
    {
        numE++;
        // move the zombie
        speedeE = true;
        // play the audio
        ZombieSound();
        // print the text
        TextBox();
        // stop the zombie after 2 seconds
        Invoke("StopZombie", 2.0f);

    }
    public override void ZombieSound()
    {
        audioSourceE.Play();
    }

    public override void TextBox()
    {
        // get reference to the text box
        textE.text = "Ecapsulation you";
    }


    public override void ZombieMovingForward()
    {
        // if the bool is true
        if (speedeE == true)
        {
            // move the zombie
            // zombieE.transform.Translate(Vector3.forward * speedE * Time.deltaTime);
            MovingBacknForward();
        }
    }

    public override void StopZombie()
    {
        //stop the zombie
        speedeE = false;

    }
    public override void MovingBacknForward()
    {
        //added one.

        // if it is even move forward 
        if (numE % 2 == 0)
        {
            //move the zombie
            zombieE.transform.Translate(Vector3.back * speedE * Time.deltaTime);
        }
        else
        {
            zombieE.transform.Translate(Vector3.forward * speedE * Time.deltaTime);

        }

    }
}


