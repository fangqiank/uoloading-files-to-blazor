namespace UploadFilesLib
{
    public interface ISqlDataAccess
    {
        Task<List<T>> LoadData<T>(string storeProc, string connection, object? parameters);
        Task SaveData(string storeProc, string connection, object parameters);
    }
}