using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GetAR : MonoBehaviour
{
    public static bool IsActive;
    MeshRenderer mesh;
    void Start() => mesh = GetComponent<MeshRenderer>();
    void FixedUpdate() => IsActive = mesh.enabled;
}


