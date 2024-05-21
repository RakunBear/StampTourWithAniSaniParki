using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColoringScenario : MonoBehaviour
{
    public Image CharacterSelectUI;
    public GameObject coloring;
    public GameObject[] character = new GameObject[3];
    public TextMeshProUGUI talk_Bubble;
    public Canvas CaptureCanvas;

    public void OnPalette()
    {
        PhotoCapture photoCapture = CaptureCanvas.GetComponent<PhotoCapture>();
        string click = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(click);
        CharacterSelectUI.gameObject.SetActive(false);
        if (click == "Ani")
        {
            character[0].SetActive(true);
            photoCapture.copyCharacter = character[0];
        }
        else if (click == "Sani")
        {
            character[1].SetActive(true);
            photoCapture.copyCharacter = character[1];
        }
        else if (click == "Bani")
        {
            character[2].SetActive(true);
            photoCapture.copyCharacter = character[2];
        }
        coloring.SetActive(true);
        talk_Bubble.text = "���ϴ� ��������\nĥ�غ���!";

        photoCapture.characterName = click;

    }
    public void ReturnButton()
    {
        coloring.SetActive(false);
        character[0].SetActive(false);
        character[1].SetActive(false);
        character[2].SetActive(false);
        talk_Bubble.text = "��ĥ���̸� �ϰ� ���� ĳ���͸� �����!";
        CharacterSelectUI.gameObject.SetActive(true);
    }
}