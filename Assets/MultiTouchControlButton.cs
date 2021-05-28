using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MultiTouchControlButton : Button {
    private static bool _touchable = true;
    
    public bool multiTouchable = true;

    public override void OnPointerClick(PointerEventData eventData) {
        if (!IsTouchable())
            return;
        
        base.OnPointerClick(eventData);
    }

    public override void OnSubmit(BaseEventData eventData) {
        if (!IsTouchable())
            return;
        
        base.OnSubmit(eventData);
    }

    private bool IsTouchable() {
        if (!multiTouchable && !_touchable)
            return false;

        StartCoroutine(StartTouchableTimer());
        return true;
    }

    private IEnumerator StartTouchableTimer() {
        _touchable = false;
        
        yield return new WaitForSeconds(0.1f);
        
        _touchable = true;
    }
}