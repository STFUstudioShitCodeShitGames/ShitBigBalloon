using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(BoxCollider2D), typeof(RectTransform))]
public class RururClo : MonoBehaviour
{
    private RectTransform Shmokt => _shlekt == null ? GetComponent<RectTransform>() : _shlekt;

    private void OnEnable()
    {
        Gollider.size = Shmokt.rect.size;
        Gollider.offset = Shmokt.rect.center;
    }

    private RectTransform _shlekt;
    private BoxCollider2D _jojub;

    private void OnRectTransformDimensionsChange()
    {
        Gollider.size = Shmokt.rect.size;
        Gollider.offset = Shmokt.rect.center;
    }

    public BoxCollider2D Gollider => _jojub == null ? GetComponent<BoxCollider2D>() : _jojub;
   
}