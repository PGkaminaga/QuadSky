using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;

    private Vector3 dir;
    private bool can_moove;
    private bool is_mooved;
    public float speed = 10f;
    public float wait_time = 60f;
    private float wait_count;

    [SerializeField] private Transform lowerPosition;
    [SerializeField] private Transform highPosition;
    [SerializeField] private Transform leftPosition;
    [SerializeField] private Transform ritghtPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        dir = Vector3.zero;
        is_mooved = true;
        lowerPosition = GameObject.Find("機体位置(下)").transform;
        highPosition = GameObject.Find("機体位置(上)").transform;
        leftPosition = GameObject.Find("機体位置(左)").transform;
        ritghtPosition = GameObject.Find("機体位置(右)").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (is_mooved)
        {
            wait_count += 1f;
        }

        this.transform.position += dir * Time.deltaTime * speed;
      
        if (this.transform.position.y>= highPosition.transform.position.y
            | this.transform.position.y <= lowerPosition.transform.position.y)
        {
            dir = Vector3.zero;
            is_mooved = true;
        }

        if (this.transform.position.x <= leftPosition.transform.position.x
           | this.transform.position.x >= ritghtPosition.transform.position.x)
        {
            dir = Vector3.zero;
            is_mooved = true;
        }

        if (wait_count <= wait_time)
        {
            return;
        }

        if (dir != Vector3.zero)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.W)) // Wキーを押したら生成
        {
            
            //上方向を計算し、正規化（プレイヤーを上にに向かって移動させる）
            dir = (highPosition.transform.position - this.transform.position).normalized;
            wait_count = 0;
            can_moove = false;
            is_mooved = false;
        }

        if (Input.GetKeyDown(KeyCode.A)) // Aキーを押したら生成
        {
            dir = (leftPosition.transform.position - this.transform.position).normalized;
            wait_count = 0;
            can_moove = false;
            is_mooved = false;
        }

        if (Input.GetKeyDown(KeyCode.D)) // Dキーを押したら生成
        {
            dir = (ritghtPosition.transform.position - this.transform.position).normalized;
            wait_count = 0;
            can_moove = false;
            is_mooved = false;
        }
            if (Input.GetKeyDown(KeyCode.Space)| Input.GetKeyDown(KeyCode.S)) // スペースキーを押したら生成
        {
            dir = (lowerPosition.transform.position - this.transform.position).normalized;
            this.transform.position = Vector3.Lerp(this.transform.position, lowerPosition.transform.position, speed * Time.deltaTime);
            wait_count = 0;
            can_moove = false;
            is_mooved = false;
        }
    }
}
