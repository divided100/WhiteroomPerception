using UnityEngine;
public class ToggleObject : MonoBehaviour
{
    public GameObject objectToDisable;
    public GameObject objectToEnable;
    public GameObject objectThatCanTrigger;
    public Light directionalLight;
    public float newLightIntensity = 1f;
    void Start()
    {
        if (objectToDisable != null)
            objectToDisable.SetActive(true);
        if (objectToEnable != null)
            objectToEnable.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == objectThatCanTrigger)
        {
            ActivateStage();
        }
    }
    public void ActivateStage()
    {
    if (objectToDisable != null)
        objectToDisable.SetActive(false);

    if (objectToEnable != null)
        objectToEnable.SetActive(true);

    if (directionalLight != null)
        directionalLight.intensity = newLightIntensity;
    gameObject.SetActive(false);
    }
}