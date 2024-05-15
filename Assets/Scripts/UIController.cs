using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject dropdown;
    private Animator dropdownAnimator;
    private bool droppedDown = false;

    private void Start()
    {
        dropdownAnimator = dropdown.GetComponent<Animator>();
    }
    public void ToggleDropdown()
    {
        if (!droppedDown)
        {
            dropdownAnimator.SetTrigger("Dropdown");
            droppedDown = !droppedDown;
        }
        else if (droppedDown)
        {
            dropdownAnimator.SetTrigger("Dropup");
            droppedDown = !droppedDown;
        }
    }
}
