using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;

    [SerializeField] private Transform lowerPosition;
    [SerializeField] private Transform highPosition;
    [SerializeField] private Transform leftPosition;
    [SerializeField] private Transform ritghtPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0, 0, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W)) // W�L�[���������琶��
        {
            
        }

        if (Input.GetKeyDown(KeyCode.A)) // A�L�[���������琶��
        {

        }

        if (Input.GetKeyDown(KeyCode.D)) // D�L�[���������琶��
        {

        }

        if (Input.GetKeyDown(KeyCode.Space)) // �X�y�[�X�L�[���������琶��
        {

        }
    }
}
