using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    int count = 0;
    int whiskeyCount = 0;
    int lemonJuiceCount = 0;
    int sugarSyrupCount = 0;

    public TextMeshProUGUI cocktailDisplayText;

    void Start()
    {
        count = 0;
        whiskeyCount = 0;
        lemonJuiceCount = 0;
        sugarSyrupCount = 0;
        cocktailDisplayText.enabled = false;

        counterText.text = "Number of ingredients: " + count + "\n" + "Whiskey: " + whiskeyCount + "\n" + "Lemon juice: " + lemonJuiceCount + "\n" + "Sugar syrup: " + sugarSyrupCount;
    }

    void Update()
    {
        if (whiskeyCount == 1 && lemonJuiceCount == 1 && sugarSyrupCount == 1)
            cocktailDisplayText.enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        count += 1;

        if (other.CompareTag("Whiskey"))
            whiskeyCount += 1;

        if (other.CompareTag("Lemon Juice"))
            lemonJuiceCount += 1;

        if (other.CompareTag("Sugar Syrup"))
            sugarSyrupCount += 1;

        counterText.text = "Number of ingredients: " + count + "\n" + "Whiskey: " + whiskeyCount + "\n" + "Lemon juice: " + lemonJuiceCount + "\n" + "Sugar syrup: " + sugarSyrupCount;
    }
}
