using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private GameObject missile;

    public int wait_time = 60;
    private int wait_count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wait_count++;

        if(wait_count< wait_time)
        {

            return;
        }

        if (Input.GetMouseButtonDown(0)) // WƒL[‚ð‰Ÿ‚µ‚½‚ç¶¬
        {
            Instantiate(missile, this.transform.position, this.transform.rotation);
            wait_count = 0;
        }
    }
}
