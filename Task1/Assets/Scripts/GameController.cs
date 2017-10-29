using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniqueStudioTasks.Task1;
public class GameController : MonoBehaviour
{
    public Text HpText;
    public Text GameOverText;
    public bool gamenotover = true;
    public int health = 10;
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
        while (gamenotover)
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
            gamenotover = false;
            GameOverText.text = "Game Over!";
        }
    }
}
