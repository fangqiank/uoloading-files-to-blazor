namespace UploadFilesLib
{
    public interface ISqlDataAccess
    {
        Task SaveData(string storeProc, string connection, object parameters);
    }
}