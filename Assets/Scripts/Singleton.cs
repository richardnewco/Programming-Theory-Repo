using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System;

public class Singleton : MonoBehaviour
{
    //accessable on any script with the instance

    public static Singleton Instance;

   // internal void LoadText()
    //{
      //  throw new NotImplementedException();
   // }

    //getting ref to the text
    public string text;

    private void Awake()
    {
        // if this  already exists
        if (Instance != null)
        {
            Destroy(gameObject);
            // return to game
            return;
        }
        else
        {
            // use this instance
            Instance = this;
            // dont destroy this
            DontDestroyOnLoad(gameObject);


        }
    }
    class SaveData
    {
        // variable to store the text
        public string text;
        /// saving the json data


        // saving the textto the json format .
        public void SaveText()
        {
            // making an instance of the class SaveData and assigning a new variable called data
            SaveData data = new SaveData();

            // assigning the text this new data variable 
            data.text = text;


            // print to console text when saved in the main manager exit game
            Debug.Log("print " + data.text);

            // making a json string to hold  this new variable called  data 
            string json = JsonUtility.ToJson(data);

            // testing the string
            Debug.Log(json);

            //saving this data to json format string

            File.WriteAllText(Application.dataPath + "/saveFile.json", json);
        }

        public void LoadText()
        {
            // getting reference to previously savefile.json
            string path = Application.dataPath + "/saveFile.json";

            // checking if file exists if not nothing happens
            if (File.Exists(path))
            {
                // read file 
                string json = File.ReadAllText(path);

                // transforming from json to unity variable
                SaveData data = JsonUtility.FromJson<SaveData>(json);

                // setting the text to the new saved  text
                text = data.text;

                // testing to see if it works
                Debug.Log("printing" + text);
            }

        }
    }
}


