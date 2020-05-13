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




































 */