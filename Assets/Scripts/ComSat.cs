using UnityEngine;

public class ComSat : MonoBehaviour
{
    public float torque = 1f;
    
    Rigidbody body;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
        body.AddRelativeTorque(0, 0, torque);
    }
}
