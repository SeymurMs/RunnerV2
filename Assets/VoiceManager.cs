using UnityEngine;
using UnityEngine.UI;

public class VoiceManager : MonoBehaviour
{
    public static bool IsMute;
    public static Image MuteBtnImg;
    public AudioSource AudioSource;
    public AudioSource CoinSound;
    public AudioSource Ha;
    public AudioSource Ho;
    private void Awake()
    {
        MuteBtnImg = GetComponentInParent<Image>();
    }
    private void Update()
    {
        CheckSound();
    }
    void CheckSound()
    {
        if (IsMute)
        {
            MuteBtnImg.color = Color.red;
            AudioSource.volume = 0f;
            CoinSound.volume = 0f;
            Ha.volume = 0f;
            Ho.volume = 0f;
        }
        else
        {
            MuteBtnImg.color = Color.white;
            AudioSource.volume = 0.2f;
            CoinSound.volume = 0.3f;
            Ha.volume = 0.3f;
            Ho.volume = 0.3f;

        }
    }
   public  void VoiceMute()
    {
        if (!Input.GetKeyDown(KeyCode.Space))
        {
            if (!IsMute)
            {
                IsMute = true;
                MuteBtnImg.color = Color.red;
            }
            else
            {
                MuteBtnImg.color = Color.white;
                IsMute = false;
            }
        }
        

        
    } 



}
