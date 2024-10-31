using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace NotepadTitleUpdater
{
    class Program
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetWindowText(IntPtr hWnd, string lpString);

        [DllImport("user32.dll")]
        private static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        static void Main()
        {
            while (true)
            {
                IntPtr notepadHandle = FindNotepadWindow();

                if (notepadHandle != IntPtr.Zero)
                {
                    string currentTime = DateTime.Now.ToString("HH:mm:ss");
                    string newTitle = $"Блокнот - {currentTime}";

                    // Обновляем заголовок окна
                    if (!SetWindowText(notepadHandle, newTitle))
                    {
                        Console.WriteLine("Не удалось изменить заголовок.");
                    }
                }
                else
                {
                    Console.WriteLine("Окно Блокнота не найдено.");
                }

                Thread.Sleep(1000);
            }
        }

        private static IntPtr FindNotepadWindow()
        {
            // Поиск окна Блокнота
            IntPtr handle = FindWindow("Notepad", null);
            if (handle != IntPtr.Zero)
            {
                return handle;
            }

            IntPtr foundHandle = IntPtr.Zero;

            // Перечисляем окна
            EnumWindows((hWnd, lParam) =>
            {
                StringBuilder windowText = new StringBuilder(256);
                GetWindowText(hWnd, windowText, windowText.Capacity);

                if (windowText.ToString().Contains("Блокнот"))
                {
                    foundHandle = hWnd;
                    return false; // Останавливаем перечисление
                }

                return true; // Продолжаем перечисление
            }, IntPtr.Zero);

            return foundHandle;
        }
    }
}
