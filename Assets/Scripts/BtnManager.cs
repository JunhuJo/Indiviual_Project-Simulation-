using UnityEngine;
using UnityEngine.UI;

public class BtnManager : MonoBehaviour
{
    [Header("MenuBtn")]
    [SerializeField] private GameObject MenuText;
    [SerializeField] private GameObject ExitBtn;
    [SerializeField] private GameObject OptionBtn;
    [SerializeField] private GameObject ContinueBtn;

    [Header("VolumeSlider")]
    [SerializeField] private GameObject VolumeText;
    [SerializeField] private Slider VolumeSlider;
    [SerializeField] private GameObject BackBtn;

    [Header("ChatLogin")]
    [SerializeField] private GameObject ChatLoginWindow;


    public void OnClick_OptionEnter()
    {
        MenuText.gameObject.SetActive(false);
        ExitBtn.gameObject.SetActive(false);
        OptionBtn.gameObject.SetActive(false);
        ContinueBtn.gameObject.SetActive(false);

        VolumeText.gameObject.SetActive(true);
        VolumeSlider.gameObject.SetActive(true);
        BackBtn.gameObject.SetActive(true);
    }

    public void OnClick_Back()
    {
        MenuText.gameObject.SetActive(true);
        ExitBtn.gameObject.SetActive(true);
        OptionBtn.gameObject.SetActive(true);
        ContinueBtn.gameObject.SetActive(true);

        VolumeText.gameObject.SetActive(false);
        VolumeSlider.gameObject.SetActive(false);
        BackBtn.gameObject.SetActive(false);
    }

    public void OnClick_ChatLogin_Window_Close()
    {
        ChatLoginWindow.gameObject.SetActive(false);
    }
}
