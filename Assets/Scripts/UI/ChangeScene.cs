using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    #region INSPECTOR VARIABLES
    [Tooltip("Please assign the scenename that you want to go")]
    [SerializeField] string sceneName;
    #endregion

    #region EXECUTION
    public void Awake()
    {
        Invoke("changeScene", 3);   
    }
    #endregion

    #region CHANGE SCENE METHOD
    public void changeScene()
    {
        gameObject.SetActive(false);
        SceneManager.LoadScene(sceneName);
    }
    #endregion
}
