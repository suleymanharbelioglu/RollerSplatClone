using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] _grounds;
    public float _groundNumbers;
    public int _currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        _grounds = GameObject.FindGameObjectsWithTag("Ground");
        _currentLevel = SceneManager.GetActiveScene().buildIndex;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        _groundNumbers = _grounds.Length;
        
    }

    public void LevelUpdate()
    {
        SceneManager.LoadScene(_currentLevel+1);

    }
}
