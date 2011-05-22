using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Productivity
{
    class WindowData
    {

        [DllImport("user32.dll")]
        static extern int GetWindowText(int hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        static extern int EnumWindows(GetWindowDelegate lpEnumFunc, int lParam);

        [DllImport("user32.dll")]
        static extern int GetWindowTextLength(int hwnd);

        

        private WindowInfo[] window_data;
        private static int MAX_WINDOW = 50;
        //private HashSet<WindowInfo> win_data;
        private static Dictionary<int, WindowInfo> win_data;
        

        private uint winnum;

        public WindowData()
        {
            //window_data = new WindowInfo[MAX_WINDOW];
            win_data = new Dictionary<int, WindowInfo>(MAX_WINDOW);

            winnum = 0;
        }

        public delegate int GetWindowDelegate(int hwnd, int lParam);

        GetWindowDelegate deleg = new GetWindowDelegate(getWindow);

        private static int getWindow(int hwnd, int lParam) {
            int slength;
            StringBuilder buffer;
            int retval;

            slength = GetWindowTextLength(hwnd) + 1;  // get length of title bar text
          if (slength > 1){ // if return value refers to non-empty string
            buffer = new StringBuilder(slength);  // make room in the buffer
            retval = GetWindowText(hwnd, buffer, slength);
            if (win_data.ContainsKey(hwnd))
                win_data[hwnd].is_here(true);
            else
                win_data.Add(hwnd, new WindowInfo(hwnd, buffer.ToString()));
            return 1;
          }

          return 1;
        }

        public Dictionary<int, WindowInfo> updateWindows()
        {
            foreach(KeyValuePair<int, WindowInfo> data in win_data)
            {
                data.Value.is_here(false);
            }

            EnumWindows(deleg, 0);
            foreach(KeyValuePair<int, WindowInfo> data in win_data)
            {
                if (data.Value.was_here == false)
                    win_data.Remove(data.Key);
            }

            return win_data;
        }

        public void prepareWindows() {
            
        }

        public bool isProductive(int hwnd)
        {
            uint i;
            for (i = 0; i < winnum; i++)
            {
                if (window_data[i].handle == hwnd)
                {
                    if (window_data[i].is_productive) return true; 
                    else return false;
                }
            }
            return false;
        }

        /*            Public Function EnumWindowsProc (ByVal hwnd As Long, ByVal lParam As Long) As Long
          Dim slength As Long, buffer As String  ' title bar text length and buffer
          Dim retval As Long  ' return value
          Static winnum As Integer  ' counter keeps track of how many windows have been enumerated

          winnum = winnum + 1  ' one more window enumerated....
          slength = GetWindowTextLength(hwnd) + 1  ' get length of title bar text
          If slength > 1  ' if return value refers to non-empty string
            buffer = Space(slength)  ' make room in the buffer
            retval = GetWindowText(hwnd, buffer, slength)  ' get title bar text
            Debug.Print "Window #"; winnum; " : ";  ' display number of enumerated window
            Debug.Print Left(buffer, slength - 1)  ' display title bar text of enumerated window
          End If

          EnumWindowsProc = 1  ' return value of 1 means continue enumeration
        End Function */
    }
}

public struct WindowInfo
{
    public string title;
    public int handle;
    public bool is_productive;
    public bool was_here;

    public WindowInfo(int hwnd, string title)
    {
        this.title = title;
        this.handle = hwnd;
        is_productive = false;
        was_here = true;
    }

    public void is_here(bool x)
    {
        was_here = x;
    }

}