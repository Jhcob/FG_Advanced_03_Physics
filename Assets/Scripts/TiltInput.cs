using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltInput : MonoBehaviour
{
    /* [SerializeField] private float _force = 5f;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
    }


    private void OnMouseDown()
    {
        var mousePosition = Input.mousePosition;

        var castPoint = Camera.main.ScreenPointToRay(mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))
        {
            Debug.Log(hit.point);
             //   _rigidbody.angularVelocity = Vector3.zero;
               // _rigidbody.AddForceAtPosition((Vector3.down * _force, hit.point));
            
      
        }
    }
    
    */
    
    [SerializeField] float pokeForce;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForceAtPosition(ray.direction * pokeForce, hit.point);
                }
            }
        }
    }
}
