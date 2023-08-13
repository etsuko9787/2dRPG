using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class title_newgame : MonoBehaviour
{
    public void ClickStartButton()
    {
        SceneManager.LoadScene("Title1");
    }
}
