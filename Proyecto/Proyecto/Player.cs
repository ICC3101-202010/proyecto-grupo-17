using System;
using System.Diagnostics;

namespace Proyecto
{
    public class Player
    {
        string args = "";
        string filename = null;
        Process ps = null;




        public Player()
        {
            ps = new Process();

            ps.StartInfo.FileName = "mplayer";

            ps.StartInfo.UseShellExecute = false;
            ps.StartInfo.RedirectStandardInput = true;
            args = "-nofs -really-quiet -identify -slave ";
            args += "-nomouseinput -sub-fuzziness 1 ";
            args += " -vo direct3d, -ao dsound  -wid ";
            
        }



        public void Open(string filename)
        {
            if (filename == null)
                return;
            //Close any current playing media file
            try
            {
                ps.Kill();
            }
            catch
            {
            }
            try
            {
                ps.StartInfo.Arguments = args + " \"" + filename + "\"";
                ps.Start();
                
            }
            catch (Exception)
            {
            }
        }

        public bool SendCommand(string cmd)
        {
            try
            {
                if (ps != null && ps.HasExited == false)
                {
                    ps.StandardInput.Write(cmd + "\n");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public void End()
        {
            ps.Kill();
        }
    }
}
