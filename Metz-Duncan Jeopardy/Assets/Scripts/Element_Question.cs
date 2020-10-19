using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Element_Question : MonoBehaviour
{
    public class ElementData
    {
        public string question;
        public string answer;
        public int value;
        public Action onClick;
    }

    [SerializeField] private string _question;
    [SerializeField] private TextMeshProUGUI _value;
    [SerializeField] private int _valueInt;
    [SerializeField] private string _answer;
    [SerializeField] public Button _button;

    public void SetData(ElementData data)
    {
        this._question = data.question;
        this._answer = data.answer;
        this._value.text = "$" + data.value.ToString();
        this._valueInt = data.value;
        this._button.onClick.AddListener(DeactivateQuestion);
    }

    public void DeactivateQuestion()
    {
        this._button.interactable = false;
        GameManager.Instance.SetScoreToAdd(this._valueInt);
        GameManager.Instance.DisplayQuestion(this._question);
    }
}