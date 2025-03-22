using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
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
        this.transform.position += new Vector3(Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.W)) // Wキーを押したら生成
        {
            
        }

        if (Input.GetKeyDown(KeyCode.A)) // Aキーを押したら生成
        {

        }

        if (Input.GetKeyDown(KeyCode.D)) // Dキーを押したら生成
        {

        }

        if (Input.GetKeyDown(KeyCode.Space)) // スペースキーを押したら生成
        {

        }
    }
}
