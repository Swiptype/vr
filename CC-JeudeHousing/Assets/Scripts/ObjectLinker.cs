using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectLinker : MonoBehaviour
{
    public void OnGrab()
    {
        ObjectModifierUI ui = FindObjectOfType<ObjectModifierUI>(true);

        if (ui != null)
        {
            ui.SetTarget(this.transform);
            Debug.Log("UI connecté à " + gameObject.name);
        }
    }
}