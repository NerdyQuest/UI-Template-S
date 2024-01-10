using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class RewardFillUpCircle : MonoBehaviour
{
    [SerializeField] float fillSpeed = 0.5f;
    [SerializeField] TextMeshProUGUI percentageText;
    private Image fill;

    private void Start()
    {
        fill = GetComponent<Image>();

        if (fill == null)
        {
            Debug.LogError("Image component not found. Make sure the script is attached to a GameObject with an Image component.");
            return;
        }

        StartCoroutine(FillUpCoroutine());
    }


    private IEnumerator FillUpCoroutine()
    {
        float currentFill = 0f;

        while (currentFill < 1f)
        {
            currentFill += Time.deltaTime * fillSpeed;
            fill.fillAmount = currentFill;

            UpdatePercentageText(currentFill);

            yield return null;
        }
        fill.fillAmount = 1f;
        if (fill.fillAmount == 1)
        {
            fill.color = Color.cyan;
        }
        UpdatePercentageText(1f);
    }

    private void UpdatePercentageText(float fillAmount)
    {
        if (percentageText != null)
        {
            float percentage = fillAmount * 100f;
            percentageText.text = $"{Mathf.RoundToInt(percentage)}%";
        }
    }
}

