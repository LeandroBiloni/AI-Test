using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Transform target;
    private Vector3 _dir;

    // Update is called once per frame
    void Update()
    {
        Move(target);
    }

    void Move(Transform target)
    {
        _dir = (target.position - transform.position).normalized;
        transform.position += _dir * speed * Time.deltaTime;
    }
}
