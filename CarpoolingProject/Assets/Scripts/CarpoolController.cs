﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarpoolController : MonoBehaviour
{
    [SerializeField] private SubtitleUI SubtitleUI;
    private void Start()
    {
        SubtitleUI = GameObject.FindGameObjectWithTag("SubTitle").GetComponent<SubtitleUI>();
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            //reset distance for compass, needed otherwise doesn't change target when picking up a friend
            other.gameObject.GetComponentInChildren<Compass>().distance = 99999f;

            GameManager.score++;
            SubtitleUI.startIEnumerator();
            Destroy(gameObject);
            
        }
    }
    
}
