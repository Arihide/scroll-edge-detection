﻿using UnityEngine;
using UnityEngine.UI;

public class EdgeDetect : MonoBehaviour
{
    [SerializeField] private ScrollRect scroll = null;
    [SerializeField] private Image top = null;
    [SerializeField] private Image bottom = null;
    [SerializeField] private Image left = null;
    [SerializeField] private Image right = null;

    private const float eps = 0.1f;

    private void Update()
    {
        Bounds contentBound = RectTransformUtility.CalculateRelativeRectTransformBounds(scroll.viewport, scroll.content);
        Rect viewportRect = scroll.viewport.rect;

        top.enabled = viewportRect.max.y >= contentBound.max.y - eps;
        bottom.enabled = viewportRect.min.y <= contentBound.min.y + eps;
        left.enabled = viewportRect.min.x <= contentBound.min.x + eps;
        right.enabled = viewportRect.max.x >= contentBound.max.x - eps;
    }
}
