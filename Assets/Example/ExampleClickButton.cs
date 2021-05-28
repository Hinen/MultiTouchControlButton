using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ExampleClickButton : MonoBehaviour {
    [SerializeField]
    private Button[] _buttons;

    public void OnClick() {
        foreach (var button in _buttons) {
            ExecuteEvents.Execute<IPointerClickHandler>(
                button.gameObject,
                new PointerEventData(EventSystem.current),
                ExecuteEvents.pointerClickHandler);
        }
    }
}
