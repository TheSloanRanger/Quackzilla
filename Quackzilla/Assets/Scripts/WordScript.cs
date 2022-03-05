using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordScript : MonoBehaviour
{
    public GameObject duck;
    public SpriteRenderer spriteRenderer;
    public Sprite duck_sprite2;
    public Sprite duck_sprite3;
    public int words_typed = 0;
    StartGame sg;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreaseSize()
    {
        float y_pos = duck.transform.position.y;
        y_pos++;
        Vector3 currentScaleVector = duck.transform.localScale;
        currentScaleVector.x = currentScaleVector.x + 0.05f;
        currentScaleVector.y = currentScaleVector.y + 0.05f;
        currentScaleVector.z = currentScaleVector.z + 0.05f;
        duck.transform.localScale = currentScaleVector;

        Vector3 duck_pos = duck.transform.localPosition;

        
        


        words_typed++;
        Debug.Log(words_typed);

        if (currentScaleVector.x >= 2)
        {
            Debug.Log("This will be game end. Well done!");
        }

        else if (currentScaleVector.x <= 0.05)
        {
            sg = FindObjectOfType<StartGame>();
            sg.GameOverScreen();
        }

        else if (words_typed == 10)
        {
            duck_pos.y = -3.88f;
        }

        else if (words_typed > 10)
        {

            duck_pos.y += 0.1f;
            duck.transform.localPosition = duck_pos;
            spriteRenderer.sprite = duck_sprite3;
            currentScaleVector.x = 0.5f;
            currentScaleVector.y = 0.5f;
            currentScaleVector.z = 0.5f;
        }

        else if (words_typed == 5)
        {
            duck_pos.y = -3.88f;
        }


        else if (words_typed > 5)
        {

            duck_pos.y += 0.1f;
            duck.transform.localPosition = duck_pos;
            spriteRenderer.sprite = duck_sprite2;
            currentScaleVector.x = 0.5f;
            currentScaleVector.y = 0.5f;
            currentScaleVector.z = 0.5f;


        }

        else
        {
            duck_pos.y += 0.1f;
            duck.transform.localPosition = duck_pos;
        }

        

        

    }

    public void decreaseSize()
    {
        float y_pos = duck.transform.position.y;
        y_pos++;
        Vector3 currentScaleVector = duck.transform.localScale;
        currentScaleVector.x = currentScaleVector.x - 0.05f;
        currentScaleVector.y = currentScaleVector.y - 0.05f;
        currentScaleVector.z = currentScaleVector.z - 0.05f;
        duck.transform.localScale = currentScaleVector;

        Vector3 duck_pos = duck.transform.localPosition;



        words_typed--;
        Debug.Log(words_typed);

        if (currentScaleVector.x >= 2)
        {
            Debug.Log("This will be game end. Well done!");
        }

        else if (currentScaleVector.x <= 0.05)
        {
            Debug.Log("GAME OVER");
            sg = FindObjectOfType<StartGame>();
            sg.GameOverScreen();
        }

        else if (words_typed == 10)
        {
            duck_pos.y = -3.88f;
        }

        else if (words_typed > 10)
        {

            duck_pos.y -= 0.1f;
            duck.transform.localPosition = duck_pos;
            spriteRenderer.sprite = duck_sprite3;
            currentScaleVector.x = 0.5f;
            currentScaleVector.y = 0.5f;
            currentScaleVector.z = 0.5f;
        }

        else if (words_typed == 5)
        {
            duck_pos.y = -3.88f;
        }


        else if (words_typed > 5)
        {

            duck_pos.y -= 0.1f;
            duck.transform.localPosition = duck_pos;
            spriteRenderer.sprite = duck_sprite2;
            currentScaleVector.x = 0.5f;
            currentScaleVector.y = 0.5f;
            currentScaleVector.z = 0.5f;


        }

        else
        {
            duck_pos.y -= 0.1f;
            duck.transform.localPosition = duck_pos;
        }
    }

    
}