using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inheretance : MonoBehaviour
{
    [SerializeField] private GameObject zombieI;

    [SerializeField] private float speedsI;

    [SerializeField] private bool speedOI = false;

    //get ref to the textfield

    [SerializeField] private Text textyI;

    // get ref to audiosource

    [SerializeField] private AudioSource audioSourceI;

    // get ref to animation
    [SerializeField]private Animator animI;


    // Start is called before the first frame update
    void Start()
    {
        // audio source component
        audioSourceI = GetComponent<AudioSource>();
        //animation component
        animI = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ZombieMovingForward();
    }
    public virtual void ZombieMove()
    { 
        // move the zombie
        speedOI = true;
        // play the audio\
        ZombieSound();
        // print the text
        TextBox();
        // stop the zombie after 2 secosa
        Invoke("StopZombie", 2.0f);

    }
    public virtual void ZombieSound()
    {
        audioSourceI.Play();
    }

    public virtual void TextBox()
    {
        // get reference to the text box
        textyI.text = "fuk you";
    }
  

    public virtual void ZombieMovingForward()
    {
        // if the bool is true
        if (speedOI == true)
        {
            // move the zombie
            zombieI.transform.Translate(Vector3.forward * speedsI * Time.deltaTime);
        }
    }

    public virtual void StopZombie()
    {
        //stop the zombie
        speedOI = false;
      
    }

}
