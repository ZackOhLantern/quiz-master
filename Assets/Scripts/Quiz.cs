using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionSO question;

    void Start()
    {
        questionText.text = question.GetQuestion();
    }

}
