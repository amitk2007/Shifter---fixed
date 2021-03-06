﻿using UnityEngine;
using System.Collections;

public class TouchScript : MonoBehaviour
{
    #region variables
    public GameObject player;
    bool touching = false;
    #endregion

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount != 0 && touching == false)
        {
            ChangePlayerSprite();
            touching = true;
        }
        if (Input.touchCount == 0)
        {
            touching = false;
        }
    }

    void ChangePlayerSprite()
    {
        playerScript.SpriteNumber = playerScript.AddOneLoop(playerScript.SpriteNumber);
        player.gameObject.GetComponent<SpriteRenderer>().sprite = playerScript.SpritsArray[playerScript.SpriteNumber];
        playerScript.ChangeAnimation();
    }
}
