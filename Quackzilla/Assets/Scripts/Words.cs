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
    public string[] foods;
    public InputField input;
    public Sprite[] sprites;
    public SpriteRenderer spriteRenderer;
    public AudioClip[] duckSounds;
    public AudioSource source;
    WordScript ws;
    MoveFood mf;
    // Start is called before the first frame update
    void Start()
    {
        correctWords = 0;
        nextWord();
    }

    public void nextWord()
    {
        randInt = Random.Range(0, foods.Length);
        word = foods[randInt];
        spriteRenderer.sprite = sprites[randInt];
    }

    public void readInput()
    {
        if (input.text == word)
        {
            correctWords++;
            mf = FindObjectOfType<MoveFood>();
            input.enabled = false;
            mf.StartMovingFood(this);
        }
        else
        {
            ws = FindObjectOfType<WordScript>();
            ws.decreaseSize();
            input.text = "";
            nextWord();
        }

        
    }


    public void moveFoodFinished()
    {
        ws = FindObjectOfType<WordScript>();
        ws.IncreaseSize();
        if (correctWords > 10)
        {
            source.PlayOneShot(duckSounds[2], 1);
        }
        else if (correctWords > 5)
        {
            source.PlayOneShot(duckSounds[1], 1);
        }
        else
        {
            source.PlayOneShot(duckSounds[0], 1);
        }
        input.text = "";
        input.enabled = true;
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