using System;
using System.Runtime.CompilerServices;

namespace E3DEngine
{
    public enum MouseButton
    {
        LeftButton = 0,
        RightButton,
        MiddleButton,
        UnKnown
    };

    public class MouseButtonInfo
    {
        public MouseButton mButton;
        public int mPositionX;
        public int mPositionY;
    }
    public enum KeyCode
    {
        KeyUnKnown,
        KeyA, KeyB, KeyC, KeyD, KeyE, KeyF, KeyG, KeyH, KeyI, KeyJ, KeyK, KeyL, KeyM,
        KeyN, KeyO, KeyP, KeyQ, KeyR, KeyS, KeyT, KeyU, KeyV, KeyW, KeyX, KeyY, KeyZ,
        Key1, Key2, Key3, Key4, Key5, Key6, Key7, Key8, Key9, Key0,
        KeySheift, KeyAlt, KeyWin, KeyBack, KeySpace, KeyEnter, KeyDelete,
        KeyF1, KeyF2, KeyF3, KeyF4, KeyF5, KeyF6, KeyF7, KeyF8, KeyF9, KeyF10, KeyF11, KeyF12,
    };

    public class Application
	{

        public static string AppDataPath
        {
            get;set;
        }

        public static string ResourcePath
        {
            get;set;
        }

        public Application()
		{
		}

        public static void Initialize()
        {

        }

        public static void CreatScript()
        {

        }
        public static void StartApp()
        {

        }

        public static void StopApp()
        {

        }

        public static void UpdateApp(float deltaTime)
        {

        }

        public static void Destory()
        {

        }

        public static void ExitApp()
        {

        }

        public static void MouseButtonDown(MouseButton mButton, Vector2 pos)
        {

        }

        public static void MouseButtonUp(MouseButton mButton, Vector2 pos)
        {

        }

        public static void MouseMove(Vector2 position)
        {

        }

        public static void KeyDown(char key)
        {

        }
        public static void KeyUp(char key)
        {

        }

        public static void Exit()
        {

        }
    }
}
