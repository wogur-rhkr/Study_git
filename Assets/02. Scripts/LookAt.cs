using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform targetCamera;

    void Update()
    {
        if (targetCamera != null)
        {
            transform.LookAt(targetCamera);
        }
    }
}
