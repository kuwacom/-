using System.Windows.Forms;
namespace 城之内
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*ApplicationConfiguration.Initialize();
            Application.Run(new Form1());*/
            MessageBox.Show("次回『城之内 死す』デュエルスタンバイ！。",
            "遊戯王デュエルモンスターズ 次回(#128)予告",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        }
    }
}