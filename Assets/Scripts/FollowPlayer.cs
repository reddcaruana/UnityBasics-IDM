using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Since we can't assign the player in a prefab
    // we need to look for it instead
    private Transform player;

    public float speed = 5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the next position to move to
        Vector3 target = Vector3.MoveTowards(
            transform.position,
            player.position,
            speed * Time.deltaTime);
        
        // Move towards the player
        transform.position = target;
    }
}
