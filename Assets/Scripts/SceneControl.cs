using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void SceneChanger()
    {
        //Debug.Log("did you Click Me!\nNeed Something?");
        SceneManager.LoadScene("Logo");
    }
}
