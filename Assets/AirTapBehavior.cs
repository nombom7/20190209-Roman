using HoloToolkit.Unity.InputModule;
using UnityEngine;
using HoloToolkit.Unity;
using UnityEngine.XR.WSA.Persistence;

public class AirTapBehavior : MonoBehaviour, IInputClickHandler
{

    void Start()
    {

        WorldAnchorStore.GetAsync(AnchorStoreReady);
    }

    void AnchorStoreReady(WorldAnchorStore store)
    {
        foreach (string id in store.GetAllIds())
        {
            if (id == "anchor01")
            {
                WorldAnchorManager.Instance.AttachAnchor(this.gameObject, "anchor01");
            }
        }
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {

        WorldAnchorManager.Instance.AttachAnchor(this.gameObject, "anchor01");
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;


    }
}