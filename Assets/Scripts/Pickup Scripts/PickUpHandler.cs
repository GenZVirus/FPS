using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PickUpHandler : MonoBehaviour
{

    public Text pressF;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
        {
            if(hit.transform.tag == Tags.PICKUP_TAG)
            {
                float deltaX = hit.transform.position.x - transform.position.x;
                float deltaY = hit.transform.position.y - transform.position.y;
                float deltaZ = hit.transform.position.z - transform.position.z;

                float distance = (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
                if (distance < 1.5)
                {
                    pressF.gameObject.SetActive(true);
                    pressF.text = hit.collider.GetComponentInParent<Pickup>().GetPickupMessage();
                
                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        hit.collider.GetComponentInParent<Pickup>().applyEffect(player);
                        hit.collider.GetComponentInParent<Pickup>().getParent().SetActive(false);
                    }

                }
                
            } else
            {
                pressF.gameObject.SetActive(false);
            }
        }
    }
}
