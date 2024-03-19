using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework3VampirArus : MonoBehaviour
{
    /*
     - 🦇 **Vámpír árus** 🦇
        Egy különös csuklyás árussal találkozunk az út szélén. 
        Az árus elmondja, hogy ő nem hétköznapi kereskedő. 
        Nem csak aranyat fogad el fizetségül hanem vért is. 
        Minden aranypénz helyett elfogad 5 HP-t is. (HP = Health Point = életpont). 
        Egy árucikkért csak aranyban vagy csak vérben fizethetünk. Keverni nem tudunk.
     
    3 portékát árul a következő árakon
     - Bunkók buzogánya: 10 arany
     - Trükkös tőr: 4 arany
     - Vámpírfog:  13 arany

     Azt megengedjük, hogy elfogyjon minden pénzünk, de azt nem, hogy elfogyjunk minden HP-nk és meghaljunk egy árucikkért.
     Írj programot, ami a következő változókat bekéri az aranyunk és a és HP-nk mennyiségét, majd ezek alapján kiírja minden egyes árucikkről, hogy meg tudjuk-e venni!
     */

    [SerializeField] int gold;
    [SerializeField] int hp;

    private int bunkokBuzoganyaAr = 10;
    private int trukkosTorAr = 4;
    private int vampirfogAr = 13;

    int buzoganyDb;
    int trukkosTorDb;
    int vampirfogDb;

    int goldFromHp = 0;
    void Start()
    {
        if (hp % 5 != 0)
        {
            goldFromHp = hp / 5;

        } else
        {
            goldFromHp = (hp - 1) / 5;
        }
        if (gold > 0)
        {
            buzoganyDb = (gold / bunkokBuzoganyaAr);
            trukkosTorDb = (gold / trukkosTorAr);
            vampirfogDb = (gold / vampirfogAr);
        }
        
        
        buzoganyDb += goldFromHp / bunkokBuzoganyaAr;
        trukkosTorDb += goldFromHp / trukkosTorAr;
        vampirfogDb += goldFromHp / vampirfogAr;
        
        Debug.Log("Ennyi bunkók buzogányát vehetsz: " + gold + " aranyból és " + goldFromHp + " életerőból átszámólt aranyból: " + buzoganyDb);
        Debug.Log("Ennyi trükkös tőrt vehetsz: " + gold + " aranyból és " + goldFromHp + " életerőból átszámólt aranyból: " + trukkosTorDb);
        Debug.Log("Ennyi vámpírfogat vehetsz: " + gold + " aranyból és " + goldFromHp + " életerőból átszámólt aranyból: " + vampirfogDb);

    }

}
