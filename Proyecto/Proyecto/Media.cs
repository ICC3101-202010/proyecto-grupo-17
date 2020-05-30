using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Proyecto
{
    [Serializable]
    public abstract class Media
    {
        protected Dictionary<string, string> Information;
        protected int UsersLike;
        protected double Score;
        protected int Views;
        protected string FileName;
        protected double Duration;


        public Media(string fileName)
        {
            AddInfo(fileName);
            FileName = fileName;
            UsersLike = 0;
            Score = 0;
            Views = 0;
        }

        public void MetadataInfo()
        {

        }
        public void SetScore()
        {
            //Event con score que saca promedio
        }

        public void SetViews()
        {
            //Event con play
        }

        public abstract Metadata GetMetadata();

        public void TiempoReproduccion()
        {

        }

        public void AddInfo(string fileName)
        {
            string format = "";
            string duration = ""; //segundos
            double durNum = 0;
            FileInfo fi = new FileInfo(fileName);
            long size = fi.Length;
            string fileSize = $"{size}bytes";
            string sel = "";
            List<string> formatList = new List<string>()
            {
                "AAC	Audio",
                "AVI	Video",
                "MKV	Video",
                "MOV	Video",
                "MP3	Audio",
                "MP4	Video",
                "OOG	Audio",
                "QT		Video",
                "VCD	Video",
                "WAV	Audio",
                "WMA	Audio",
                "WMV	Video"
            };

            List<string> infoOp = new List<string>() {"Duration: hh:mm:ss", "Format: ", "Done!" };

            while (true)
            {
                sel = RegexUtilities.GetMenu(infoOp);

                if (sel == infoOp[0])
                {
                    infoOp[0] = infoOp[0].Substring(0, 18);
                    Console.Clear();
                    Console.CursorVisible = true;
                    while (true)
                    {
                        duration = RegexUtilities.WriteData(infoOp[0]);
                        try
                        {
                            string[] hms = duration.Split(':');
                            int hrs = Convert.ToInt32(hms[0]);
                            int min = Convert.ToInt32(hms[1]);
                            int sec = Convert.ToInt32(hms[2]);
                            TimeSpan time = new TimeSpan(hrs, min, sec);
                            durNum = time.TotalSeconds;
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please write a valid duration of hours, minutes and seconds, separated by :");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                    }
                    infoOp[0] = infoOp[0].Substring(0, 14);
                    Console.CursorVisible = false;
                    infoOp[0] += duration;
                    Console.Clear();
                }

                else if (sel == infoOp[1])
                {
                    infoOp[1] = infoOp[1].Substring(0, 8);
                    Console.Clear();
                    format = "";
                    while (format == "")
                    {
                        format = RegexUtilities.GetMenu(formatList);
                    }
                    Console.CursorVisible = false;
                    infoOp[1] += format;
                    Console.Clear();
                }

                else if (sel == infoOp[2])
                {
                    if (format != "" && duration != "")
                    {
                        Dictionary<string, string> info = new Dictionary<string, string>();
                        info.Add("format", format);
                        duration = $"{durNum}";
                        info.Add("duration", duration);
                        Duration = durNum;
                        Information = info;
                        return;
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Information missing!");
                        Thread.Sleep(1200);
                    }

                }
    
            }


            
        }


        public void Play()
        {

            Process ps = new Process();

            ps.StartInfo.FileName = "mplayer";

            ps.StartInfo.UseShellExecute = false;
            ps.StartInfo.RedirectStandardInput = true;
            string args = "-nofs -really-quiet -identify -slave -nomouseinput -sub-fuzziness 1 ";
            ps.StartInfo.Arguments = args + " \"" + FileName + "\"";
            ps.Start();
            
        }

        public void AddToQueue()
        {

        }

        public void AddLike(bool a)
        {
            // Event

            if (a == true)
            {
                UsersLike += 1;
            }
            else
            {
                UsersLike -= 1;
            }
            
        }
        
    }
}
