using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    public TextMeshProUGUI textGuess;
    public GameObject buttonHigher;
    public GameObject buttonLower;
    public GameObject buttonRightNumber;
    public GameObject buttonNewGame;

    int min = 1;
    int max = 200;
    int guess;



    // Start is called before the first frame update
    void Start()
    {
        NewGame();
        WriteMessage();
    }

    // Update is called once per frame
    void Update()
    {
      
    }


    private void WriteMessage()
    {
        Debug.Log("Number Wizard");
        Debug.Log("Pick a number between 1 and 200");
    }

    private void NextGuess()
    {
        guess = (min + max) / 2;
        //Debug.Log("Guess " + guess);
        Debug.Log("Is your number higher or lower than... " + guess);
        textGuess.text = guess.ToString();
    }

    public void Higher()
    {
        Debug.Log("Key Pressed up");
        min = guess + 1;
        NextGuess();
    }

    public void Lower()
    {
        Debug.Log("Key Pressed down");
        max = guess - 1;
        NextGuess();
    }

    public void Equal()
    {
        Debug.Log("Key Pressed return");
        Debug.Log("Fertig");
        buttonHigher.SetActive(false);
        buttonLower.SetActive(false);
        buttonRightNumber.SetActive(false);
        buttonNewGame.SetActive(true);
    }

    public void NewGame()
    {
        min = 1;
        max = 200;
        NextGuess();
        buttonHigher.SetActive(true);
        buttonLower.SetActive(true);
        buttonRightNumber.SetActive(true);
        buttonNewGame.SetActive(false);
    }
}
