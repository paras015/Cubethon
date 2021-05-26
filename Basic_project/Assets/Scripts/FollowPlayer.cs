using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0f, 1.5f, -5.5f);

    void Update()
    {
        transform.position = player.position + offset;
    }
}
