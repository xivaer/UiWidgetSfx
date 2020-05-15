using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class UiWidgetSfx : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [SerializeField] private Vector2 m_clickScale = Vector2.one;

    private RectTransform m_widgetRect;

    // Use this for initialization
    void Start()
    {
        m_widgetRect = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    public void OnPointerDown(PointerEventData eventData)
    {
        if (!m_widgetRect)
            return;

        if (GetComponent<Button>() && !GetComponent<Button>().interactable)
            return;

        m_widgetRect.localScale = new Vector3(m_clickScale.x, m_clickScale.y, m_widgetRect.localScale.z);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        m_widgetRect.localScale = Vector2.one;
    }
}
