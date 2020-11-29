using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemy;
    private float xSpawn = 16.0f;
    private float zESpawn = 12.0f;
    private float ySpawn = 0.75f;
    private float eSpawnTime = 1.0f;
    private float eDelay = 1.0f;
    private int score = 0;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool gameOver;
    public Button restart;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", eSpawnTime, eDelay);
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        SetScoreText();
        if(gameOver == true)
        {
            gameOverText.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
        }
       
    }
    void SpawnEnemy()
    {
        if (gameOver == false) {
            float randomSpawnX = Random.Range(-xSpawn, xSpawn);
            int randomIndex = Random.Range(0, enemy.Length);
            Vector3 spawnPos = new Vector3(randomSpawnX, ySpawn, zESpawn);
            Instantiate(enemy[randomIndex], spawnPos, enemy[randomIndex].gameObject.transform.rotation);
        }
    }
    public void AddScore(int score)
    {
        this.score += score;
    }
    public int GetScore()
    {
        return this.score;
    }
    private void SetScoreText()
    {
        scoreText.text = "Score: " + this.score;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
