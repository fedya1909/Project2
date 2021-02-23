using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private MoveControl mc;
    private Vector3 offset = new Vector3(4f, 1f, -10f);

    private void Update()
    {
        if (mc.GetMoveVelocity().x > 0) transform.position = new Vector3(player.position.x + offset.x, player.position.y,offset.z);
        else transform.position = new Vector3(player.position.x - offset.x, player.position.y, offset.z);

        if(mc.GetMoveVelocity().y > 0) transform.position = new Vector3(player.position.x, player.position.y + offset.y, offset.z);
        else transform.position = new Vector3(player.position.x, player.position.y - offset.y, offset.z);
    }
}
