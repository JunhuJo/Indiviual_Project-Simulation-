using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioMixer audioMixer; // AudioMixer�� ������ ����
    public Slider volumeSlider; // Slider�� ������ ����
    private float currentVolume;

    void Start()
    {
        //// Slider�� ���� ����� ������ OnVolumeChange �޼ҵ带 ȣ��
        //volumeSlider.onValueChanged.AddListener(OnVolumeChange);

        // �ʱ� Slider ���� AudioMixer�� �������� ����
        
        currentVolume = volumeSlider.value;
        audioMixer.GetFloat("Master", out currentVolume);
        
    }

    private void Update()
    {
        OnVolumeChange(currentVolume);
    }

    // Slider ���� ����� �� ȣ��Ǵ� �޼ҵ�
    void OnVolumeChange(float value)
    {
        audioMixer.SetFloat("Master", value);
        
    }
}
