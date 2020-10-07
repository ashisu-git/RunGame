using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalManager : MonoBehaviour
{
    public GameObject player;
    public GameObject text;

    private bool isGoal = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGoal && Input.GetMouseButton(0))
        {
            Restart();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            text.GetComponent<Text>().text = "Goal!!!";
            text.SetActive(true);
            isGoal = true;
        }
    }

    private void Restart()
    {
        Scene loadScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadScene.name);
    }
}
