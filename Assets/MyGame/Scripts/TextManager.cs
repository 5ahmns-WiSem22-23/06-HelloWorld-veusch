using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextManager : MonoBehaviour

    {
    [SerializeField] TextMeshProUGUI textMeshPro;
    [SerializeField] InputField inputField;

    private void Awake()
    {
        textMeshPro.gameObject.SetActive(false);
    }
    public void ShowText()
    {
        textMeshPro.text = inputField.text;
        if (!textMeshPro.gameObject.activeSelf) textMeshPro.gameObject.SetActive(true);
    }

}
