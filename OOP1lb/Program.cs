using OOP1lb.Others;

namespace OOP1lb
{
    internal static class Program
    {

        /// <summary>
        ///  ������� ����� � ����������.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Win32.MessageBox(0, "������������ ������ � 4", "������ 4: �����, �������", 0);
            
            Application.Run(new Form1());
        }
    }
}