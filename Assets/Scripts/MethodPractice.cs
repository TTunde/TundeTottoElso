using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(AbsVal(13));
        float AbsVal(float number)
        {
            if (number > 0)
            {
                return number;
            }
            else
            {
                return -number;
            }
        }
    }   
}

