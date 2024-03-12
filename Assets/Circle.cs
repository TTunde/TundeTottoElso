
using System.Text.RegularExpressions;
using Unity.Mathematics;
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] float radius;
    void Start()
    {
        Debug.Log("Kerület= " + 2 * radius * math.PI);        
        Debug.Log("Terület= " + math.pow(radius, 2) * math.PI);  
        
        //mathf a unity beépített használható függvénye
    }

}

