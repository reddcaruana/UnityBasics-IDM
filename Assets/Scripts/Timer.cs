using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TMP_Text uiText;
    public float value = 60;
    
    // Update is called once per frame
    void Update()
    {
        // value -= Time.deltaTime;
        value = Mathf.Max(value - Time.deltaTime, 0);
        uiText.text = $"Timer: {value:0}";
    }
}
