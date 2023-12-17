using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int level;
    private bool startdelivering = false;
    public GameObject winner;
    public GameObject loser;
    public float timer = 10; 


    private void Start()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    private void Update()
    {
       
        if (startdelivering) {
            if (timer <= 0)
            {
                winner.SetActive(true);
            }
            else
            {
                timer-=Time.deltaTime;
            }
        }
    }

    public void youLose() { 

        loser.SetActive(true);
        startdelivering = false;
        
    }

    public void startDelivering() { 
        startdelivering = true;
    }

}
