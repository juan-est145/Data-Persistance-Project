using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuUIManager : MonoBehaviour
{
    [SerializeField] TMP_Text PlayerNameInput;
    
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName()
    {
        PlayerDataHandle.Instance.playerName = PlayerNameInput.text;
    }
    public void EndButton()
    {
#if UNITY_EDITOR
    EditorApplication.ExitPlaymode();
#else 
        Application.Quit();
#endif

    }
}
