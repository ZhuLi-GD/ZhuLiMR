using System.Collections;
using System.Collections.Generic;
using Unity.XR.PXR;
using UnityEngine;

public class SeeThrough : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;
    [SerializeField]
    private float enableSeeThroughAfter = 1.0f;


    private void Awake()
    {
        if (mainCamera == null) mainCamera = GetComponent<Camera>();

        if(mainCamera)
        {
            mainCamera.clearFlags = CameraClearFlags.SolidColor;
            mainCamera.backgroundColor = new Color(0, 0, 0, 0);

            StartCoroutine(ToggleSeeThrough(true));
        }
        else
        {

        }

    }
    
    private IEnumerator ToggleSeeThrough(bool enable)
    {
        yield return new WaitForSeconds(enableSeeThroughAfter);

        PXR_Boundary.EnableSeeThroughManual(enable);

    }

    private void OnApplicationPause(bool pause)
    {
        if(!pause)
        {
            PXR_Boundary.EnableSeeThroughManual(true);
        }
    }
}
