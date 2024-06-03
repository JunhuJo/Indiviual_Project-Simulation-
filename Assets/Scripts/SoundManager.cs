using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioMixer audioMixer; // AudioMixer를 연결할 변수
    public Slider volumeSlider; // Slider를 연결할 변수
    private float currentVolume;

    void Start()
    {
        //// Slider의 값이 변경될 때마다 OnVolumeChange 메소드를 호출
        //volumeSlider.onValueChanged.AddListener(OnVolumeChange);

        // 초기 Slider 값을 AudioMixer의 볼륨으로 설정
        
        currentVolume = volumeSlider.value;
        audioMixer.GetFloat("Master", out currentVolume);
        
    }

    private void Update()
    {
        OnVolumeChange(currentVolume);
    }

    // Slider 값이 변경될 때 호출되는 메소드
    void OnVolumeChange(float value)
    {
        audioMixer.SetFloat("Master", value);
        
    }
}
