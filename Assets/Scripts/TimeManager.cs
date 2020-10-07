using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public float limit = 30.0f;
    public GameObject timeText;
    public GameObject text;
    public GameObject player;

    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        restart = new RestartManager(player, text);
        timeText.GetComponent<Text>().text = "残り時間" + limit + "秒";
    }

    // Update is called once per frame
    void Update()
    {
        if (restart.IsGameOver() && Input.GetMouseButton(0))
        {
            restart.Restart();
        }

        if (limit < 0)
        {
            restart.PrintGameOver();
        }
        else
        {
            limit -= Time.deltaTime;
            timeText.GetComponent<Text>().text = "残り時間:" + limit.ToString("f1") + "秒";
        }
    }
}
