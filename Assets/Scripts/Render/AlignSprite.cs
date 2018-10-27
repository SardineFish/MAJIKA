using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
[RequireComponent(typeof(SpriteRenderer))]
public class AlignSprite : MonoBehaviour
{
    public SpriteAlignment SpriteAlignment;
    new SpriteRenderer renderer;
    private void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();
    }
    void LateUpdate()
    {
        var pixelOffset = new Vector2(renderer.sprite.rect.width % 2 / 2, renderer.sprite.rect.height % 2 / 2) / GridSystem.Instance.PixelPerGrid;
        switch (SpriteAlignment)
        {
            case SpriteAlignment.BottomCenter:
                transform.localPosition = Vector3.Scale(renderer.sprite.bounds.extents, new Vector3(0, 1, 0));
                transform.localPosition = transform.localPosition.Set(x: transform.localPosition.x - pixelOffset.x);
                break;
        }
        //renderer.sprite.bounds.extents
    }
}
