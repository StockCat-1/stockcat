using UnityEngine;
using UnityEngine.UI;
using TMPro; // EKLE

public class TopUIManager : MonoBehaviour
{
    public TextMeshProUGUI goldText; // BURAYI DEĞİŞTİR
    public Slider happinessBar;

    void Start()
    {
        int gold = PlayerPrefs.GetInt("Gold", 35000);
        float happiness = PlayerPrefs.GetFloat("Happiness", 60f);

        goldText.text = gold.ToString();
        happinessBar.value = happiness;
    }
}