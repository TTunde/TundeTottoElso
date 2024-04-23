using System.Collections.Generic;
using UnityEngine;

public class ListPractice : MonoBehaviour
{
    private void Start()
    {
        //ha nem tudom hány elemû lesz a "Tömböm", akkor listát használok
        List<string> mylist = new List<string>();

        mylist.Add("AA");
        mylist.Add("BB");
        mylist.Add("CC"); //{"AA", "BB", "CC"}

        mylist.Insert(0, "XX"); //{"XX", "AA", "BB", "CC"}
        mylist.Insert(2, "YY"); //{"XX", "AA", "YY", "BB", "CC"}

        mylist.Remove("XX");  //{"AA", "YY", "BB", "CC"}
        mylist.Remove("ZZ");  //{"AA", "YY", "BB", "CC"} //false tér vissza

        mylist.RemoveAt(2);  //{"AA", "YY", "CC"}

        mylist.IndexOf("YY"); // 1 
        mylist.Contains("ZZ"); // false , jelenleg nem tartalmazza

        mylist.Sort();//ABC sorrendbe rakja
        mylist.Reverse(); //CBA sorrend vagyis csökkenõ

        //**************************************************************


    }
    float Mean(List<float> numbers)
    {
        float summa = 0;
        foreach (float item in numbers)
        {
            summa += item;
        }
        return summa / numbers.Count;
    }


}
