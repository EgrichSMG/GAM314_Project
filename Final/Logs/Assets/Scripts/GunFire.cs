using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    [SerializeField] private LayerMask RandomCubesLayer;

    private Camera BillyCamera;
    public int score = 0;

    private void Start()
    {
        BillyCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray gunray = new Ray(BillyCamera.transform.position, BillyCamera.transform.forward);
            if (Physics.Raycast(gunray, out RaycastHit hitinfo, 100f, RandomCubesLayer))
            {
                Destroy(hitinfo.collider.gameObject);
            }
        }
    }
}
