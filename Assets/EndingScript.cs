﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndingScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI endingtext;

    void Start()
    {
        if(ScoringScript.scoreP1 > ScoringScript.scoreP2){
            endingtext.text = "Player 1 win";
        }else if(ScoringScript.scoreP1 < ScoringScript.scoreP2){
            endingtext.text = "Player 2 win";
        }else{
            endingtext.text = "Draw";
        }
    }

}
