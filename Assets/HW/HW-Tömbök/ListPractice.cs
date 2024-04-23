using System.Collections.Generic;
using UnityEngine;

public class ListPractice : MonoBehaviour
{
    private void Start()
    {
        //ha nem tudom h�ny elem� lesz a "T�mb�m", akkor list�t haszn�lok
        List<string> mylist = new List<string>();

        mylist.Add("AA");
        mylist.Add("BB");
        mylist.Add("CC"); //{"AA", "BB", "CC"}

        mylist.Insert(0, "XX"); //{"XX", "AA", "BB", "CC"}
        mylist.Insert(2, "YY"); //{"XX", "AA", "YY", "BB", "CC"}

        mylist.Remove("XX");  //{"AA", "YY", "BB", "CC"}
        mylist.Remove("ZZ");  //{"AA", "YY", "BB", "CC"} //false t�r vissza

        mylist.RemoveAt(2);  //{"AA", "YY", "CC"}

        mylist.IndexOf("YY"); // 1 
        mylist.Contains("ZZ"); // false , jelenleg nem tartalmazza

        mylist.Sort();//ABC sorrendbe rakja
        mylist.Reverse(); //CBA sorrend vagyis cs�kken�

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
