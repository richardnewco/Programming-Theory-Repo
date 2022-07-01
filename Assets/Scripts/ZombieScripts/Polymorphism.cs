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
        // move the zombie
        speedBP= true;
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
        textPp.text = "Polymorphism you";
    }


    public override void ZombieMovingForward()
    {
        // if the bool is true
        if (speedBP == true)
        {
            // move the zombie
            zombieP.transform.Translate(Vector3.forward * speedP * Time.deltaTime);
        }
    }

    public override void StopZombie()
    {
        //stop the zombie
        speedBP = false;

    }

}

