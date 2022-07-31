using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

namespace Reuben.ArtTools.Editor
{
    public class AnimationClipTool
    {
        [Title("Animation Tool")]
        [Button("Test")]
        void TestUse()
        {
            Debug.Log("Test!");
        }

        [Button("Hello")]
        void PrintHello()
        {
            Debug.Log("Hello world");
        }
    }
}