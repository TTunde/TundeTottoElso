using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    [SerializeField] int[] num; 
    [SerializeField] int count = 10; 
    [SerializeField] int countString = 4; 
    [SerializeField] string[] texts; //"1" "22" "333" "4444" 
    [SerializeField] int[] numbers; // 
    [SerializeField] int max; // 


    void OnValidate()
    {
        num = new int[10];
        for (int i = 0; i < 10; i++)
        {
            num[i] = 10 - i;
        }


        texts = new string[countString];
        for (int i = 0; i < countString; i++)
        {
            string st = "";
            for (int  j = 0;  j< i+1; j++)
            {
                st += (i+1).ToString(); // a tostring elhagyható
            }
            texts[i] = st;
        }

        max = 2;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

    }

}
