using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private MoveControl mc;
    private Vector3 _savePosition;
    private Vector3 _offset = new Vector3(2f, 2f, -10f);
    
    private void Start()
    {
        _savePosition = new Vector3(player.position.x, player.position.y, _offset.z);
    }
    private void Update()
    {
        transform.position = _savePosition;
        if (mc.GetFacingRight())
        {
            transform.position = new Vector3(player.position.x + _offset.x, player.position.y, _offset.z);
            _savePosition = transform.position;
        }
        else if (!mc.GetFacingRight())
        {
            transform.position = new Vector3(player.position.x - _offset.x, player.position.y, _offset.z);
            _savePosition = transform.position;
        }
        else if (mc.GetStateUp())
        {
            transform.position = new Vector3(player.position.x, player.position.y + _offset.y, _offset.z);
            _savePosition = transform.position;
        }
        else if (!mc.GetStateUp())
        {
            transform.position = new Vector3(player.position.x, player.position.y - _offset.y, _offset.z);
            _savePosition = transform.position;
        }
        transform.position = _savePosition;
    }
}
