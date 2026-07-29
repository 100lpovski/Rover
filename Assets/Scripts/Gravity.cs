using UnityEngine;

public class Gravity : MonoBehaviour
{
    [SerializeField]
    private Transform planet;

    private void FixedUpdate()
    {
        Physics.gravity = (planet.position - transform.position).normalized;
    }
}
