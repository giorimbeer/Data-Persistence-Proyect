using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bestScore : MonoBehaviour
{
    public TextMeshProUGUI text;
    void Start()
    {
        text.text = $"BEST SCORE: {Singleton.Instance.name}: {Singleton.Instance.points}";
    }

}
