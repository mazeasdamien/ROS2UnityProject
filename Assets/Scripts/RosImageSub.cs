using UnityEngine;
using UnityEngine.UI;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Sensor;

public class RosImageSub : MonoBehaviour
{
    public RawImage rawTexture;
    public string topicName;
    private Texture2D texture2D;
    private byte[] imageData;
    private bool isMessageReceived;

    void Start()
    {
        texture2D = new Texture2D(1, 1);
        ROSConnection.instance.Subscribe<CompressedImageMsg>(topicName, UpdateImage);
    }

    void UpdateImage(CompressedImageMsg image)
    {
        imageData = image.data;
        isMessageReceived = true;
        if (isMessageReceived)
            ProcessMessage();
    }

    private void ProcessMessage()
    {
        texture2D.LoadImage(imageData);
        texture2D.Apply();
        rawTexture.texture = texture2D;
        isMessageReceived = false;
    }
}
