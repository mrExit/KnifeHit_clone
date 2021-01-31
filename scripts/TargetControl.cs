using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetControl : MonoBehaviour
{
    [SerializeField] float _rotationZ;
    [SerializeField] GameObject _knife;


    void Update()
    {
        Rotation();
    }
    private void Start()
    {
        Instantiate(_knife);
    }


    private void Rotation()
    {
        this.transform.Rotate(0,0,_rotationZ);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(_knife);
    }
}
