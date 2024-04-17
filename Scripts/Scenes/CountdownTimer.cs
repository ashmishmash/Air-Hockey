using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public float totalTime = 7;

    private void Update()
    {
        if (totalTime > 0)
        {
            totalTime -= Time.deltaTime;
            timeText.text = totalTime.ToString();
        }
        else
        {
            SceneManager.LoadSceneAsync(2);
        }
    }
}
