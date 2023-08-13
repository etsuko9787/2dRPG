using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class title_newgame : MonoBehaviour
{
    public void ClickStartButton()
    {
        Debug.Log("Scene: Town1");
        SceneManager.LoadScene("Town1");
    }
}
