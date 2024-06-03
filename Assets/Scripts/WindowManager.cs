using UnityEngine;
using UnityEngine.InputSystem;

public class WindowManager : MonoBehaviour
{
    [Header("ChattingWindow")]
    [SerializeField] GameObject _ChattingWindow;
    [SerializeField] CharacterController _CharacterController;

    [Header("MenuWindow")]
    [SerializeField] private GameObject _MenuWindow;
    private bool ShowMenu = false;

    [Header("ChatLoginWindow")]
    [SerializeField] private GameObject _ChatLoginWindow;

    private void Update()
    {
        OpenCloseChattingWindow();
        OpenCloseMenu();
    }

    private void OpenCloseChattingWindow()
    {
        if (Input.GetKey(KeyCode.C))
        {
            _ChatLoginWindow.SetActive(true);
            _CharacterController.enabled = false;
        }
        //else if (Input.GetKey(KeyCode.Escape))
        //{
        //    _ChattingWindow.SetActive(false);
        //    _CharacterController.enabled = true;
        //}
    }

    public void BtnCloseChattingWindow()
    {
        _ChatLoginWindow.SetActive(false);
        _CharacterController.enabled = true;
    }

    private void OpenCloseMenu()
    {
        if (Input.GetKey(KeyCode.Escape) && !ShowMenu)
        {
            _MenuWindow.SetActive(true);
            ShowMenu = true;
        }
        else if(Input.GetKey(KeyCode.Escape) && ShowMenu)
        {
            _MenuWindow.SetActive(false);
            ShowMenu = false;
        }
    }
}
