using UnityEngine;
using UnityEngine.UI;

public class ExampleButton : MonoBehaviour {
    [SerializeField]
    private Text _clickCountText;

    private int _count = 0;

    public void OnClickButton() {
        _clickCountText.text = (++_count).ToString();
    }
}
