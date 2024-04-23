using System;
using UnityEngine;

public class ArrayHW : MonoBehaviour
{
    [Header("Átlag")]
    [SerializeField] float[] numbers = { 1.5f, 5.6f, 37.8f, 5.5f, 9.0f };
    [SerializeField] float atlag;

    [Header("Min / Max")]
    [SerializeField] float minimum;
    [SerializeField] float maximum;

    [Header("Fordított tömb")]
    [SerializeField] int[] normalTomb = { 3, 8, 3, 9, 5 };
    [SerializeField] int[] forditottTombErtekei;

    [Header("Létezik-e T tulajdonságú elem a tömbben")]
    [SerializeField] string[] szovegTomb = { "Egy", "Kettő", "Három", "Négy" };
    [SerializeField] int[] egeszSzamTomb = { 1, 2, 3, 4 };

    [Header("Fibonacci sorozat hossz paraméterrel")]
    [SerializeField] int[] fibonacciTomb;

    [SerializeField] string[] tomb1 = { "AAA", "BBB", "CCC" };
    [SerializeField] string[] tomb2 = { "DDD", "EEE" };
    [SerializeField] string[] tombTeszt = { "D", "E", "E", "E", "E" };
    [SerializeField] string[] tomb3;

    private void OnValidate()
    {
        atlag = Atlagszamitas(numbers);

        minimum = MinFuggveny(numbers);
        maximum = MaxFuggveny(numbers);

        forditottTombErtekei = MegforditEgyTombot(normalTomb);

        Debug.Log(LetezikATombben(egeszSzamTomb, 3));
        Debug.Log(LetezikATombben2(egeszSzamTomb, 2));
        Debug.Log(LetezikATombbenASzoveg(szovegTomb, "Egy"));
        Debug.Log("Teszt: " + LetezikATombbenASzoveg2(szovegTomb, "Harminc"));

        fibonacciTomb = FibonacciSor(10);
        string[] tomb = new string[tomb1.Length + tomb2.Length];
        tomb3 = StringekOsszefuzese(tomb1, tombTeszt);
    }

    //Írj metódust, ami kiszámolja egy paraméterben kapott 
    //float tömb elemeinek átlagát és visszatér az eredménnyel!

    float Atlagszamitas(float[] tomb)
    {
        float szamlalo = 0;
        for (int i = 0; i < tomb.Length; i++)
        {
            szamlalo += tomb[i];
        }
        return szamlalo / tomb.Length;
    }

    /*
     - **Minimum- és maximumkereső függvény tömbön**
    Írj függvényt, ami visszaadja egy paraméterben kapott `float` tömb legkisebb értékét!
    Írj függvényt, ami visszaadja egy paraméterben kapott `float` tömb legnagyobb értékét!
     */
    float MinFuggveny(float[] tomb)
    {
        float min = tomb[1];
        for (int i = 0; i < tomb.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }

    float MaxFuggveny(float[] tomb)
    {
        float max = tomb[1];
        for (int i = 0; i < tomb.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }



    /*
     * Tartalom megfordítása
    Írjunk eljárást, ami egy paraméterben kapott `int` tömböt átalakít úgy, hogy a tartalma fordított sorrendben szerepeljen benne!
    Pl.: { 1, 2, 3, 4, 5 } → { 5, 4, 3, 2, 1 }
    A feladatot oldd meg, hogy az eljáráson belül nem hozol létre új tömböt!
    */
    //{ 1, 8, 3, 9, 5 };
    /*
     * 
     void ChangeOrder(int[] array)
    {
	    if (array == null)
		    return; 
	        
	    // A sorozat hosszának feléig iterálok:
	    for (int i = 0; i < array.Length / 2; i++)
	    {
		    // Hátulról i-edik index
		    int i2 = array.Length - 1 - i;
		
		    // Kicserélem i-edik és i2-edik indexen lévő elemet
		    int temp = array[i];    // Szükség van egy segédváltozóra
		    array[i] = array[i2];
		    array[i2] = temp;
	    } 
    }
     * */

    int[] MegforditEgyTombot(int[] tomb)
    {
        for (int i = 0; i < tomb.Length; i++)
        {
            int szam = tomb[tomb.Length - 1 - i];//mert a 4. idexű elemet akarom ezért -1
            normalTomb[i] = szam;
        }
        return normalTomb;
    }

    /*
     * - **Tömbegyesítő**
    Írj függvényt, ami két paraméterként kapott `string` tömböt összefűz egy új hosszabb tömbbé, 
    amiben mindkét tömb elemei szerepelnek, majd visszaadja ezt a nagyobb tömböt.
    Pl: `{”AAA”, “BBB”, ”CCC”}` + `{”DDD”, ”EEE”}` → `{ "AAA”, “BBB”, “CCC”, “DDD”, “EEE” }`
    */

    string[] StringekOsszefuzese(string[] tomb1, string[] tomb2)
    {
        string[] tomb = new string[tomb1.Length + tomb2.Length];
        for (int i = 0; i < tomb1.Length; i++)
        {
            tomb[i] = tomb1[i];
        }
        int k = 0;
        for (int i = tomb1.Length; i < tomb.Length; i++)
        {
            tomb[i] = tomb2[k];
            k++;
        }
        return tomb;

    }






    /*
    - **Contains függvény**
    Írj függvényt, ami visszaadja egy elemről, hogy szerepel-e egy tömbben.
    A függvény két paramétere a tömb és a tesztelt elem.
    
        IndexOf(): Megkeresi egy tömbben egy adott elem indexét.
        Visszatérési értéke az elem indexe, ha megtalálta, különben -1.
        Használható arra is, hogy megállapítsuk, egy lista tartalmaz-e egy adott elemet.
     */

    int LetezikATombben(int[] tomb, int value)
    {
        int index = Array.IndexOf(tomb, value);   // Megkeresi egy elem indexét és visszatér vele. Ha -1 akkor nincs ilyen.
        return index;
    }

    string LetezikATombben2(int[] tomb, int value)
    {
        int index = Array.IndexOf(tomb, value);
        string eredmeny = index == -1 ? "Nincs" : "Van";
        return eredmeny;
    }

    bool LetezikATombbenASzoveg(string[] tomb, string value)
    {
        bool tartalmazzaE = Array.IndexOf(tomb, value) != -1;
        return tartalmazzaE;
    }

    bool LetezikATombbenASzoveg2(string[] tomb, string value)
    {
        for (int i = 0; i < tomb.Length; i++)
        {
            if (tomb[i] == value)
                return true;
        }
        return false;
    }


    /*
     Írj függvényt, ami visszaad egy `int` tömböt, aminek tartalma a Fibonacci sor első n száma!
    - Fibonacci sor definíciója
    A fibonacci sorozat olyan számsor, aminek első két eleme 0 és 1 és utána minden szám az előző kettő összege.
    0, 1, 1, 2, 3, 5, 8, 13, 21, 34 …
    ”n” szám a függvény `int` típusú és egyetlen paramétere.
     */

    int[] FibonacciSor(int szam)
    {
        int[] sorozat = new int[szam];
        sorozat[0] = 0;
        sorozat[1] = 1;
        for (int i = 2; i < sorozat.Length; i++)
        {
            sorozat[i] = sorozat[i - 1] + sorozat[i - 2];
        }
        return sorozat;
    }
}
