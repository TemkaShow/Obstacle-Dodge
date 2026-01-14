using UnityEngine;
using UnityEngine.UIElements;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speedMove = 1f;
    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speedMove * Time.deltaTime);

    }
    void DestroyWhenReached()
    {
        if (playerPosition == transform.position)
        {
            Destroy(gameObject);
        }
    }
}
