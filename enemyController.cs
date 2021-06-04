using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemyController : MonoBehaviour
{
    NavMeshAgent enemy_move;
    Transform player_tr;
    Transform enemy_tr;
    public GameObject player;
    public Text score_text;
    int hp = 1;
    static int score = 0;
    
    void Start()
    {
        enemy_move = GetComponent<NavMeshAgent>();
        player_tr = player.GetComponent<Transform>();
        enemy_tr = player.GetComponent<Transform>();
    }

    void Update()
    {
        enemy_move.SetDestination(player_tr.position);
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "bullet")
        {
            hp = hp - 1;
            if(hp == 0)
            {
                Destroy(gameObject);
                score = score + 1;
                score_text.text = "Score: "+score;
            }
        }
    }
}
