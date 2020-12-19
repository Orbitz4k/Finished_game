using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] GameManager gameManager;
    public int difficulty;
    [SerializeField] AudioSource buttonNoise;
    public AudioClip noiseyyy;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(setDifficulty);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();  
     }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Lets the difficulty buttons function
    void setDifficulty()
    {
        Debug.Log(button.gameObject.name + " was pressed");
        gameManager.StartGame(difficulty);
    }
}
