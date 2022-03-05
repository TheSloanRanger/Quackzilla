using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordScript : MonoBehaviour
{
    public GameObject duck;
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
        Vector3 currentScaleVector = duck.transform.localScale;
        currentScaleVector.x = currentScaleVector.x + 1;
        currentScaleVector.y = currentScaleVector.y + 1;
        currentScaleVector.z = currentScaleVector.z + 1;
        duck.transform.localScale = currentScaleVector;
    }
}
