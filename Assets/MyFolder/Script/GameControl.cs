﻿using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

    public GameObject GameStartBtn;
    public GameObject starFighterPrefab;
    public GameObject GameOverSet;
    public bool gameFlag;
//{ get; set; }

	// Use this for initialization
	void Start () {
        gameFlag = true;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (gameFlag == false) {
            GameOverSet.SetActive(true);   
        }
	}

    public void GameStartButton() {
        Instantiate(starFighterPrefab);
        GameStartBtn.SetActive(false);
      
    }

    public void GameOverButton() {
        Application.LoadLevel("GameScene01");
    }
}
