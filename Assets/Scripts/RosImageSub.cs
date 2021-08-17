using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Sensor;

public class RosImageSub : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public string topicName;
    private Texture2D texture2D;
    private byte[] imageData;

    void Start()
    {
        ROSConnection.instance.Subscribe<CompressedImageMsg>(topicName, UpdateImage);
        texture2D = new Texture2D(1, 1);
        meshRenderer.material = new Material(Shader.Find("Standard"));
    }

    void UpdateImage(CompressedImageMsg image)
    {
        imageData = image.data;
        texture2D.LoadImage(imageData);
        ProcessMessage();
    }

    private void ProcessMessage()
    {
        texture2D.LoadImage(imageData);
        texture2D.Apply();
        meshRenderer.material.SetTexture("_MainTex", texture2D);
    }
}
