using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


namespace Geekbrains 
{ 
public class MenuItems 
{
   [MenuItem("Geekbrains/����� ���� �0 %v")]
   private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindow), true, "Geekbrains1");
        }

        [MenuItem("Geekbrains/����� ���� �1 %#a")]
        private static void NewMenuOption() 
        {
        }

        [MenuItem("Geekbrains/����� ���� �2 %p")]
        private static void NewNestedOption()
        {
        }

        [MenuItem("Geekbrains/����� ���� �3 _q")]
        private static void NewOptionWithHotkey()
        {
        }

        [MenuItem("Geekbrains/����� ����/����� ���� �3 _q")]
        private static void NewOptionWithHot() 
        { 
        }

        [MenuItem("Assets/Geekbrains")]
        private static void LoadAdditiveScene()
        {
        }

        [MenuItem("Assets/Create/Geekbrains")]
        private static void AddConfig()
        {
        }
    }
}
