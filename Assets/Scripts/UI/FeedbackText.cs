using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackText : MonoBehaviour
{
    public void HideText()
    {
       Destroy(transform.parent.gameObject);
    }
}
