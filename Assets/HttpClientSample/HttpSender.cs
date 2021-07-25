using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine;
using UnityEngine.Networking;

namespace HttpClientSample
{
    public class HttpSender : MonoBehaviour
    {
        private SendData _data;
        
        [SerializeField]
        private string URL = "http://localhost:3000";

        private void Start()
        {
            _data = new SendData()
            {
                name = "hoge",
                position = new Vector3(1f, 2f, 3f),
                rotation = Quaternion.identity
            };

        }

        private async Task PostRequestAsync(string jsonData)
        {
            var request = new UnityWebRequest(URL, "POST");
            byte[] byteRaw = Encoding.UTF8.GetBytes(jsonData);
            request.uploadHandler = new UploadHandlerRaw(byteRaw);
            request.downloadHandler = new DownloadHandlerBuffer();
            request.SetRequestHeader("Content-Type", "application/json");

            await request.SendWebRequest();
            
            Debug.Log("Send data.");
        }

        public void SendPostRequest()
        {
            var sendData = JsonUtility.ToJson(_data);
            _ = PostRequestAsync(sendData);
        }
    }
}