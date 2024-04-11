using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.U2D;

public class MosPos : MonoBehaviour
{
    // Start is called before the first frame update
    public float RotateSpeed = 5.0f;
    public bool CursorAim = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Cursor.visible = false;
    }
}
