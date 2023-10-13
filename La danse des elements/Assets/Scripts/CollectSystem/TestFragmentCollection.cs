using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestFragmentCollection : MonoBehaviour
{
    private int FireFragments = 0;
    private int WaterFragments = 0;
    private int WindFragments = 0;
    private int RockFragments = 0;

    public GameObject uiFragmentText;
    public bool uiFragmentVisible = false;

    private Vector2 uiFragmentHiddenPosition = new Vector2(-195f, 0f); // Position when hidden
    private Vector2 uiFragmentVisiblePosition = new Vector2(25f, 0f);   // Position when visible

    public TextMeshProUGUI fireFragmentText;
    public TextMeshProUGUI waterFragmentText;
    public TextMeshProUGUI windFragmentText;
    public TextMeshProUGUI rockFragmentText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fragment"))
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("FireFragment"))
            {
                FireFragments++;
                fireFragmentText.text = "Fire Fragment : " + FireFragments.ToString();
                Debug.Log("Fire Fragments: " + FireFragments);
                Destroy(other.gameObject);
            }
            if (other.gameObject.layer == LayerMask.NameToLayer("WaterFragment"))
            {
                WaterFragments++;
                waterFragmentText.text = "Water Fragment : " + WaterFragments.ToString();
                Debug.Log("Water Fragments: " + WaterFragments);
                Destroy(other.gameObject);
            }
            if (other.gameObject.layer == LayerMask.NameToLayer("WindFragment"))
            {
                WindFragments++;
                windFragmentText.text = "Wind Fragment : " + WindFragments.ToString();
                Debug.Log("Wind Fragments: " + WindFragments);
                Destroy(other.gameObject);
            }
            if (other.gameObject.layer == LayerMask.NameToLayer("RockFragment"))
            {
                RockFragments++;
                rockFragmentText.text = "Rock Fragment : " + RockFragments.ToString();
                Debug.Log("Rock Fragments: " + RockFragments);
                Destroy(other.gameObject);
            }
        }
    }
    private void Update()
    {
        if (Keyboard.current.tabKey.wasPressedThisFrame)
        {
            uiFragmentVisible = !uiFragmentVisible;

            if (uiFragmentVisible)
            {
                // Slide the UI in
                uiFragmentText.SetActive(true);
                StartCoroutine(MoveUITo(uiFragmentVisiblePosition));
            }
            else
            {
                // Slide the UI out
                StartCoroutine(MoveUITo(uiFragmentHiddenPosition, () => uiFragmentText.SetActive(false)));
            }
        }
    }

    private IEnumerator MoveUITo(Vector2 targetPosition, System.Action onComplete = null)
    {
        float duration = 0.5f; // You can adjust the duration as needed
        float elapsedTime = 0f;
        RectTransform rectTransform = uiFragmentText.GetComponent<RectTransform>();
        Vector2 initialPosition = rectTransform.anchoredPosition;

        while (elapsedTime < duration)
        {
            rectTransform.anchoredPosition = Vector2.Lerp(initialPosition, targetPosition, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        rectTransform.anchoredPosition = targetPosition;

        onComplete?.Invoke();
    }
}