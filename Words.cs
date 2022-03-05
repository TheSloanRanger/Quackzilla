using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Words : MonoBehaviour
{
    // Initialise variables
    public int correctWords;
    int randInt;
    string word;
    public string[] foods1, foods2, foods3;
    public InputField input;
    public Sprite[] spriteArray1, spriteArray2, spriteArray3;
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        correctWords = 0;
        nextWord();
    }

    public void nextWord()
    {
        

        if (correctWords >= 10)
        {
            randInt = Random.Range(0, foods3.Length);
            word = foods3[randInt];
            spriteRenderer.sprite = spriteArray3[randInt];
        }

        else if (correctWords >= 5)
        {
            randInt = Random.Range(0, foods2.Length);
            word = foods2[randInt];
            spriteRenderer.sprite = spriteArray2[randInt];
        }
        else
        {
            randInt = Random.Range(0, foods1.Length);
            word = foods1[randInt];
            spriteRenderer.sprite = spriteArray1[randInt];
        }
    }

    public void readInput()
    {
        if (input.text == word)
        {
            correctWords++;
            // increase duck size????
        }
        else
        {
            // decrease duck size???
        }

        nextWord();
    }


    /*
        Pick random word from array
        Set the image in thought bubble to the associated food item
        Get user input
        If user input == correct food item
            Then increase duck size and score
        Else
            Then decrease duck size and score
    */

}