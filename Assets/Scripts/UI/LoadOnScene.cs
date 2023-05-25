using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnScene : MonoBehaviour
{
    #region INSPECTOR VARIABLES
    [Tooltip("Please assign the gameobject that contains botiquinesUI")]
    [SerializeField] GameObject UIBotuquin;
    [Tooltip("Please assign the gameobject TitleScore")]
    [SerializeField] GameObject UITextScore;
    #endregion

    #region OTHER VARIABLES
    private static LoadOnScene Instance;
    #endregion

    #region EXECUTION
    // Start is called before the first frame update
    void Start()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Results();

    }
    #endregion

    #region RESULT METHOD
    public void Results()
    {
        if (SceneManager.GetActiveScene().name == "FinalScene")
        {
            UITextScore.SetActive(true);
            UIBotuquin.transform.localScale = new Vector3(2,2,2);
            UIBotuquin.transform.localPosition = new Vector3(0, 0, 0);
        }
        else
        {

        }
    }
    #endregion
}
