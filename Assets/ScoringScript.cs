﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoringScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoringtextP1;
    public TextMeshProUGUI scoringtextP2;
    public static int scoreP1 = 0, scoreP2 = 0; //public static bisa diakses dimanapun

    void Start()
    {
        scoringtextP1.text = scoreP1.ToString();
        scoringtextP2.text = scoreP2.ToString();
    }

    public void UpdateScoring(string namaWall)
    {
        if(namaWall == "Skiri")
        {
            scoreP2 += 1;
            scoringtextP2.text = scoreP2.ToString();

        }else if(namaWall == "Skanan")
        {
            scoreP1 += 1;
            scoringtextP1.text = scoreP1.ToString();
        }
    }
}