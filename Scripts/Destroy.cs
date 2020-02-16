using UnityEngine;

public class Destroy : MonoBehaviour
{

    public bool _Destroy;
    public Rigidbody Destroyed_Version;

    private void OnCollisionEnter(Collision collision)
    {
        _Destroy = true;
    }

    private void FixedUpdate()
    {
        if (_Destroy)
        {
            Rigidbody rb = Instantiate(Destroyed_Version, transform.position, Quaternion.identity) as Rigidbody;
            Destroy(gameObject);
        }
    }
}
