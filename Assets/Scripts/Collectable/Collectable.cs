using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Collectable : MonoBehaviour
{
    #region INSPECTOR VARIABLES
    [Tooltip("Please assign the coleectablecountscript of the ui")]
    [SerializeField] CollectableCount collectableCount;
    [Tooltip("Please assign the textui to grab")]
    [SerializeField] GameObject GrabText;

    [Header("Input")]
    [Tooltip("Please assign the input reference")]
    [SerializeField] InputActionReference Grab;
    #endregion

    #region OTHER VARIABLES
    public bool playerNear;
    #endregion

    #region EXECUTION
    private void Update()
    {
        GetCollectable();
    }
    #endregion

    #region GET COLLECTABLE METHOD
    public void GetCollectable()
    {
        if(playerNear == true && Grab.action.triggered)
        {
            collectableCount.AddCount();
            Destroy(gameObject);
            GrabText.SetActive(false);
            playerNear = false;
        }
    }
    #endregion

    #region TRIGGER DETECTION
    // Method to detect whether the player enters the trigger zone
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            GrabText.SetActive(true);
            playerNear = true;
        }
    }

    // Method to detect whether the player has exited the trigger zone
    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            GrabText.SetActive(false);
            playerNear = false;
        }
    }
    #endregion
}
