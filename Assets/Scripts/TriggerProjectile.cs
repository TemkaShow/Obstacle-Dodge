using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectlile;
    [SerializeField] GameObject projectlile1;
    [SerializeField] GameObject projectlile2;
    [SerializeField] GameObject projectlile3;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            projectlile.SetActive(true);
            projectlile1.SetActive(true);
            projectlile2.SetActive(true);
            projectlile3.SetActive(true);
        }
    }
}
