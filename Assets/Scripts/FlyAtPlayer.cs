using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] Transform player;
    Vector3 playerposition;
    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerposition = player.transform.position;
    }
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }
    void MoveToPlayer()
    {
        transform.position =
        Vector3.MoveTowards(transform.position, playerposition, Time.deltaTime * speed);
    }
    
    void DestroyWhenReached()
    { 
    if(transform.position==playerposition)
    {
        Destroy(gameObject);
    }
}
}

