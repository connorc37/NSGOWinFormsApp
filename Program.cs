/**************************************************************
* Name        : NSGOWinFormsApp
* Author      : Corey Connor
* Created     : 04/28/2022
* Course      : CIS152 21508 - Data Structures
* Version     : 1.0
* OS          : Windows 11
* IDE         : Visual Studio 2022 using .NET 6
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Reads the files Netflix stores its subtitles in,
*               displays the subtitles, allows users to highlight
*               the ones they feel are important, and delivers
*               the important subtitles followed by a complete
*               list of subtitles as selectable and copyable text.
*               Input: File, selections.
*               Output: Subtitles as text.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access to
* my program.         
***************************************************************/

namespace NSGOWinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}