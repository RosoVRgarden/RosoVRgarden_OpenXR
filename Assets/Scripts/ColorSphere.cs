using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class ColorSphere : MonoBehaviour
{
    public InputActionReference colorReference = null;
    private MeshRenderer meshRenderer = null;


    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        float value = colorReference.action.ReadValue<float>();
        UpdateColor(value);
    }

    private void UpdateColor(float value)
    {
        meshRenderer.material.color = new Color(value, value, value);
    }

}
