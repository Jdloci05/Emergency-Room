using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaygroundUI : MonoBehaviour
{
    #region INSPECTOR VARIABLES
    [Tooltip("Please assign the playerController Script")]
    [SerializeField] PlayerController playerController;

    [Tooltip("Please assign the InitialUI")]
    [SerializeField] GameObject InicioUI;
    [Tooltip("Please assign the tiemUI")]
    [SerializeField] GameObject timeUI;
    [Tooltip("Please assign the countUI")]
    [SerializeField] GameObject CountUI;
    #endregion

    #region BUTTON METHOD
    public void Comenzar()
    {
        playerController.enabled = true;
        InicioUI.SetActive(false);
        timeUI.SetActive(true);
        CountUI.SetActive(true);
    }
    #endregion
}
