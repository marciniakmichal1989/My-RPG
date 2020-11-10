﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    
    //[SerializeField] private Transform _target;
    

    void Update()
    {


        UpdateAnimator();
    
    }



    public void MoveTo(Vector3 destynation)
    {
        GetComponent<NavMeshAgent>().destination = destynation;
    }

    private void UpdateAnimator()
    {
        Vector3 velocity = GetComponent<NavMeshAgent>().velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
        float speed = localVelocity.z;
        GetComponent<Animator>().SetFloat("forwardSpeed", speed); 
    }

}
