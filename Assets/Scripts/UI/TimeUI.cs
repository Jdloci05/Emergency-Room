using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUI : MonoBehaviour
{
    #region INSPECTOR VARIABLES
    [Tooltip("Please assign the time that the round would last")]
    [SerializeField] int min, seg;
    [Tooltip("Please assign the uitext of time")]
    [SerializeField] Text tiempo;
    [Tooltip("Please assign the timeoutUI")]
    [SerializeField] GameObject TimeOut;

    [Tooltip("Please assign the playerControllerScript")]
    [SerializeField] PlayerController playerController;
    [Tooltip("Please assign the animator of player")]
    [SerializeField] Animator anim;
    #endregion

    #region OTHER VARIABLES
    private bool enMarcha;
    private float restante;
    #endregion

    #region EXECUTION
    private void Awake()
    {
        restante = (min * 60) + seg;
        enMarcha = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        StartTimer();
    }
    #endregion

    #region TIMER METHOD
    public void StartTimer()
    {
        if (enMarcha == true)
        {
            restante -= Time.deltaTime;
            if (restante < 1)
            {
                anim.enabled = false;
                playerController.enabled = false;
                TimeOut.SetActive(true);
                gameObject.SetActive(false);
            }
            int tempMin = Mathf.FloorToInt(restante / 60);
            int temSeg = Mathf.FloorToInt(restante % 60);
            tiempo.text = string.Format("{00:00}:{01:00}", tempMin, temSeg);
        }
    }
    #endregion
}
