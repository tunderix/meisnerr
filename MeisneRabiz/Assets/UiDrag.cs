using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UiDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public delegate void OnDragend(UiDrag drag);
    public event OnDragend onDragend;

    Vector3 startPosition;
    Image img;

    void Awake()
    {
        img = GetComponent<Image>();
    }

    void setRaycast(bool enabled)
    {
        CanvasGroup group = GetComponent<CanvasGroup>();
        if (group)
        {
            group.blocksRaycasts = enabled;
        }
        else if (img)
        {
            img.raycastTarget = enabled;
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPosition = transform.localPosition;
        setRaycast(false);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        setRaycast(true);
        MoveToLocal(startPosition);

        if (onDragend != null)
            onDragend(this);
    }

    public void MoveToLocal(Vector3 target, float time = 0.5f)
    {
        StopAllCoroutines();
        StartCoroutine(DoMove(target, time));
    }

    IEnumerator DoMove(Vector3 target, float time)
    {
        float t = 0;
        Vector3 startPos = transform.localPosition;
        if (time != 0.0f)
        {
            while (t < 1f)
            {
                t += Time.deltaTime / time;
                transform.localPosition = Vector3.Lerp(startPos, target, 0.5f - 0.5f * Mathf.Cos(Mathf.PI * t));
                yield return null;
            }
        }
        transform.localPosition = target;
    }
}
