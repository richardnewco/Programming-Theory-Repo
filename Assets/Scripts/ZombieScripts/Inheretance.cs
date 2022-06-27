using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inheretance : MonoBehaviour
{
    [SerializeField] private GameObject zombieI;

    [SerializeField] private float speeds;

    [SerializeField] private bool speedO = false;

    //get ref to the textfield

    [SerializeField] private Text texty;

    // get ref to audiosource

    [SerializeField] private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        ZombieMovingForward();
    }
    public virtual void ZombieMove()
    {
        // move the zombie
        speedO = true;
        // play the audio\
        ZombieSound();
        // print the text
        TextBox();

        // stop the zombie after 2 secosa
        Invoke("StopZombie", 2.0f);

        //after 2 seconds stop the zombie an have him sit there.

    }
    public virtual void ZombieSound()
    {
        audioSource.Play();
    }

    public virtual void TextBox()
    {
        // get reference to the text box
        texty.text = "fuk you";
    }
    // moving the zombie forward

    public virtual void ZombieMovingForward()
    {
        if (speedO == true)
        {
           zombieI. transform.Translate(Vector3.forward * speeds * Time.deltaTime);

        }
    }

    public virtual void StopZombie()
    {
        //stop the zombie
        speedO = false;
    }

}
