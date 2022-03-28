using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class health : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _health;
    [SerializeField] private GameObject _gameOver;

    public static int _lives;
    // Start is called before the first frame update
    void Start()
    {
        _lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        _health.text = $"Lives: {_lives.ToString()}";
        if (_lives < 1)
        {
            _gameOver.gameObject.SetActive(true);
        }
    }
}
