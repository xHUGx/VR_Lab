using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class TriggerCheck : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _gameOver;
    // Start is called before the first frame update
    private bool _touched = false;
   
    
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Bad"))
        {
            if (_touched == false)
            {
                _touched = true;
                other.gameObject.AddComponent<Rigidbody>();
            
                gameObject.AddComponent<Rigidbody>();
            
                Debug.Log("triggerred");

                StartCoroutine(Sleep(other.gameObject));
            }
        }
    }

    IEnumerator Sleep(GameObject other)
    {
       
        yield return new WaitForSeconds(2);
        Revive(other.gameObject);
    }

    private void Revive(GameObject other)
    {
        health._lives -= 1;
        _player.transform.position = new Vector3(-0.8780075f,11.23998f,15.03963f);
        Destroy(other.GetComponent<Rigidbody>());
        _touched = false;
    }
}
