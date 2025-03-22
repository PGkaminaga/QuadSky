using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateStage : MonoBehaviour
{
    [SerializeField] private GameObject stage;
    [SerializeField] private Transform spawnPosition;

    [SerializeField] private float spawnInterval = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            if(spawnPosition != null)
            {
                Instantiate(stage, spawnPosition.position, Quaternion.identity);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
