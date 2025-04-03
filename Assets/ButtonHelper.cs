using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHelper : MonoBehaviour
{
    public GameObject GameManager;
    public SceneTools mySceneTools;
    public PlayerData myPlayer;
    public string nextScene;
    Button myButton;

    public string key;
    public bool conditional = false;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.FindGameObjectWithTag("GameManager");
        mySceneTools = GameManager.GetComponent<SceneTools>();
        myPlayer = GameManager.GetComponent<PlayerData>();
        myButton = GetComponent<Button>();
    }

    public void SceneChangeOnClick(float delay)
    {
        Invoke("SceneChange", delay);
    }

    public void Update()
    {
        //if we flag the button as conditional (in other words, can only be used if certain items are in player inventory)
        //then every update loop, check the player inventory for a given key word - if it matches, unlock the button!
        if(conditional)
        {
            //simple loop for checking all items in a list or array
            foreach(string item in myPlayer.inventory)
            {
                //check inventory item against our key word
                if(item == key)
                {
                    myButton.interactable = true; //if we find a match, turn the button back on
                }
            }
        }
    }

    void SceneChange()
    {
        mySceneTools.SceneChanger(nextScene);
    }

    public void AddInventory(string item)
    {
        myPlayer.inventory.Add(item);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        //camelCase has a lower case first word, is used for variables or properties
        //collision.gameObject;
        //PascalCase has an upper case first word, is used for methods/functions/classes
        //GameObject.GetComponent<typeof>();
    }
}
