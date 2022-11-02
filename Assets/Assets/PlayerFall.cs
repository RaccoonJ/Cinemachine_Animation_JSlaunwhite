using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.y < -2)
        {
            {
                /*transform.position.x = -136.5323;
                transform.position.y = 0.9000003;
                transform.position.z = 33.71458;*/
                transform.position = new Vector3(-0f, 0f, 0f);
                /*transform.rotation.x = 1;
                transform.rotation.y = 1;
                transform.rotation.z = 1;*/
            }
        }
    }
    }
