using UnityEngine;

public class Pick : MonoBehaviour
{
    public bool Pickit;
    public bool throow;

    void Update()
    {
        if (Pickit)
        {
            if (Input.GetMouseButtonDown(0))
            {
                throow = true;
                Pickit = false;
            }
        }
    }
}
