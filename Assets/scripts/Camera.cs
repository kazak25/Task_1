using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private Controller _car;

    [SerializeField] private Vector3 _vector3;
    // Start is called before the first frame update
    private void Start()
    {
        _car = FindObjectOfType<Controller>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = _car.transform.position + _vector3;
    }
}
