using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{

    public float Force;
    public Pick pick;
    public Transform InteractPosition;
    public Rigidbody _rigidbody;
    
    void Start()
    {
       pick = GameObject.FindGameObjectWithTag("Player").GetComponent<Pick>();
    }

    private void Update()
    {

        if (pick.Pickit)
        {
            if (pick.throow)
            {
                throwMe();
            }
        }
    }

    void throwMe()
    {
        _rigidbody.useGravity = true;
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                pick.Pickit = true;
            }
            if (pick.Pickit)
            {
                this.transform.position = InteractPosition.transform.position;
            }
        }
    }
}
