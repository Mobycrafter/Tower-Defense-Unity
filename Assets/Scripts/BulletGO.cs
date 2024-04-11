using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletGO : MonoBehaviour

{
    public GameObject Bullet;
    public float Distance;
    public GameObject Tank;
    public GameObject Mouse;
    public float BulletSpeed = 5000.0f;
    public Rigidbody2D BulletRigidBody;
    public float CountUp = 0;
    // Start is called before the first frame update

    private void Awake()
    {
        BulletRigidBody = GetComponent<Rigidbody2D>();
        Tank = GameObject.Find("Circle");
        Mouse = GameObject.Find("MousePos");
    }
    void Start()
    {
        Distance = Vector3.Distance(Tank.transform.position, Mouse.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        BulletRigidBody.velocity = transform.up * BulletSpeed * Time.deltaTime;

        if (Vector3.Distance(gameObject.transform.position, Tank.transform.position) >= (Distance - 6.0f)) 
        {
            Destroy(gameObject);
        }
    }
}
