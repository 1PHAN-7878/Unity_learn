using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;  // �������������ƫ����
    public Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newPosition = target.position + offset;
        transform.position = newPosition;
    }
}
