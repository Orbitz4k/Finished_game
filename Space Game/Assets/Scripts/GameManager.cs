using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemy;
    [SerializeField] float xSpawn = 25.0f;
    [SerializeField] float zESpawn = 12.0f;
    [SerializeField] float ySpawn = 0.75f;
    [SerializeField] float eSpawnTime = 3.0f;
    [SerializeField] float eDelay = 1.0f;
    [SerializeField] int score = 0;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool gameOver;
    public GameObject titleScreen;
    public Button restart;
    public AudioClip Boom;
    public ParticleSystem explosion;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //
        SetScoreText();
        if(gameOver == true)
        {
            gameOverText.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
            Destroy(GameObject.FindWithTag("Player"));
        }
    }
    //Spawns enemies
    void SpawnEnemy()
    {
        if (gameOver == false) {
            float randomSpawnX = Random.Range(-xSpawn, xSpawn);
            int randomIndex = Random.Range(0, enemy.Length);
            Vector3 spawnPos = new Vector3(randomSpawnX, ySpawn, zESpawn);
            Instantiate(enemy[randomIndex], spawnPos, enemy[randomIndex].gameObject.transform.rotation);
        }
    }
    //Makes Score go up 
    public void AddScore(int score)
    {
        this.score += score;
    }
    //Gets score and returns it
    public int GetScore()
    {
        return this.score;
    }
    //Displays score
    private void SetScoreText()
    {
        scoreText.text = "Score: " + this.score;
    }
    //Makes restart work
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //Starts game and changes difficulty by dividing the spawn time by either 1, 2 or 3
    public void StartGame(int difficulty)
    {
        eSpawnTime /= difficulty;
        InvokeRepeating("SpawnEnemy", eSpawnTime, eDelay);
        gameOver = false;
        titleScreen.gameObject.SetActive(false);
    }
}
