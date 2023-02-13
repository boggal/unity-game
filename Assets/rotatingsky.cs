using UnityEngine;

public class rotatingsky : MonoBehaviour
{
    public float rotationSpeed = 401f;
    private Material skyboxMaterial;

    private void Start()
    {
        skyboxMaterial = RenderSettings.skybox;
    }

    private void Update()
    {
        skyboxMaterial.SetFloat("_Rotation", Time.time * rotationSpeed);
    }
}
