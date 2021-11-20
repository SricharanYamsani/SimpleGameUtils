using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleGameUtils
{
    public class GameUtils
    {
        private static Camera mainCamera;
        public static Camera MainCamera
        {
            get
            {
                if(mainCamera == null)
                {
                    mainCamera = Camera.main;
                }
                return mainCamera;
            }
        }
    }
}
