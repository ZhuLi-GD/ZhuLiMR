using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TwoHandGrabInteractable : XRGrabInteractable
{
    /*public List<XRSimpleInteractable> secondHandGrabPoints = new List<XRSimpleInteractable>();
    // Start is called before the first frame update
    void Start()
    {
        foreach(var item in secondHandGrabPoints)
        {
            item.onSelectEnter.AddListener(OnSecondHandGrab);
            item.onSelectExit.AddListener(OnSecondHandRelease);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnSecondHandGrab(XRBaseInteractor interactor)
    {

    }

    public void OnSecondHandRelease(XRBaseInteractor interactor)
    {

    }

    protected override void OnSelectEnter(XRBaseInteractor interactor)
    {
        base.OnSelectEnter(interactor);
    }

    protected override void OnSelectExit(XRBaseInteractor interactor)
    {
        base.OnSelectExit(interactor);
    }

    public override bool IsSelectableBy(XRBaseInteractor interactor)
    {
        bool isalreadygrabbed = selectingInteractor && !interactor.Equals(selectingInteractor);
        return base.IsSelectablelBy(interactor)&&!isalreadygrabbed;
    }*/
}
