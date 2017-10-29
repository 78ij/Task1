using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniqueStudioTasks.Task1;
public class GameController : MonoBehaviour
{
    public Text HpText;
    public Text GameOverText;
    public Text ScoreText;
    public Text WinText;
    public int gamestatus = 1;
    public int health = 10;
    public int score = 0;
    private Vector3[] position = {
        new Vector3(11.0f,2.50f,-1.0f),
        new Vector3(11.0f,0.0f,-1.0f),
        new Vector3(11.0f,-2.50f,-1.0f),
    };
    private string[] types = {
        "normalplane",
        "strongplane",
        "quickplane"
        };
    public float WaveInterval;
	// Use this for initialization
	void Start () {
        HpText.text = "HP = 10";
        StartCoroutine(Evade());
	}
	IEnumerator Evade()
    {
        while (gamestatus > 0)
        {
            if (PlanePool.GetInstance().pool.Count <= 50)
            {
                int position1 = Random.Range(0, 3);
                int position2;
                while ((position2 = Random.Range(0, 3)) == position1) { }
                PlanePool.GetInstance().Instantiate(types[position2],
                    position[position1]);
                PlanePool.GetInstance().Instantiate(types[position1],
                    position[position2]);
                yield return new WaitForSeconds(WaveInterval);
            }
        }
    }
  	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Home))
        {
            Application.Quit();

        }
        GameOver();
        UpdateScore();
    }
    public void Hurt()
    {
        health--;
        HpText.text = "HP = " + health;
    }
    public void GameOver()
    {
        if(health <= 0)
        {
            gamestatus = 0;
            GameOverText.text = "Game Over!";
        }
    }
    public void UpdateScore()
    {
        ScoreText.text = "Score = " + score;
        if(score >= 30)
        {
            gamestatus = -1;
            WinText.text = "You Win!";
        }
    }
}
