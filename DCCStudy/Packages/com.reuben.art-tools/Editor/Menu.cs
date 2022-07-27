using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities;
using Sirenix.Utilities.Editor;
using UnityEditor;

namespace Reuben.ArtTools.Editor
{
    public class MainMenuWindow: OdinMenuEditorWindow
    {
        protected override OdinMenuTree BuildMenuTree()
        {
            var tree = new OdinMenuTree();
            tree.Add("Animation Clip", new AnimationClipTool(), EditorIcons.House);
            return tree;
        }

        [MenuItem("Tools/Art Tools")]
        private static void OpenWindow()
        {
            var window = GetWindow<MainMenuWindow>();
            window.position = GUIHelper.GetEditorWindowRect().AlignCenter(800, 600);
        }
    }
}