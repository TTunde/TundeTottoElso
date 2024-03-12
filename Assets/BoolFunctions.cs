using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolFunctions : MonoBehaviour
{
    void Start()
    {
        bool b1 = true;
        bool b2 = false;

        float a = 12, b = 33.5f;

        bool aIsHigherThanB = a > b;
        bool aIsLowerThanB = a < b;
        bool isEqual = a == b; //egyenlõ-e hamis
        bool isNotEqual = a != b; //nem egyenlõ-e igaz

        a = 12;
        b = 12;

        aIsHigherThanB = a > b;  //F
        aIsLowerThanB = a < b; //F
        bool aIsHigherBorEqual = a >= b; //T
        bool aIsLowerBOrEqual = a <= b;//T

        bool equals = "Hello" == "Haho"; //F
        Debug.Log(equals);

        //---- tudunk lõni?
        int ammo = 10;
        bool haveGun = true;

        bool haveAmmo = ammo > 0;
        bool canWeShoot = haveGun && haveAmmo;

        //------ tudunk ugrani?
        bool isOnGround = false;
        bool canAirJump = true;

        bool canJump = isOnGround || canAirJump;

        //*****házinak írni 1-1 pédát

        bool isInTheAir = !isOnGround;// Negálás
    }

}
