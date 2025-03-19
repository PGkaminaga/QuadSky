using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform createPosition;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, createPosition.position, createPosition.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
