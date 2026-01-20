using UnityEngine;
using UnityEngine.UI;

public class ObjectModifierUI : MonoBehaviour
{
    [Header("Référence aux Sliders de l'UI")]
    public Slider scaleXSlider;
    public Slider scaleYSlider;
    public Slider scaleZSlider;
    public Slider rotationSliderX;
    public Slider rotationSliderY;
    public Slider rotationSliderZ;
    public Slider positionSliderX;
    public Slider positionSliderY;
    public Slider positionSliderZ;
    
    private Transform currentTarget;
    private bool isUpdatingUI = false;

    public void SetTarget(Transform newTarget)
    {
        currentTarget = newTarget;
        
        isUpdatingUI = true; 
        if(scaleXSlider) scaleXSlider.value = currentTarget.localScale.x;
        if(scaleYSlider) scaleYSlider.value = currentTarget.localScale.y;
        if(scaleZSlider) scaleZSlider.value = currentTarget.localScale.z;
        isUpdatingUI = false;

        gameObject.SetActive(true);
    }

    //SCALE

    public void OnScaleXChanged(float value)
    {
        Debug.Log("Slider bouge ! Valeur reçue : " + value + " | Cible : " + (currentTarget != null ? currentTarget.name : "NULL"));
        if (currentTarget == null || isUpdatingUI) return;
        Vector3 s = currentTarget.localScale;
        currentTarget.localScale = new Vector3(value, s.y, s.z);
    }

    public void OnScaleYChanged(float value)
    {
        if (currentTarget == null || isUpdatingUI) return;
        Vector3 s = currentTarget.localScale;
        currentTarget.localScale = new Vector3(s.x, value, s.z);
    }

    public void OnScaleZChanged(float value)
    {
        if (currentTarget == null || isUpdatingUI) return;
        Vector3 s = currentTarget.localScale;
        currentTarget.localScale = new Vector3(s.x, s.y, value);
    }

    //ROTATION

    public void OnRotationXChanged(float value)
    {
        if (currentTarget == null || isUpdatingUI) return;
        Vector3 r = currentTarget.localEulerAngles;
        currentTarget.localEulerAngles = new Vector3(value, r.y, r.z);
    }

    public void OnRotationYChanged(float value)
    {
        if (currentTarget == null || isUpdatingUI) return;
        Vector3 r = currentTarget.localEulerAngles;
        currentTarget.localEulerAngles = new Vector3(r.x, value, r.z);
    }

    public void OnRotationZChanged(float value)
    {
        if (currentTarget == null || isUpdatingUI) return;
        Vector3 r = currentTarget.localEulerAngles;
        currentTarget.localEulerAngles = new Vector3(r.x, r.y, value);
    }

    //POSITION

    public void OnPositionXChanged(float value)
    {
        if (currentTarget == null || isUpdatingUI) return;
        Vector3 p = currentTarget.localPosition;
        currentTarget.localPosition = new Vector3(value, p.y, p.z);
    }

    public void OnPositionYChanged(float value)
    {
        if (currentTarget == null || isUpdatingUI) return;
        Vector3 p = currentTarget.localPosition;
        currentTarget.localPosition = new Vector3(p.x, value, p.z);
    }

    public void OnPositionZChanged(float value)
    {
        if (currentTarget == null || isUpdatingUI) return;
        Vector3 p = currentTarget.localPosition;
        currentTarget.localPosition = new Vector3(p.x, p.y, value);
    }
}