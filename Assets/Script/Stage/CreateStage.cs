using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateStage : MonoBehaviour
{
    public GameObject player;
    public GameObject[] grounds = new GameObject[1];

    private List<GameObject> spawnedGrounds = new List<GameObject>();

    float border = 10;
    float playerStartPosZ;
    float playerNowPosZ;
    private float deleteDistance = 30f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

        playerStartPosZ = player.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        GenerateGround();
        RemoveOldGround();
    }

    void GenerateGround()
    {
        playerNowPosZ = player.transform.position.z;
        float playerDistance = playerNowPosZ - playerStartPosZ;

        if(playerDistance > border)
        {
            GameObject newGround = Instantiate(grounds[Random.Range(0, grounds.Length)], new Vector3(0, 0, player.transform.position.z + 20), Quaternion.identity);

            spawnedGrounds.Add(newGround);

            playerDistance = 0;
            border = 30f;
            playerStartPosZ = playerNowPosZ;
        }
    }

    void RemoveOldGround()
    {
        if(spawnedGrounds.Count > 0)
        {
            GameObject firstGround = spawnedGrounds[0];

            if(firstGround.transform.position.z < player.transform.position.z - deleteDistance)
            {
                Debug.Log("ŒÃ‚¢°‚ðíœ");
                spawnedGrounds.RemoveAt(0);
                Destroy(firstGround);
            }
        }
    }
}
