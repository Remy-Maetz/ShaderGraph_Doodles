using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(Renderer))]
[ExecuteAlways]
public class CrossSectionController : MonoBehaviour
{
    public string planePropertyName = "_Plane_";
    public Transform planeTransform;

    Renderer rndr;

    void Start()
    {
        rndr = GetComponent<Renderer>();
    }

    void Update()
    {
        if (planeTransform == null) return;
        
        rndr.material.SetVector($"{planePropertyName}Position", planeTransform.position);
        rndr.material.SetVector($"{planePropertyName}Normal", planeTransform.up);
        rndr.material.SetVector($"{planePropertyName}Tangent", planeTransform.right);
    }
}
