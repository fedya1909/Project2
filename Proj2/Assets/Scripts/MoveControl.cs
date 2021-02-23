using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    public float speed;
    private Rigidbody2D _rb;
    private Vector2 _moveVelocity;
    private bool _facingRight = true;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        Flip();
    }


    private void Flip()
    {
        if (_facingRight && _moveVelocity.x < 0)
        {
            transform.localScale *= new Vector2(-1, 1);
            _facingRight = !_facingRight;
        }
        else if (!_facingRight && _moveVelocity.x > 0)
        {
            transform.localScale *= new Vector2(-1, 1);
            _facingRight = !_facingRight;
        }
    }
    private void Walk()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        _moveVelocity = moveInput * speed;
        _rb.MovePosition(_rb.position + _moveVelocity * Time.fixedDeltaTime);
    }
    public bool GetFacingRight()
    {
        return _facingRight;
    }
    public Vector2 GetMoveVelocity()
    {
        return _moveVelocity;
    }
}
