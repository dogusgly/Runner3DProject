using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject barrier;
    public Transform spawnPoint;
    int score = 0;

    public TextMeshProUGUI Score_t;
    public GameObject Play_Button;
    public GameObject player;


    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnBarrier()
    {
        while (true) 
        {
            float waitTime = Random.Range(0.55f, 2f);

            yield return new WaitForSeconds(waitTime);

            Instantiate(barrier, spawnPoint.position,Quaternion.identity);


        }
    }
    void Now_Score()
    {
        score++;
        Score_t.text = score.ToString();
    }




    public void G_Start()
    {
        player.SetActive(true);
        Play_Button.SetActive(false);
       
        StartCoroutine("SpawnBarrier");
        InvokeRepeating("Now_Score", 2f, 1f);

    }

}
