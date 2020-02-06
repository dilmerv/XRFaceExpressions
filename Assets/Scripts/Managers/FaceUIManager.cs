using DilmerGames.Core;
using TMPro;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class FaceUIManager : Singleton<FaceUIManager>
{   
    [SerializeField]
    private GameObject faceUI;

    [SerializeField]
    private Vector3 faceUIOffset = Vector3.zero;

    [SerializeField]
    private GameObject face;

    [SerializeField]
    private TextMeshProUGUI expressionStatus;

    private ARFaceManager arFaceManager;

    void Start()
    {
        arFaceManager = GetComponent<ARFaceManager>();
        arFaceManager.facesChanged += FacesChanged;

        faceUI.transform.position = faceUIOffset;
    }

    public void UpdateDetectionStatus(string expressionName, bool detected)
    {
        expressionStatus.text = detected ? 
            $"<color=\"red\">{expressionName} EXPRESSION DETECTED</color>" : 
            $"<color=\"white\">FACE EXPRESSION SCANNING...</color>";
    }

    void FacesChanged(ARFacesChangedEventArgs args)
    {
        if(args.updated != null && args.updated.Count > 0)
        {
            face = args.updated[0].gameObject;
            faceUI.transform.rotation = face.transform.rotation;
            faceUI.transform.position = face.transform.position + faceUIOffset;
        }
    }

    void Update() 
    {
        #if UNITY_EDITOR
            faceUI.transform.rotation = face.transform.rotation;
        #endif    
    }
}
