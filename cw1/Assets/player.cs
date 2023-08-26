using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    //hero
    string heroName = "Ayla";
    float heroHeight = 173;
    int heroAge = 23;
    string heroSuperPower = "fly";
    // villan
    string villanName = "louis";
    float villanHeight = 181;
    int villanAge = 30;
    string villanSuperPower = "lasereye";
    int ageDeffrince = 30 - 23;


    // Start is called before the first frame update
    void Start()
    {
        heroHeight = heroHeight + 5;
        string VillanSuperPower = "none";

        print(" hero name " + heroName);
        print(" hero height " + heroHeight);
        print(" hero age " + heroAge);
        print(" hero super power" + heroSuperPower);

        print(" villan name " + villanName);
        print(" villan height " + villanHeight);
        print(" villan super power " + villanSuperPower);
        print(" this is the agedeiffrince " + ageDeffrince);




        print(" hero name " + heroName);
        print(" hero height " + heroHeight);
        print(" hero age " + heroAge);
        print(" hero super power" + heroSuperPower);

        print(" villan name " + villanName);
        print(" villan height " + villanHeight);
        print(" villan super power " + VillanSuperPower);
        print(" this is the agedeiffrince " + ageDeffrince);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
