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
        lowerPosition = GameObject.Find("�@�̈ʒu(��)").transform;
        highPosition = GameObject.Find("�@�̈ʒu(��)").transform;
        leftPosition = GameObject.Find("�@�̈ʒu(��)").transform;
        ritghtPosition = GameObject.Find("�@�̈ʒu(�E)").transform;
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

        if (Input.GetKeyDown(KeyCode.W)) // W�L�[���������琶��
        {
            
            //��������v�Z���A���K���i�v���C���[����ɂɌ������Ĉړ�������j
            dir = (highPosition.transform.position - this.transform.position).normalized;
            wait_count = 0;
            can_moove = false;
            is_mooved = false;
        }

        if (Input.GetKeyDown(KeyCode.A)) // A�L�[���������琶��
        {
            dir = (leftPosition.transform.position - this.transform.position).normalized;
            wait_count = 0;
            can_moove = false;
            is_mooved = false;
        }

        if (Input.GetKeyDown(KeyCode.D)) // D�L�[���������琶��
        {
            dir = (ritghtPosition.transform.position - this.transform.position).normalized;
            wait_count = 0;
            can_moove = false;
            is_mooved = false;
        }
            if (Input.GetKeyDown(KeyCode.Space)| Input.GetKeyDown(KeyCode.S)) // �X�y�[�X�L�[���������琶��
        {
            dir = (lowerPosition.transform.position - this.transform.position).normalized;
            this.transform.position = Vector3.Lerp(this.transform.position, lowerPosition.transform.position, speed * Time.deltaTime);
            wait_count = 0;
            can_moove = false;
            is_mooved = false;
        }
    }
}
