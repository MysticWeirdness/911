using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlacingTowerScript : MonoBehaviour
{
    private Camera cam;
    private GameManager gameManager;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private List<GameObject> towers = new List<GameObject>();
    private int currentTowerIndex = 0;
    [SerializeField] private TextMeshProUGUI placingMode;
    [SerializeField] private TextMeshProUGUI selectedTowerText;
    private string selectedTower = "Base Tower";
    [SerializeField] private GameObject towerPreview;
    public bool placing { get; private set; } = false;

    private void Awake()
    {
        gameManager = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
    }
    private void Start()
    {
        cam = Camera.main;
    }

    
    public void TogglePlacingMode()
    {
        placing = !placing;
        if (placing)
        {
            towerPreview.SetActive(true);
        }
        else if (!placing)
        {
            towerPreview.SetActive(false);
        }
    }
    private void Update()
    {
        if (placing)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 100;
            mousePos = cam.ScreenToWorldPoint(mousePos);
            Ray ray = new Ray(transform.position, mousePos);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100f, layerMask))
            {
                towerPreview.transform.position = new Vector3(hit.transform.position.x, hit.transform.position.y + 0.35f, hit.transform.position.z);
                if (Input.GetMouseButtonDown(0))
                {
                    if (gameManager.GetCurrency() >= towers[currentTowerIndex].GetComponent<TowerScript>().GetTowerValue())
                    {
                        hit.collider.gameObject.layer = LayerMask.NameToLayer("Unplaceable");
                        gameManager.ChangeCurrency(-towers[currentTowerIndex].GetComponent<TowerScript>().GetTowerValue());
                        Instantiate(towers[currentTowerIndex], new Vector3(hit.transform.position.x, hit.transform.position.y + 0.2f, hit.transform.position.z), Quaternion.identity);
                    }
                }
            }
        }
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (placing)
        {
            placingMode.text = "Placing: Yes";
            placingMode.color = Color.green;
        }
        else if (!placing)
        {
            placingMode.text = "Placing: No";
            placingMode.color = Color.red;
        }
        selectedTowerText.text = "Selected Tower: " + selectedTower;
    }

    public void BaseTower()
    {
        currentTowerIndex = 0;
        selectedTower = "Base Tower";
        UpdateUI();
    }

    public void BigTower()
    {
        currentTowerIndex = 1;
        selectedTower = "Big Tower";
        UpdateUI();
    }
}
