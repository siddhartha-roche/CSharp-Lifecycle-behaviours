using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 3f; 
    public TextMeshProUGUI countdownText;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            countdownText.text = Mathf.Ceil(timeRemaining).ToString();
            countdownText.SetText($"{timeRemaining.ToString("N2")}");
        }
        else
        {
            countdownText.text = "0";  
        }
    }
}
