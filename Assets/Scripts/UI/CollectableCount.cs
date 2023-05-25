using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableCount : MonoBehaviour
{
    #region INSPECTOR VARIABLES   
    [Tooltip("Please assign the numberOfCollectableTextReference")]
    [SerializeField] Text numberOfCollectableText;
    #endregion

    #region OTHER VARIABLES 
    private int numberOfCollectables;
    #endregion

    #region EXECUTION   
    // Start is called before the first frame update
    void Start()
    {
        numberOfCollectables = 0;
        numberOfCollectableText.text = numberOfCollectables.ToString();
    }
    #endregion

    #region ADD COUNT METHOD
    public void AddCount()
    {
        numberOfCollectables++;
        numberOfCollectableText.text = numberOfCollectables.ToString();
    }
    #endregion
}
