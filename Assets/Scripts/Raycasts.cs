using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasts : MonoBehaviour
{
    private Camera cam;
    [SerializeField] private LayerMask layerMask;
    private PlacingTowerScript placingTowerScript;

    private void Start()
    {
        cam = Camera.main;
        placingTowerScript = GetComponent<PlacingTowerScript>();
    }

    private void Update()
    {
        if (!placingTowerScript.placing)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 100f;
            mousePos = cam.ScreenToWorldPoint(mousePos);
            Debug.DrawRay(transform.position, mousePos - transform.position, Color.blue);

            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = new Ray(transform.position, mousePos);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100f, layerMask))
                {
                    hit.transform.GetComponent<TowerScript>().TogglePreview();
                }
            }
        }
    }
}
