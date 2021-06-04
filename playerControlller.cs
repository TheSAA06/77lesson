using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerControlller : MonoBehaviour
{
    Transform player_tr;
    Rigidbody rb;
    float v;
    float h;
    static int time = 20;
    static int hp = 100;
    public Text timerText;
    public Text hpText;
    void Timer()
    {
        time = time - 1;
        timerText.text = "Time: "+time;
        if(time==0)
        {
            SceneManager.LoadScene("timescene");
        }
    }
    void Start()
    {
        InvokeRepeating("Timer",1f,1f);
        player_tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");
        rb.velocity = transform.forward * v * 5f;
    }
    public void GetRotate(float arg){
        player_tr.rotation = Quaternion.Euler(0,arg,0);
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "enemy")
        {
            hp = hp - 20;
            hpText.text = "Hp: "+hp;
            if(hp == 0)
            {
                SceneManager.LoadScene("diescene");
            }
        }
    }
}
