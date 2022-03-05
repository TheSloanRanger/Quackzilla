using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFood : MonoBehaviour
{
    bool movingTowards;
    public float speed = 10.0f;
    public GameObject duck;
    Vector2 foodStartPos, duckPos;
    Words w;
    // Start is called before the first frame update
    void Start()
    {
        movingTowards = false;
        foodStartPos = transform.position;
        duckPos = duck.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (movingTowards)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, duckPos, step);

            if (Vector2.Distance(transform.position, duckPos) < 0.001f)
            {
                movingTowards = false;
                transform.position = foodStartPos;
                w.moveFoodFinished();
            }
        }
    }

    public void StartMovingFood(Words w)
    {
        movingTowards = true;
        this.w = w;
    }

}