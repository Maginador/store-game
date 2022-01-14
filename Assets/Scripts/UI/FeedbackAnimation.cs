using TMPro;
using UnityEngine;

internal class FeedbackAnimation : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private string[] texts; 
    [SerializeField] private Color[] colors; 
    
    public void ShowText(int value, int resource)
    {
        text.text = value.ToString();

        text.color = colors[resource];
        text.text += texts[resource];
    }

}