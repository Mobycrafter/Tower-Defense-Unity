using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TankFollower : MonoBehaviour
{
    // Start is called before the first frame update
    private float rotateSpeed = 5.0f;
    public GameObject MousePos;
    public float FireCooldown = 0.0f;
    public GameObject Bullet;

    private void Awake()
    {
            MousePos = GameObject.Find("MousePos");
}
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg - 90.0f;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotateSpeed * Time.deltaTime);
        Vector2 CursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePos.transform.position = CursorPos;


        //Firing
        if (Input.GetMouseButton(0) && FireCooldown <= 1) 
        {
            Debug.Log("FIRE");
            FireCooldown = 1.5f;
            Instantiate(Bullet, new Vector3(0,0,0), Quaternion.Euler(new Vector3(0,0,transform.eulerAngles.z)));
        }
        FireCooldown = FireCooldown - 0.1f * Time.deltaTime;
    }
}