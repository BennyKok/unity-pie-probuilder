using UnityEngine;
using UnityEditor.ProBuilder;
using UnityEditor;
using UnityEngine.ProBuilder;

#if UNITY_2020_2_OR_NEWER
using ToolManager = UnityEditor.EditorTools.ToolManager;
#else
using ToolManager = UnityEditor.EditorTools.EditorTools;
#endif

namespace BennyKok.Pie.PB.Editor
{
    public class ProBuilderPie
    {
        [PieMenu(path = "Selection/Face")]
        public static void FaceMode()
        {
            ProBuilderEditor.selectMode = SelectMode.Face;
        }

        [PieMenu(path = "Selection/Edge")]
        public static void EdgeMode()
        {
            ProBuilderEditor.selectMode = SelectMode.Edge;
        }

        [PieMenu(path = "Selection/Vertex")]
        public static void VertexMode()
        {
            ProBuilderEditor.selectMode = SelectMode.Vertex;
        }

        [PieMenu(path = "Selection/Object")]
        public static void ObjectMode()
        {
            ProBuilderEditor.selectMode = SelectMode.Object;
        }

        [PieMenu(path = "New Shape")]
        public static void Shape()
        {
            Event e = Event.KeyboardEvent("k");
            e.modifiers = EventModifiers.Control | EventModifiers.Shift;
            EditorWindow.focusedWindow.SendEvent(e);
        }

        [PieMenu(path = "Mesh/Subdivide")]
        public static void Subdivide()
        {
            Event e = Event.KeyboardEvent("s");
            e.modifiers = EventModifiers.Alt;
            EditorWindow.focusedWindow.SendEvent(e);
        }

    }
}