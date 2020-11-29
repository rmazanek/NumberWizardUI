using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizardUI : MonoBehaviour
{

    [SerializeField] int guessMin;
    [SerializeField] int guessMax;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;
    
    void Start()
    {
        StartGame();
    }
    
    public void StartGame()
    {
        guess = (guessMax  + guessMin) / 2;
        guessText.text = guess.ToString();
        guessMax = guessMax + 1;
    }
    
    public void OnPressHigher()
    {
        guessMin = guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        guessMax = guess;
        NextGuess();
    }
    
    void NextGuess()
    {
        guess = (guessMax  + guessMin) / 2;
        
        if (guess == 1000)
        {
            guessMin = 1000;
        }
        
        guessText.text = guess.ToString();
    }
}
