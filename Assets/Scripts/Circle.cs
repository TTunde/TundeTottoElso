
using System.Text.RegularExpressions;
using Unity.Mathematics;
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] float radius;
    void Start()
    {
        Debug.Log("Ker�let= " + 2 * radius * math.PI);        
        Debug.Log("Ter�let= " + math.pow(radius, 2) * math.PI);  
        
        //mathf a unity be�p�tett haszn�lhat� f�ggv�nye
    }

}

