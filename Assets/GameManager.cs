using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject _gameOver;
    [SerializeField] private TextMeshProUGUI _countText;
    
    
    void Start()
    {
        
    }

    void Update()
    {  
        
    }
    void DoStuff () {
        _gameOver.SetActive(true);
        
    }
 
    IEnumerator Countdown (int seconds) {
        int counter = seconds;
        while (counter > 0) {
            yield return new WaitForSeconds (1);
            counter--;
            _countText.text = counter.ToString();
        }
        DoStuff ();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Countdown(40));
        }
       
    }
    
    
   
}
