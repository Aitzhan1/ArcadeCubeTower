using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] private float rotSpeed;
    void Update()
    {
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
    }
}
