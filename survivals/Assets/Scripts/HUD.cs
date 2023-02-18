using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI healthText;
    [SerializeField]
    TextMeshProUGUI levelText;
    [SerializeField]
    GameObject dash;
    [SerializeField]
    GameObject bigbom;
    [SerializeField]
    GameObject small;
    [SerializeField]
    GameObject shield;
    [SerializeField]
    GameObject pause;
    [SerializeField]
    TextMeshProUGUI scoreText;
    [SerializeField]
    GameObject player;
    int score;
    const string ScorePrefix = "Score: ";
    // Start is called before the first frame update
    void Start()
    {
        //Skill position
        dash.transform.position = new Vector3(Screen.width - 300f, 60f, 0);
        bigbom.transform.position = new Vector3(Screen.width - 120f, 120f, 0);
        small.transform.position = new Vector3(Screen.width - 265f, 205f, 0);
        shield.transform.position = new Vector3(Screen.width - 150f, 300f, 0);

        pause.transform.position = new Vector3(Screen.width - 100, Screen.height - 100, 0);
        healthText.transform.position = new Vector3(150f, Screen.height * 0.9f, 0);
        scoreText.transform.position = new Vector3(150f, Screen.height * 0.83f, 0);
        levelText.transform.position = new Vector3(130f, Screen.height * 0.78f, 0);
        int score = 0;
        scoreText.text = ScorePrefix + score.ToString();
        PlayerHealth p = player.GetComponent<PlayerHealth>();
        healthText.text = p.GetMaxHealth() + "/" + p.GetMaxHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint(int points)
    {
        score += points;
        scoreText.text = ScorePrefix + score.ToString();
    }
}
