/*


static string fileNameUsers = "SpotflixUsers.bin";
static string fileNameMedia = "SpotflixMedia.bin";


Dictionary<string, User> loadUsers = LoadUsers(fileNameUsers);
            List<Media> loadMedia = LoadMedia(fileNameMedia);

            Spotflix.SetUserDB(loadUsers);
            Spotflix.SetMediaDB(loadMedia);




public static void SaveUsers(Dictionary<string, User> userDB, string name)
{

    Stream stream = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
    IFormatter formatter = new BinaryFormatter();
    formatter.Serialize(stream, userDB);
    stream.Close();
}

public static void SaveMedia(List<Media> mediaDB, string name)
{

    Stream stream = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
    IFormatter formatter = new BinaryFormatter();
    formatter.Serialize(stream, mediaDB);
    stream.Close();
}


public static Dictionary<string, User> LoadUsers(string name)
{
    Stream stream = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
    IFormatter formatter = new BinaryFormatter();
    Dictionary<string, User> userDB = (Dictionary<string, User>)formatter.Deserialize(stream);
    stream.Close();

    return userDB;
}

public static List<Media> LoadMedia(string name)
{
    Stream stream = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
    IFormatter formatter = new BinaryFormatter();
    List<Media> mediaDB = (List<Media>)formatter.Deserialize(stream);
    stream.Close();

    return mediaDB;
}

public static void SaveAll()
{
    SaveUsers(Spotflix.GetUserDB, fileNameUsers);
    SaveMedia(Spotflix.GetMediaDB, fileNameMedia);
}



OpenFileDialog***

ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = @"..\..\ffmpeg.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = command;

            Process exeProcess = Process.Start(startInfo);




public static bool Is_Media(FileInfo file)
            {
                switch (file.Extension.ToLower())
                {
                    case ".jpeg":
                    case ".gif":
                    case ".bmp":
                    case ".png":
                    case ".3gp":
                    case ".aac":
                    case ".m4a":
                    case ".mp3":
                    case ".ogg":
                    case ".wav":
                    case ".wma":
                    case ".webm":
                    case ".mkv":
                    case ".flv":
                    case ".vob":
                    case ".avi":
                    case ".mov":
                    case ".wmv":
                    case ".mp4":
                    case ".mpg":
                    case ".mpeg":
                    case ".m4v":
                        return true;
                    default:
                        return false;
                }
            }

idea: pelicula random con ciertos filtros para ver algo rapido sin elegir.
filtros: genero, duracion, incl/excl actores/directores, seen, etc.


ps = new Process();

//Path of Mplayer exe
ps.StartInfo.FileName = "mplayer ";

ps.StartInfo.UseShellExecute = false;
ps.StartInfo.RedirectStandardInput = true;
args = "-nofs -noquiet -identify -slave ";
args += "-nomouseinput -sub-fuzziness 1 ";

//-wid will tell MPlayer to show output inside our panel
args += " -vo direct3d, -ao dsound  -wid ";
int id = (int)panel1.Handle;
args += id;





################################################################################
#        ##        ##        ##        ##        ##  ########        ##  ####  #
#  ########  ####  ##  ####  #####  #####  ########  ###########  ######  ##  ##
#        ##        ##  ####  #####  #####      ####  ###########  ########  ####
#######  ##  ########  ####  #####  #####  ########  ###########  ######  ##  ##
#        ##  ########        #####  #####  ########        ##        ##  ####  #
################################################################################













 */