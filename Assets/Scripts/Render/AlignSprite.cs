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
        switch (SpriteAlignment)
        {
            case SpriteAlignment.BottomCenter:
                transform.localPosition = Vector3.Scale(renderer.sprite.bounds.extents, new Vector3(0, 1, 0));
                break;
        }
        //renderer.sprite.bounds.extents
    }
}
