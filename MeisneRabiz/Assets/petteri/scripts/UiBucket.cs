using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UiBucket : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public BunnyController bunnyContr;

    Image img;

    public GameObject waterPrefab;
    public float distance;

    GameObject waterGo;

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
        setRaycast(false);

        waterGo = Instantiate(waterPrefab);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        waterGo.transform.position = ray.origin + ray.direction * distance;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        waterGo.transform.position = ray.origin + ray.direction * distance;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        setRaycast(true);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        waterGo.transform.position = ray.origin + ray.direction * distance;

        bunnyContr.shootCold(Input.mousePosition, waterGo);

        waterGo = null;
    }
}

